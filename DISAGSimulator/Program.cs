using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace DISAGSimulator
{
    enum state
    {
        IDLE,
    }
    class Program
    {
        private const byte ENQ = 0x05;
        private const byte STX = 0x02;
        private const byte ACK = 0x06;
        private const byte NACK = 0x15;
        private const byte CR = 0x0D;
        static void Main(string[] args)
        {
            SerialPort sp = new SerialPort("COM42", 38400, Parity.None, 8, StopBits.One);
            sp.Open();
            int c = sp.ReadChar();
            if(c == ENQ)
            {
                sp.Write(new byte[] { STX }, 0, 1);
                string config = sp.ReadLine();
                try
                {

                }
                catch
                {
                    sp.Write(new byte[] { NACK }, 0, 1);
                }
                finally
                {
                    sp.Write(new byte[] { ACK }, 0, 1);
                }
                c = sp.ReadChar();
                if(c == ENQ)
                {
                    sp.Write(new byte[] { STX }, 0, 1);
                }
            }
        }
    }
}
