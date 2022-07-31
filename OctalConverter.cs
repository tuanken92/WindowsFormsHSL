using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsHSL
{
    public static class OctalConverter
    {
        public static string hex2Octal(string hexvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 8);
            return binaryval;
        }

        public static string octal2hex(string octalvalue)
        {
            string binaryval = "";
            binaryval = Convert.ToString(Convert.ToInt32(octalvalue, 8), 16);
            return binaryval;
        }

    }
}
