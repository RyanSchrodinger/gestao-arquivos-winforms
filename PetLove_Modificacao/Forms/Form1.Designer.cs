namespace PetLove_Modificacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboDados = new System.Windows.Forms.ListBox();
            this.panelBotoesListBox = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvarComo = new System.Windows.Forms.Button();
            this.btnObterDados = new System.Windows.Forms.Button();
            this.panelBotoesListBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboDados.FormattingEnabled = true;
            this.lboDados.ItemHeight = 25;
            this.lboDados.Location = new System.Drawing.Point(0, 0);
            this.lboDados.Margin = new System.Windows.Forms.Padding(4);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(855, 379);
            this.lboDados.TabIndex = 0;
            // 
            // panelBotoesListBox
            // 
            this.panelBotoesListBox.BackColor = System.Drawing.Color.White;
            this.panelBotoesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoesListBox.Controls.Add(this.btnExcluir);
            this.panelBotoesListBox.Controls.Add(this.btnInserir);
            this.panelBotoesListBox.Controls.Add(this.btnEditar);
            this.panelBotoesListBox.Location = new System.Drawing.Point(35, 406);
            this.panelBotoesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotoesListBox.Name = "panelBotoesListBox";
            this.panelBotoesListBox.Size = new System.Drawing.Size(855, 67);
            this.panelBotoesListBox.TabIndex = 1;
            this.panelBotoesListBox.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(14, 8);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(247, 43);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(302, 8);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(247, 43);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir Novo Dado";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(586, 8);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(247, 42);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lboDados);
            this.panel2.Location = new System.Drawing.Point(35, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 378);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSalvarComo);
            this.panel3.Controls.Add(this.btnObterDados);
            this.panel3.Location = new System.Drawing.Point(35, 406);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 200);
            this.panel3.TabIndex = 2;
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSalvarComo.FlatAppearance.BorderSize = 0;
            this.btnSalvarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarComo.Location = new System.Drawing.Point(15, 126);
            this.btnSalvarComo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(819, 43);
            this.btnSalvarComo.TabIndex = 6;
            this.btnSalvarComo.Text = "Salvar Como";
            this.btnSalvarComo.UseVisualStyleBackColor = false;
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnObterDados.FlatAppearance.BorderSize = 0;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterDados.Location = new System.Drawing.Point(15, 75);
            this.btnObterDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(819, 43);
            this.btnObterDados.TabIndex = 5;
            this.btnObterDados.Text = "Extrair";
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1105, 613);
            this.Controls.Add(this.panelBotoesListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBotoesListBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboDados;
        private System.Windows.Forms.Panel panelBotoesListBox;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnObterDados;
        private System.Windows.Forms.Button btnSalvarComo;
    }
}

