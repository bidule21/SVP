using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVP
{
    internal sealed class ComboboxItem
    {
        public string Value { get; }
        public int Id { get; }
        public ComboboxItem(string value, int id)
        {
            this.Value = value;
            this.Id = id;
        }
        public override string ToString()
        {
            return Value;
        }
    }
}
