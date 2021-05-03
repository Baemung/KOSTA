using System;

namespace MyClassLibrary
{
    public class myLib
    {
        public static int Get_Count(char deli, string str)
        {
            string[] strs = str.Split(deli);
            int n = strs.Length;
            return n - 1;
        }

        public static string Get_Token(char deli, string str, int index)
        {
            string[] strs = str.Split(deli);
            string ret = strs[index];
            //string fName = openFileDialog1.SafeFileName;
            return ret;
        }
    }
}
