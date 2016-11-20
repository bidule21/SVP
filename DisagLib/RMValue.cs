using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DisagLib
{
    public class RMValue
    {
        public RMValue(string value, string description)
        {
            Value = value;
            Description = description;
        }
        public string Description;
        public string Value;

        public override string ToString()
        {
            return Description;
        }
    }
}
