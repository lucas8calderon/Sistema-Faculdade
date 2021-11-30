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
    public partial class Form2 : Form
    {
        Thread nt;
        Thread nt2;
        Thread nt3;
        Thread nt4;
        Thread nt5;
        Thread nt6;
        Thread nt7;
        Thread nt8;
        Thread nt9;
        Thread nt10;
        Thread nt11;

        Thread nt12;
        Thread nt13;






        private Form frmAtivo;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            nt5 = new Thread(novoForm5);
            nt5.SetApartmentState(ApartmentState.STA);
            nt5.Start();
        }

        private void novoForm5(object obj)
        {
            Application.Run(new RematriculaForm());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            nt5 = new Thread(novoForm10);
            nt5.SetApartmentState(ApartmentState.STA);
            nt5.Start();

        }

        private void novoForm10(object obj)
        {
            Application.Run(new Form1());
        }

        private void button2_Click_1(object sender, EventArgs e)

        {


            nt = new Thread(novoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();



        }

        private void novoForm(object obj)
        {
            Application.Run(new MeuCurso());
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            nt2 = new Thread(novoForm2);
            nt2.SetApartmentState(ApartmentState.STA);
            nt2.Start();



        }

        private void novoForm2(object obj)
        {
            Application.Run(new HomeForm());
        }

        private void btnMinhaConta_Click(object sender, EventArgs e)
        {

            nt3 = new Thread(novoForm3);
            nt3.SetApartmentState(ApartmentState.STA);
            nt3.Start();



        }

        private void novoForm3(object obj)
        {
            Application.Run(new MinhaContaForm());

        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {

            nt4 = new Thread(novoForm4);
            nt4.SetApartmentState(ApartmentState.STA);
            nt4.Start();



        }

        private void novoForm4(object obj)
        {
            Application.Run(new FinanceiroForm());

        }

        private void btnCentral_Click(object sender, EventArgs e)
        {


            nt5 = new Thread(novoForm6);
            nt5.SetApartmentState(ApartmentState.STA);
            nt5.Start();



        }

        private void novoForm6(object obj)
        {
            Application.Run(new CentralForm());

        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            nt7 = new Thread(novoForm7);
            nt7.SetApartmentState(ApartmentState.STA);
            nt7.Start();
        }

        private void novoForm7(object obj)
        {
            Application.Run(new AtividadeForm());

        }

        private void btnAvisos_Click(object sender, EventArgs e)
        {

            nt8 = new Thread(novoForm8);
            nt8.SetApartmentState(ApartmentState.STA);
            nt8.Start();
        }

        private void novoForm8(object obj)
        {
            Application.Run(new AvisosForm());

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {



            nt9 = new Thread(novoForm9);
            nt9.SetApartmentState(ApartmentState.STA);
            nt9.Start();

        }
        private void novoForm9(object obj)
        {
            Application.Run(new AjudaForm());

        }
    }
}




