using DisagLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVP
{
    internal class DisplayResult
    {
        public string Name { get; private set; }
        public double ResultSum { get; private set; }
        public List<RMResult> Results { get; private set; } //private set

        public DisplayResult(string name, List<RMResult> results)
        {
            this.Name = name;
            this.ResultSum = 0;
            this.Results = results;
            foreach (RMResult result in results)
                this.ResultSum += result.Rings;
        }
    }
}
