using PetLove_Modificacao.Forms;
using PetLove_Modificacao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetLove_Modificacao
{
    public partial class Form1 : Form
    {
        #region Criação dos objetos/variáveis principais 
        // Aqui foram declaradas algumas variáveis que vão receber objetos das classes OpenFileDialog e SaveFileDialog,
        // além de uma variável do tipo string.
        // Esses objetos servem para abrir janelas de dialogo do Windows, podendo selecionar alguns arquivos
        // e definir onde salvar.
        // A variável caminho é utilizada para guardar o caminho do arquivo selecionado.

        private OpenFileDialog leitura = new OpenFileDialog();
        private SaveFileDialog salvamento = new SaveFileDialog();
        private string caminho;
        #endregion

        public Form1()
        {
            InitializeComponent();



        }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            AbrirArquivo();




        }

       
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirPessoaSelecionada();

        }


        #region Método que Abre a Janela de Diálogo e permite escolher o arquivo
        public void AbrirArquivo()
        {
            // Limpa o ListBox, caso já tenha conteúdo
            lboDados.Items.Clear();

            // Filtrando
            leitura.Filter = "|*.txt";

            // Texto que vai ficar na janela de Diálogo 
            leitura.Title = "Selecione o arquivo PetLove";

            if (leitura.ShowDialog() != DialogResult.OK) return;

            caminho = leitura.FileName;

            try
            {
                File.ReadAllText(caminho);

                // Ao inves de usar o ReadAllText, coloquei "Lines" que já retorna cada linha,
                // Não precisando usar split()
                string[] linhas = File.ReadAllLines(caminho);

                for (int i = 0; i < linhas.Length; i = i + 4)
                {
                    string nome = linhas[i];
                    string animal = linhas[i + 1];
                    string raca = linhas[i + 2];
                    int idade = int.Parse(linhas[i + 3]);
                    Animal animalAtual = new Animal(nome, animal, raca, idade);
                    lboDados.Items.Add(animalAtual);

                }
                panelBotoesListBox.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



        #endregion


        #region Método para excluir a pessoa selecionada dentro do ListBox
        public void ExcluirPessoaSelecionada()
        {
            Animal animalSelecionado = lboDados.SelectedItem as Animal;

            if (animalSelecionado == null)
            {
                MessageBox.Show("Selecione um item para excluir");
                return;
            }

            lboDados.Items.Remove(animalSelecionado);
            lboDados.Update();

        }


        #endregion

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            string mensagem = "INSERIR NOVO ANIMAL";
            using (FormCadastro telaCadastro = new FormCadastro(mensagem))
            {


                telaCadastro.ShowDialog();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            Animal animalAntigo = lboDados.SelectedItem as Animal;
            if (animalAntigo == null) 
            {
                MessageBox.Show("Selecione algum campo.");
                return;
            }
            string mensagem = $"Editar Informações do(a) {animalAntigo._nome}";
            using (var telaEditar = new FormCadastro(mensagem, animalAntigo))
            {
                telaEditar.ShowDialog();
            }

        }
    }

}
