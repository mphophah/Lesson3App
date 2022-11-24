using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3App
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username, string passwordD)
        {
            InitializeComponent();

            usernamePassTextBox.Text = username + " " + passwordD; //pass to the screen welcome form
        }

    }
}
