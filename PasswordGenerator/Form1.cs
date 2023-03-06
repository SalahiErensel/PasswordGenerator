using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
         public void GeneratePassword()
         {
            int passwordLength = int.Parse(txtPasswordLength.Text);
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!?#£$+&{}[]()*-_,";
            Random random = new Random();
            string password = "";

            for(int i = 0; i < passwordLength; i++)
            {
                int randomNum = random.Next(0,characters.Length);
                password+= characters[randomNum];
            }
            lblPassword.Text = password;
         }

        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            lblYourPassword.Visible = false;
            lblPassword.Visible= false;
            btnCopyPassword.Visible = false;
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblPassword.Text);
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int passwordLength;

            if (!String.IsNullOrEmpty(txtPasswordLength.Text) && int.TryParse(txtPasswordLength.Text, out passwordLength))
            {
                GeneratePassword();
                lblYourPassword.Visible = true;
                lblPassword.Visible = true;
                btnCopyPassword.Visible = true;
            }
            else
            {
                MessageBox.Show("Please enter a number for the length of your password!");
                txtPasswordLength.Clear();
            }
        }
    }
}