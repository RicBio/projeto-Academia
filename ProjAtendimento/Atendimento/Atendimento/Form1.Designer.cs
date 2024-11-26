namespace Atendimento
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
            this.btnGerarSenha = new System.Windows.Forms.Button();
            this.btnAdicionarGuiche = new System.Windows.Forms.Button();
            this.btnChamarSenha = new System.Windows.Forms.Button();
            this.listBoxFilaSenhas = new System.Windows.Forms.ListBox();
            this.listBoxGuiches = new System.Windows.Forms.ListBox();
            this.listBoxAtendimentos = new System.Windows.Forms.ListBox();
            this.lblGuiche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGerarSenha
            // 
            this.btnGerarSenha.Location = new System.Drawing.Point(77, 48);
            this.btnGerarSenha.Name = "btnGerarSenha";
            this.btnGerarSenha.Size = new System.Drawing.Size(75, 23);
            this.btnGerarSenha.TabIndex = 0;
            this.btnGerarSenha.Text = "Gerar";
            this.btnGerarSenha.UseVisualStyleBackColor = true;
            this.btnGerarSenha.Click += new System.EventHandler(this.btnGerarSenha_Click);
            // 
            // btnAdicionarGuiche
            // 
            this.btnAdicionarGuiche.Location = new System.Drawing.Point(214, 174);
            this.btnAdicionarGuiche.Name = "btnAdicionarGuiche";
            this.btnAdicionarGuiche.Size = new System.Drawing.Size(109, 23);
            this.btnAdicionarGuiche.TabIndex = 1;
            this.btnAdicionarGuiche.Text = "Adicionar Guichê";
            this.btnAdicionarGuiche.UseVisualStyleBackColor = true;
            this.btnAdicionarGuiche.Click += new System.EventHandler(this.btnAdicionarGuiche_Click);
            // 
            // btnChamarSenha
            // 
            this.btnChamarSenha.Location = new System.Drawing.Point(554, 68);
            this.btnChamarSenha.Name = "btnChamarSenha";
            this.btnChamarSenha.Size = new System.Drawing.Size(120, 23);
            this.btnChamarSenha.TabIndex = 2;
            this.btnChamarSenha.Text = "Chamar Senha";
            this.btnChamarSenha.UseVisualStyleBackColor = true;
            this.btnChamarSenha.Click += new System.EventHandler(this.btnChamarSenha_Click);
            // 
            // listBoxFilaSenhas
            // 
            this.listBoxFilaSenhas.FormattingEnabled = true;
            this.listBoxFilaSenhas.Location = new System.Drawing.Point(56, 102);
            this.listBoxFilaSenhas.Name = "listBoxFilaSenhas";
            this.listBoxFilaSenhas.Size = new System.Drawing.Size(120, 95);
            this.listBoxFilaSenhas.TabIndex = 3;
            // 
            // listBoxGuiches
            // 
            this.listBoxGuiches.FormattingEnabled = true;
            this.listBoxGuiches.Location = new System.Drawing.Point(436, 48);
            this.listBoxGuiches.Name = "listBoxGuiches";
            this.listBoxGuiches.Size = new System.Drawing.Size(80, 43);
            this.listBoxGuiches.TabIndex = 4;
            // 
            // listBoxAtendimentos
            // 
            this.listBoxAtendimentos.FormattingEnabled = true;
            this.listBoxAtendimentos.Location = new System.Drawing.Point(373, 102);
            this.listBoxAtendimentos.Name = "listBoxAtendimentos";
            this.listBoxAtendimentos.Size = new System.Drawing.Size(301, 95);
            this.listBoxAtendimentos.TabIndex = 5;
            // 
            // lblGuiche
            // 
            this.lblGuiche.AutoSize = true;
            this.lblGuiche.Location = new System.Drawing.Point(386, 58);
            this.lblGuiche.Name = "lblGuiche";
            this.lblGuiche.Size = new System.Drawing.Size(44, 13);
            this.lblGuiche.TabIndex = 6;
            this.lblGuiche.Text = "Guichê:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 283);
            this.Controls.Add(this.lblGuiche);
            this.Controls.Add(this.listBoxAtendimentos);
            this.Controls.Add(this.listBoxGuiches);
            this.Controls.Add(this.listBoxFilaSenhas);
            this.Controls.Add(this.btnChamarSenha);
            this.Controls.Add(this.btnAdicionarGuiche);
            this.Controls.Add(this.btnGerarSenha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarSenha;
        private System.Windows.Forms.Button btnAdicionarGuiche;
        private System.Windows.Forms.Button btnChamarSenha;
        private System.Windows.Forms.ListBox listBoxFilaSenhas;
        private System.Windows.Forms.ListBox listBoxGuiches;
        private System.Windows.Forms.ListBox listBoxAtendimentos;
        private System.Windows.Forms.Label lblGuiche;
    }
}

