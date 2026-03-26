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
            this.btnObterDados = new System.Windows.Forms.Button();
            this.panelBotoesListBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lboDados
            // 
            this.lboDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.lboDados.FormattingEnabled = true;
            this.lboDados.Location = new System.Drawing.Point(0, 0);
            this.lboDados.Name = "lboDados";
            this.lboDados.Size = new System.Drawing.Size(641, 329);
            this.lboDados.TabIndex = 0;
            // 
            // panelBotoesListBox
            // 
            this.panelBotoesListBox.BackColor = System.Drawing.Color.White;
            this.panelBotoesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBotoesListBox.Controls.Add(this.btnExcluir);
            this.panelBotoesListBox.Controls.Add(this.btnInserir);
            this.panelBotoesListBox.Controls.Add(this.btnEditar);
            this.panelBotoesListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotoesListBox.Location = new System.Drawing.Point(0, 329);
            this.panelBotoesListBox.Name = "panelBotoesListBox";
            this.panelBotoesListBox.Size = new System.Drawing.Size(641, 30);
            this.panelBotoesListBox.TabIndex = 1;
            this.panelBotoesListBox.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(0, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(185, 28);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnInserir.FlatAppearance.BorderSize = 0;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(229, -1);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(185, 35);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(454, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 28);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelBotoesListBox);
            this.panel2.Controls.Add(this.lboDados);
            this.panel2.Location = new System.Drawing.Point(26, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 362);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnObterDados);
            this.panel3.Location = new System.Drawing.Point(26, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(640, 95);
            this.panel3.TabIndex = 2;
            // 
            // btnObterDados
            // 
            this.btnObterDados.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnObterDados.FlatAppearance.BorderSize = 0;
            this.btnObterDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObterDados.Location = new System.Drawing.Point(3, 3);
            this.btnObterDados.Name = "btnObterDados";
            this.btnObterDados.Size = new System.Drawing.Size(185, 35);
            this.btnObterDados.TabIndex = 5;
            this.btnObterDados.Text = "Extrair";
            this.btnObterDados.UseVisualStyleBackColor = false;
            this.btnObterDados.Click += new System.EventHandler(this.btnObterDados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 498);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
    }
}

