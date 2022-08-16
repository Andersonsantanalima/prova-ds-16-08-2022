using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Aluno_Enter(object sender, EventArgs e)
        {
            
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();



            aluno.recuperacao = Convert.ToDouble(txtativi.Text);
            aluno.nome = txtNome.Text;
            aluno.datanacimento = txtdn.Text;
            aluno.contato = txtnumero.Text;
            aluno.cpf = txtcpf.Text;
            aluno.Nota1 = Convert.ToDouble(txtn1.Text);
            aluno.Nota2 = Convert.ToDouble(txtn2.Text);
            aluno.Nota3 = Convert.ToDouble(txtn3.Text);

            aluno.calcMedia();
            aluno.calcRecuperacao();

            txtno.Text = aluno.nome;
            txtnac.Text = aluno.datanacimento;
            txtcontato.Text = aluno.contato;
            txtcp.Text = aluno.cpf ;
            txtrecu.Text = Convert.ToString(aluno.recuperacao);
            txtmedia.Text = Convert.ToString(aluno.media);
            txtfinal.Text = Convert.ToString(aluno.Nmedia);
            txtrecu.Text = Convert.ToString (aluno.recuperacao);

        }
    }
}
