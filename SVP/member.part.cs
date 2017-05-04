using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVP
{
    public partial class Member
    {
        public override string ToString()
        {
            return this.Name + ", " + this.Firstname;
        }
    }
}
