using PetLove_Modificacao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetLove_Modificacao.Forms
{
    public partial class FormCadastro : Form
    {
        private Animal _animal;
        public FormCadastro(string mensagem)
        {
            InitializeComponent();
            lblTipoTela.Text = mensagem;
            btnAtualizarCampos.Visible= false;
       
            btnCadastrar.Location = new Point(14, 220);
         
         
            

        }

        public FormCadastro(string mensagem, Animal animal)
        {

            this._animal = animal;
            InitializeComponent();
            btnCadastrar.Visible = false;

            lblTipoTela.Text = mensagem;

            txtNome.Text = animal._nome;
            txtAnimal.Text = animal._animal;
            txtRaca.Text = animal._raca;
            txtIdade.Text = animal._idade.ToString();


        }

        public Animal Animal => _animal;

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }
        #region Funções De Limpar Campo, Atualizar e Inserir 
        public void LimparCampos() 
        {
            txtAnimal.Text = "";
            txtIdade.Text = "";
            txtNome.Text = "";
            txtRaca.Text = "";
        }


        public void Atualizar()
        {
            string nome = txtNome.Text;
            string raca = txtRaca.Text;
            string animal = txtAnimal.Text;

            bool idadeValida = int.TryParse(txtIdade.Text, out int idade);


            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(raca)||
                string.IsNullOrEmpty(animal)||
                !idadeValida)
            {
                MessageBox.Show("É necessário preecher todos os campos");
                return;
            }

            _animal.Atualizar(nome,animal,raca,idade);
            Close();



            

        }

        public void Inserir()
        {
            string nome = txtNome.Text;
            string raca = txtRaca.Text;
            string animal = txtAnimal.Text;
            bool idadeValida = int.TryParse(txtIdade.Text, out int idade);

            if (string.IsNullOrEmpty(nome) ||
                string.IsNullOrEmpty(raca) ||
                string.IsNullOrEmpty(animal) ||
                !idadeValida)
            {
                MessageBox.Show("É necessário preecher todos os campos");
                return;
            }

            // Como somente no segundo construtuor o _animal recebe algum valor, nesse caso aqui tem q estar cvazio  
            if(_animal == null)
            {
                _animal = new Animal(nome, animal, raca, idade);
            }
            Close();





        }

        #endregion

        private void btnAtualizarCampos_Click(object sender, EventArgs e)
        {
            
            Atualizar();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Inserir();

        }
    }
}
