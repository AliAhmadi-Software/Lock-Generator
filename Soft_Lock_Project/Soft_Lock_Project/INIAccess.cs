using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace resolution_changer
{
    class INIAccess
    {
        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        public void INIWrite(string INIPath, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, INIPath);
        }
        public string INIRead(string INIPath, string Section, string Key, string DefualtValue = "")
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, DefualtValue, temp, 255, INIPath);
            return temp.ToString();
        }
    }
}
