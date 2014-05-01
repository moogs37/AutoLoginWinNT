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
            ListViewItem lvi = new ListViewItem("TEST");
            lvi.SubItems.Add("Subitem");
            listView1.Items.Add(lvi);

            

        }
        public string GetAutoAdminLogin()
        {
            const string userRoot = "HKEY_LOCAL_MACHINE";
            const string subkey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            const string keyName = userRoot + "\\" + subkey;
            string adminValue = Registry.GetValue(keyName, "AutoAdminLogon", "Undefined").ToString();
            return adminValue;
        }
        public string GetDefaultUserName()
        {
            const string userRoot = "HKEY_LOCAL_MACHINE";
            const string subkey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            const string keyName = userRoot + "\\" + subkey;
            string adminValue = Registry.GetValue(keyName, "DefaultUserName", "Undefined").ToString();
            return adminValue;
        }
        public string GetDefaultPassword()
        {
            const string userRoot = "HKEY_LOCAL_MACHINE";
            const string subkey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            const string keyName = userRoot + "\\" + subkey;
            string adminValue = Registry.GetValue(keyName, "DefaultPassword", "Undefined").ToString();
            return adminValue;
        }
        public string GetDefaultDomainName()
        {
            const string userRoot = "HKEY_LOCAL_MACHINE";
            const string subkey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
            const string keyName = userRoot + "\\" + subkey;
            string adminValue = Registry.GetValue(keyName, "DefaultDomainName", "Undefined").ToString();
            return adminValue;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem AutoAdminLogonRow = new ListViewItem("Auto Admin Logon");
            AutoAdminLogonRow.SubItems.Add(GetAutoAdminLogin());

        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
       {
           Application.Exit();  // Exit application
       }

    }
    
}
