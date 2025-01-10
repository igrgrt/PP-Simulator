using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Simulator._1
{
 
    public static class Validator
    {
        public static int Limiter(int value, int min, int max)
        {
            return Math.Clamp(value, min, max);
        }

        public static string Shortener(string value, int min, int max, char placeholder)
        {
            string newName = value.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                newName = "Unknown";
            }

            if (newName.Length > max)
            {
                newName = newName.Substring(0, max).Trim();
            }

            if (newName.Length < min)
            {
                newName = newName.PadRight(min, placeholder);
            }

            if (char.IsLower(newName[0]))
            {
                newName = char.ToUpper(newName[0]) + newName.Substring(1);
            }

            return newName;
        }
    }

}
