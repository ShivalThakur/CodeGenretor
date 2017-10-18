using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SearchFile
{
    public partial class password : Form
    {
        private const string MenuName = "Folder\\shell\\NewMenuOption";
        private const string Command = "Folder\\shell\\NewMenuOption\\command";
        public password()
        {
            InitializeComponent();
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.ToLower() == "shival")
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();
                    if (checkBox1.Checked)
                    {
                        Registry.CurrentUser.CreateSubKey("shival_Key").SetValue("password","shival");

                    }
                    /////make Shortcut
                    if (checkBox2.Checked)
                    {
                        RegistryKey regmenu = null;
                        RegistryKey regcmd = null;
                        try
                        {
                            regmenu = Registry.ClassesRoot.CreateSubKey(MenuName);
                            if (regmenu != null)
                                regmenu.SetValue("", "Shival");
                            regcmd = Registry.ClassesRoot.CreateSubKey(Command);
                            if (regcmd != null)
                                regcmd.SetValue("", "cmd");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, ex.ToString());
                        }
                        finally
                        {
                            if (regmenu != null)
                                regmenu.Close();
                            if (regcmd != null)
                                regcmd.Close();
                        }        
                    }
                }
                else
                {
                    MessageBox.Show("Wrong password entered!!");
                }
            }
            else
            {
                MessageBox.Show("Please enter password!!");
            }
        }

        private void password_Load(object sender, EventArgs e)
        {


           
        }

        private void password_Shown(object sender, EventArgs e)
        {
            try
            {
                string pwdKey = Registry.GetValue(@"HKEY_CURRENT_USER\shival_Key", "password", "").ToString();//.GetValue("shival_Key").ToString();
                if (pwdKey.ToLower() == "shival")
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();

                }
            }
            catch (Exception ex) { }
        }
    }
}
