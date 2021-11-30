using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;



namespace Sistema_Faculdade
{
    public partial class Form1 : Form
    {
        Thread nt;
        private object txtPassword;

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {

        }

        private void Btn_entrar_Click(object sender, EventArgs e)
        {

            if(textBox1.Text=="977844172" && textBox2.Text == "1234")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
               
            }

            else
            {
                MessageBox.Show("RGM, CPF ou Senha invalidos!");
            }

        }

        private void novoForm(object obj)
        {
            Application.Run(new Form2());
        }

        private void Button10_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)

            {
                textBox2.PasswordChar = '\0';
            }

            else
            {
                textBox2.PasswordChar = '•';
                

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

