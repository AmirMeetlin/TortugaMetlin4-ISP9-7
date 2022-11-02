using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaMetlin4_ISP9_7.ClassHelper
{
    internal class AppData
    {
        public static EF.Entities Context { get; } = new EF.Entities();
    }
}
