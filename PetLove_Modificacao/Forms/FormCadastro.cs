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
        private Animal animalEscolhido;
        public FormCadastro(string mensagem)
        {
            InitializeComponent();
            lblTipoTela.Text = mensagem;
            btnAtualizarCampos.Visible= false;
       
            btnCadastrar.Location = new Point(55, 231);
            

        }

        public FormCadastro(string mensagem, Animal animal)
        {

            this.animalEscolhido = animal;
            InitializeComponent();
            btnCadastrar.Visible = false;

            lblTipoTela.Text = mensagem;

            txtNome.Text = animal._nome;
            txtAnimal.Text = animal._animal;
            txtRaca.Text = animal._raca;
            txtIdade.Text = animal._idade.ToString();


        }
    }
}
