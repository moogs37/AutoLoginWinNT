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
           // Displaying all the current registry settings
           autoAdminLogonCVTB.Text = GetAutoAdminLogin();
           defaultUserNameCVTB.Text = GetDefaultUserName();
           defaultPasswordCVTB.Text = GetDefaultPassword();
           defaultDomainNameCVTB.Text = GetDefaultDomainName();

            //Read only display
           autoAdminLogonCVTB.ReadOnly = true;
           defaultUserNameCVTB.ReadOnly = true;
           defaultPasswordCVTB.ReadOnly = true;
           defaultDomainNameCVTB.ReadOnly = true;
        }
        public string setAutoAdminLogon()
        {
            string newAutoAdminLogon = autoAdminLogonNVTB.Text;
            return newAutoAdminLogon;
        }
        public string setDefaultUserName()
        {
            string newDefaultUserName = defaultUserNameNVTB.Text;
            return newDefaultUserName;
        }
        public string setDefaultPassword()
        {
            string newDefaultPassword = defaultPasswordNVTB.Text;
            return newDefaultPassword;
        }
        public string setDefaultDomainName()
        {
            string newDefaultDomainName = defaultDomainNameNVTB.Text;
            return newDefaultDomainName;
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

        }

       private void label1_Click(object sender, EventArgs e)
        {

        }

       private void button2_Click(object sender, EventArgs e)
       {
           // Exit application
           Application.Exit();                                                                          
       }

       private void label1_Click_1(object sender, EventArgs e)
       {

       }

       private void label1_Click_2(object sender, EventArgs e)
       {

       }

       private void Form1_Load_1(object sender, EventArgs e)
       {

       }
       public void processRequest()
       {
           if (string.IsNullOrWhiteSpace(this.autoAdminLogonNVTB.Text) &&
               string.IsNullOrWhiteSpace(this.defaultDomainNameNVTB.Text) &&
               string.IsNullOrWhiteSpace(this.defaultPasswordNVTB.Text) &&
               string.IsNullOrWhiteSpace(this.defaultDomainNameNVTB.Text))
           {    DialogResult result = MessageBox.Show("No data was entered into the system.  By clicking Yes, you will erase all previously stored values.  Proceed?", "Warning",
                   MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    setValues();
                }
           }
           else setValues();
       }
       public void setValues()
       {
           const string userRoot = "HKEY_LOCAL_MACHINE";
           const string subkey = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon";
           const string keyName = userRoot + "\\" + subkey;

           // Passing values on user click
           Registry.SetValue(keyName, "AutoAdminLogon", setAutoAdminLogon(), RegistryValueKind.String);
           Registry.SetValue(keyName, "DefaultUserName", setDefaultUserName(), RegistryValueKind.String);
           Registry.SetValue(keyName, "DefaultPassword", setDefaultPassword(), RegistryValueKind.String);
           Registry.SetValue(keyName, "DefaultDomainName", setDefaultDomainName(), RegistryValueKind.String);
       }
       private void button1_Click(object sender, EventArgs e)
       {
           processRequest();
       }

    }
    
}
