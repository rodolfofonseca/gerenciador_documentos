using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciador_documentos.forms
{
    public partial class Splash_form : Form
    {
        public Splash_form()
        {
            InitializeComponent();
        }

        private void Splash_form_Load(object sender, EventArgs e)
        {

        }

        private void Splash_form_Shown(object sender, EventArgs e)
        {
            label1.Text = "Iniciando o sistema...";
            this.Refresh();

            for(int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(40);
            }

            progressBar1.Value = 99;

            Thread.Sleep(500);

            //Login_form login_Form = new Login_form();
            //login_Form.Show();
            this.Close();

        }
    }
}
