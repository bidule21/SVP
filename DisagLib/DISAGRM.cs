using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;

namespace DisagLib
{
    public class DISAGRM
    {
        private const byte ENQ = 0x05;
        private const byte STX = 0x02;
        private const byte ACK = 0x06;
        private const byte CR = 0x0D;
        private bool started;
        private SerialPort _serialport;
        private Stopwatch stopwatch;
        public DISAGRM()
        {
            stopwatch = new Stopwatch();
        }

        public void Start(string portName)
        {
            _serialport = new SerialPort(portName, 38400, Parity.None, 8, StopBits.One);
            _serialport.Open();
            started = true;
        }

        public List<RMResult> GetShots(string profile)
        {
            List<RMResult> results = new List<RMResult>();
            int counter = 0;
            byte ackByte = 0;
            string reply = "";
            if (!started)
                throw new Exception("No answer from the machine. Is it connected wrongly?");
            writeByte(ENQ);
            while (counter < 300 && ackByte != STX)
            {
                ackByte = readByte();
                Thread.Sleep(100);
            }
            if (counter >= 300)
                throw new Exception("The machine is not ready!");
            ackByte = 0;
            counter = 0;
            while (counter < 3 && ackByte != ACK)
            {
                writeBytes(getProfileBytes(profile));
                Thread.Sleep(300);
                ackByte = readByte();
            }
            if (counter >= 3)
                throw new Exception("The machine does not accept this profile");
            while (!reply.Equals("WSE")) //WSE = Warte auf Scheibe Ende
            {
                reply = readReply();
                if (reply.Equals("STA")) //STA = Auswerte Start
                    Debug.WriteLine("Starting evaluation");
                else if (reply.StartsWith("SCH"))
                    results.Add(getResultFromReply(reply));
                //else if (!reply.Equals("WSE"))
                //    throw new Exception("Got an unknown answer from the machine: " + reply);
            }
            return results;

        }

        private void writeByte(byte b)
        {
            _serialport.Write(new byte[] { b }, 0, 1);
        }

        private void writeBytes(byte[] b)
        {
            _serialport.Write(b, 0, b.Length);
        }

        private byte readByte()
        {
            return (byte)_serialport.ReadByte();
        }

        private string readReply()
        {
            byte checksum = 0x00;
            byte[] read = new byte[128];
            int counter = 0;
            string reply = "";
            while (read[counter] != CR)
            {
                read[counter] = readByte();
                if (read[counter] == CR)
                {
                    break;
                }
                counter++;
            }
            for (int i = 0; i < counter - 1; i++) // -1 for checksum
            {
                reply += (char)read[i];
                checksum ^= read[i];
            }
            //if (checksum != read[counter - 1])
            //    throw new Exception("Got invalid checksum.");
            writeByte(ACK);
            return reply;
        }

        private byte[] getProfileBytes(string profile)
        {
            byte checksum = 0x00;
            byte[] read = new byte[profile.Length + 2];
            int i = 0;
            for (i = 0; i < profile.Length; i++)
            {
                read[i] = (byte)profile.ToCharArray()[i];
                checksum ^= (byte)profile.ToCharArray()[i];
            }
            if (checksum < 32)
                checksum += 32;
            read[i++] = checksum;
            read[i] = CR;
            return read;
        }

        private RMResult getResultFromReply(string reply)
        {
            RMResult result = new RMResult();
            string[] values = reply.Split(';');
            result.ShotNumber = int.Parse(values[0].Split('=')[1]);
            result.Rings = double.Parse(values[1]);
            result.FactorValue = double.Parse(values[2]);
            result.Angle = double.Parse(values[3]);
            switch (values[4])
            {
                case "G":
                    result.Validity = ValidFlag.Valid;
                    break;
                case "K":
                    result.Validity = ValidFlag.HasToBeChecked;
                    break;
                case "U":
                    result.Validity = ValidFlag.NotValid;
                    break;
                default:
                    throw new Exception("Got unexpected Value for Validity");
            }
            return result;
        }
    }
}
