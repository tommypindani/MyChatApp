using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Net;
using MyChatApp;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        WebClient login = new WebClient();
        WebClient register = new WebClient();

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.BlueGrey900, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = usernameText.Text;
            string pass = passwordText.Text;

            /* if()
             {
             */
            mainchat mc = new mainchat();
            mc.Show();
            mc.Focus();
            this.Hide();


           // }
        }
    }
}
