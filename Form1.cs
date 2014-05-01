using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace AutoLoginWinNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getAutoAdminLogon.Text = "AutoAdminLogon=" + GetAutoAdminLogin();
        }
      
        public string GetAutoAdminLogin()
        {
            const string userRoot = "HKEY_LOCAL_MACHINE";
            const string subkey = @"\\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            const string keyName = userRoot + "\\" + subkey;
            string adminValue = Registry.GetValue(keyName, "AutoAdminLogin", "").ToString();
            return adminValue;

        }
    }
    
}
