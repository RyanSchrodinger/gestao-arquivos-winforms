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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBotoesListBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.BackColor = System.Drawing.Color.Linen;
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
            this.panelBotoesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(160)))), ((int)(((byte)(153)))));
            this.panelBotoesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoesListBox.Controls.Add(this.btnExcluir);
            this.panelBotoesListBox.Controls.Add(this.btnInserir);
            this.panelBotoesListBox.Controls.Add(this.btnEditar);
            this.panelBotoesListBox.Location = new System.Drawing.Point(106, 476);
            this.panelBotoesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.panelBotoesListBox.Name = "panelBotoesListBox";
            this.panelBotoesListBox.Size = new System.Drawing.Size(855, 67);
            this.panelBotoesListBox.TabIndex = 1;
            this.panelBotoesListBox.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Linen;
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
            this.btnInserir.BackColor = System.Drawing.Color.Linen;
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
            this.btnEditar.BackColor = System.Drawing.Color.Linen;
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
            this.panel2.Location = new System.Drawing.Point(106, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 378);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSalvarComo);
            this.panel3.Controls.Add(this.btnObterDados);
            this.panel3.Location = new System.Drawing.Point(106, 476);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 200);
            this.panel3.TabIndex = 2;
            // 
            // btnSalvarComo
            // 
            this.btnSalvarComo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnSalvarComo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalvarComo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarComo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarComo.Location = new System.Drawing.Point(15, 126);
            this.btnSalvarComo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvarComo.Name = "btnSalvarComo";
            this.btnSalvarComo.Size = new System.Drawing.Size(819, 43);
            this.btnSalvarComo.TabIndex = 6;
            this.btnSalvarComo.Text = "Salvar Como";
            this.btnSalvarComo.UseVisualStyleBackColor = false;
            this.btnSalvarComo.Click += new System.EventHandler(this.btnSalvarComo_Click);
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnObterDados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterDados.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterDados.Location = new System.Drawing.Point(15, 75);
            this.btnObterDados.Margin = new System.Windows.Forms.Padding(4);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(819, 43);
            this.btnObterDados.TabIndex = 5;
            this.btnObterDados.Text = "Extrair";
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 89);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PetLove_Modificacao.Properties.Resources.veterinario__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-21, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(441, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(282, 46);
            this.label.TabIndex = 0;
            this.label.Text = "TELA PRINCIPAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "PetLove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1105, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBotoesListBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelBotoesListBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
    }
}

