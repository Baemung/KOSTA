using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myLibrary
{
    public partial class LibSource : Form
    {
        public LibSource()
        {
            InitializeComponent();
        }
    }

    public class iniFile
    {
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string sec, string key, string defstr, StringBuilder sb, int size, string path);

        [DllImport("kernel32")]
        static extern int WritePrivateProfileString(string sec, string key, string str, string path);

        public iniFile(string path)
        {
            iniPath = path;
        }

        string iniPath = "";
        public string GetString(string sec, string key, string def = "")
        {
            StringBuilder sb512 = new StringBuilder(512);
            GetPrivateProfileString(sec, key, def, sb512, 512, iniPath);
            return sb512.ToString();
        }
        public int SetString(string sec, string key, string val)
        {
            return WritePrivateProfileString(sec, key, val, iniPath);
        }
    }
}
