using DisagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVP
{
    internal static class Common
    {
        internal static List<RMResult> readShots(string profile)
        {
            DISAGRM machine = new DISAGRM();
            try
            {
                machine.Start(SVP.Properties.Settings.Default.ComPort);
                Task<List<RMResult>> ta = Task.Factory.StartNew<List<RMResult>>(() => machine.GetShots(profile));
                ta.Wait(30000); //30 Sec
                if (ta.IsCompleted)
                    return ta.Result;
                else
                    throw new Exception("Die Maschine hat nicht schnell genug geantwortet");
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim einlesen der Ergebnisse:\r\n" + e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                machine.Stop();
            }
            return null;
        }
        internal static List<RMResult> readFakeShots(string profile)
        {
            List<RMResult> result = new List<RMResult>();
            Random rand = new Random();
            for(int i = 0;i<10;i++)
            {
                RMResult res = new RMResult();
                res.Angle = 10;
                res.FactorValue = 10;
                res.Rings = rand.Next(11);
                res.ShotNumber = (i + 1);
                res.Validity = ValidFlag.Valid;
                result.Add(res);
            }
            return result;
        }
    }
}
