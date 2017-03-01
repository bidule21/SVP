using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVP
{
    public partial class member
    {
        public override string ToString()
        {
            return this.name + ", " + this.firstname;
        }
    }
}
