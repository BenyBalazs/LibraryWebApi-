using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWebApi
{
    public static class NameValidator
    {
        private static char[] IllegalChars = { '$', '{', '}', '@', '&', '#' };
        private static bool NameChacker(string Name)
        {
            if (Name == null)
                return false;
            try
            {
                for (int i = 0; i < IllegalChars.Length; i++)
                    if (Name.Contains(IllegalChars[i]))
                        return false;

                if (Name.Any(char.IsDigit))
                    return false;

                return true;
            }catch(Exception e) { return false; }


        }

        public static string ValidateName(string name)
        {
            if (NameChacker(name))
                return name;
            throw new ArgumentException("Invalid Name");
        }
    }
}
