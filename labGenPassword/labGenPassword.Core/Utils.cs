using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGenPassword.Core
{
    public static class Utils
    {
        public static string RandomStr(int aLength, bool aLower, bool aUpper, bool aNumbr, bool aSpecl)
        {
            string c1 = "abcdefghijklnopqrstuvwxyz";
            string c2 = "0123456789";
            string c3 = "[]{}<>,.;:-+#";

            var x = new StringBuilder();
            var xResult = new StringBuilder();
            Random rnd = new Random();

            if (aLower) x.Append(c1);
            if (aUpper) x.Append(c1.ToUpper());
            if (aNumbr) x.Append(c2);
            if (aSpecl) x.Append(c3);

            if (x.ToString() == "") x.Append(c1);

            while (xResult.Length < aLength)
                xResult.Append(x[rnd.Next(x.Length)]);
            return xResult.ToString();
        }
        
    }
}
