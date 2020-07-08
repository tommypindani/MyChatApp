using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using ChatApp;

namespace MyChatApp
{
    public partial class mainchat : Form
    {
        public mainchat()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.BlueGrey900, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void mainchat_Load(object sender, EventArgs e)
        {

        }

        private void MyChatApp_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n[Server] 1 on 1 Joined!";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text +="\n[Server] Roblox chat Joined!";
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n[Server] Exploiting chat Joined!";
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n[Server] YouTube chat Joined!";
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n[Server] Gaming chat Joined!";
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n[Server] Chat Room Joined!";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
    }
}
