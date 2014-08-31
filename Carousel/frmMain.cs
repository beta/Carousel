using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotRas;
using Microsoft.Win32;

namespace Carousel {
    public partial class frmMain : Form {
        private bool willClose;
        private bool connected;
        private RasHandle handle = null;
        private RasConnection connection = null;

        public frmMain() {
            InitializeComponent();

            willClose = false;
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            readCredential();

            if (checkAuto.Checked) {
                connect();
            }
        }

        private void connect() {
            // connect

            if (textUsername.Text.Length == 0 || textPassword.Text.Length == 0) {
                MessageBox.Show("账号或密码信息不完整！", "Carousel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textUsername.Enabled = textPassword.Enabled = false;
            checkRemember.Enabled = checkAuto.Enabled = false;
            buttonConnect.Text = "连接中……";
            buttonConnect.Enabled = false;
            notifyIcon.Text = "Carousel - 连接中";

            try {
                RasEntry entry = RasEntry.CreateBroadbandEntry("Carousel", RasDevice.GetDeviceByName("PPPOE", RasDeviceType.PPPoE, false));
                entry.FramingProtocol = RasFramingProtocol.Ppp;
                entry.RedialCount = 3;
                entry.RedialPause = 12;
                entry.PhoneNumber = " ";

                RasPhoneBook phoneBook = new RasPhoneBook();
                phoneBook.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers));
                phoneBook.Entries.Clear();
                phoneBook.Entries.Add(entry);

                RasDialer dialer = new RasDialer();
                dialer.EntryName = "Carousel";
                dialer.PhoneNumber = "";
                string username = textUsername.Text + "@wo201";
                string passwd = "" + (char)(1) + textPassword.Text;
                dialer.Credentials = new System.Net.NetworkCredential(username, passwd);
                dialer.AllowUseStoredCredentials = true;

                dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.AllUsers);
                dialer.Timeout = 1000;
                handle = dialer.Dial();
                connection = RasConnection.GetActiveConnectionByHandle(handle);

                // success
                connected = true;

                // save credentials to registry
                if (checkRemember.Checked) {
                    saveCredential(textUsername.Text, textPassword.Text, true, checkAuto.Checked);
                } else {
                    saveCredential("", "", false, false);
                }

                textUsername.Enabled = textPassword.Enabled = false;
                buttonConnect.Text = "已连接";
                buttonConnect.Visible = false;
                buttonConnect.Enabled = false;
                buttonDisconnect.Visible = true;
                buttonDisconnect.Enabled = true;
                this.Hide();
                notifyIcon.Text = "Carousel - 已连接";
                notifyIcon.ShowBalloonTip(3000, "Carousel", "已连接", ToolTipIcon.Info);
            } catch (Exception ex) {
                // fail
                MessageBox.Show("连接错误，错误信息：" + ex.Message, "Carousel", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textUsername.Enabled = textPassword.Enabled = true;
                checkRemember.Enabled = checkAuto.Enabled = true;
                buttonConnect.Text = "连接";
                buttonConnect.Enabled = true;
            }
        }

        private void disconnect() {
            // disconnect

            if (connected && handle != null && connection != null) {
                try {
                    buttonDisconnect.Enabled = false;

                    connection.HangUp();

                    connected = false;
                    textUsername.Enabled = textPassword.Enabled = true;
                    checkRemember.Enabled = checkAuto.Enabled = true;
                    buttonConnect.Text = "连接";
                    buttonConnect.Enabled = true;
                    buttonConnect.Visible = true;
                    buttonDisconnect.Enabled = false;
                    buttonDisconnect.Visible = false;
                    notifyIcon.Text = "Carousel - 未连接";
                    notifyIcon.ShowBalloonTip(3000, "Carousel", "已断开连接", ToolTipIcon.Info);
                } catch (Exception ex) {
                    // fail
                    MessageBox.Show("无法断开连接，错误信息：" + ex.Message, "Carousel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonDisconnect.Enabled = true;
                }
            }
        }

        private void saveCredential(string username, string password, bool remember, bool auto) {
            RegistryKey hkcu = Registry.CurrentUser;
            RegistryKey software = hkcu.OpenSubKey("Software", true);
            RegistryKey carousel = software.CreateSubKey("Carousel");
            carousel.SetValue("username", username, RegistryValueKind.String);
            carousel.SetValue("password", password, RegistryValueKind.String);
            carousel.SetValue("remember", (remember) ? 1 : 0, RegistryValueKind.DWord);
            carousel.SetValue("auto", (auto) ? 1 : 0, RegistryValueKind.DWord);
            carousel.Close();
        }

        private void readCredential() {
            RegistryKey hkcu = Registry.CurrentUser;
            RegistryKey software = hkcu.OpenSubKey("Software", true);
            RegistryKey carousel = software.CreateSubKey("Carousel");
            textUsername.Text = (string)carousel.GetValue("username", "");
            textPassword.Text = (string)carousel.GetValue("password", "");
            checkRemember.Checked = ((int)carousel.GetValue("remember") == 1);
            checkAuto.Checked = ((int)carousel.GetValue("auto") == 1);
            carousel.Close();
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            connect();
        }

        private void buttonDisconnect_Click(object sender, EventArgs e) {
            disconnect();
        }

        private void notifyIcon_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) {
                this.Visible = true;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            willClose = true;
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if (!willClose) {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            new frmAbout().ShowDialog(this);
        }

        private void checkAuto_CheckedChanged(object sender, EventArgs e) {
            if (checkAuto.Checked) {
                checkRemember.Checked = true;
            }
        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e) {
            if (!checkRemember.Checked) {
                checkAuto.Checked = false;
            }
        }

    }
}
