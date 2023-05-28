using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApp.dataControl;
using System.IO;
using System.Globalization;

namespace ScheduleApp
{
    public partial class SignIn : Form
    {

        string blankUserInfo;
        string loginFail;
        public SignIn()
        {
            InitializeComponent();
            languageSet(CultureInfo.CurrentCulture);

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                

                if (userNameBox.Text.Length == 0 || passwordBox.Text.Length == 0) 
                { 
                    MessageBox.Show(blankUserInfo);
                    w.WriteLine("Username:" + userNameBox.Text + " Password:" + passwordBox.Text + " Login Failed Time:" + DateTime.Now.ToString("MM/dd/yyy H:mm:ss"));
                }
                else if (DatabaseAccess.login(userNameBox.Text, passwordBox.Text) != null)
                {
                    w.WriteLine("Username:" + userNameBox.Text + " Password:" + passwordBox.Text + " Login Success Time:" + DateTime.Now.ToString("MM/dd/yyy H:mm:ss"));
                    scheduleObject nextApointment = DatabaseAccess.nextApointment(userNameBox.Text);

                    if (nextApointment != null)
                        if (nextApointment.date < DateTime.Now.AddMinutes(15)) {
                            string meetingMessage = "You have a meeting with " + nextApointment.customerName + " at " + nextApointment.date.ToString("h:mm t");
                            MessageBox.Show(meetingMessage);
                        }
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show(loginFail);
                    w.WriteLine("Username:" + userNameBox.Text + " Password:" + passwordBox.Text + " Login Failed Time:" + DateTime.Now.ToString("MM/dd/yyy H:mm:ss"));
                }
                    
            }
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void setEnglish()
        {
            userNameText.Text = "User Name: ";
            userNameText.Left = 85;
            passwordText.Text = "Password: ";
            passwordText.Left = 95;
            languageLabel.Text = "Language:";
            languageLabel.Left = 275;
            languageSelector.SelectedItem = "English";
            signInButton.Text = "Sign In";
            blankUserInfo = "Please enter a Username and Password";
            loginFail = "Username and Password combination invalid";
        }

        private void setSpanish()
        {
            userNameText.Text = "Nombre de usuario: ";
            userNameText.Left = 31;
            passwordText.Text = "Clave: ";
            passwordText.Left = 125;
            languageLabel.Text = "Idioma:";
            languageLabel.Left = 290;
            languageSelector.SelectedItem = "Spanish";
            signInButton.Text = "Iniciar sesión";
            blankUserInfo = "Por favor ingrese un nombre de usuario y contraseña";
            loginFail = "Combinación de nombre de usuario y contraseña no válida";
        }

        private void languageSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (languageSelector.SelectedItem.ToString() == "English")
                setEnglish();
            else if (languageSelector.SelectedItem.ToString() == "Spanish")
                setSpanish();
        }

        private void languageSet(CultureInfo current)
        {
            if (current.TwoLetterISOLanguageName.Equals("es"))
                setSpanish();
            else
                setEnglish();
        }
    }
}
