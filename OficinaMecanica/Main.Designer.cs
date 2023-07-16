
namespace OficinaMecanica
{
    partial class Main
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
            this.botaoFuncionarios = new System.Windows.Forms.Button();
            this.botaoClientes = new System.Windows.Forms.Button();
            this.botaoViaturas = new System.Windows.Forms.Button();
            this.botaoTrabalhos = new System.Windows.Forms.Button();
            this.botaoFaturacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoFuncionarios
            // 
            this.botaoFuncionarios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoFuncionarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFuncionarios.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoFuncionarios.Location = new System.Drawing.Point(297, 142);
            this.botaoFuncionarios.Name = "botaoFuncionarios";
            this.botaoFuncionarios.Size = new System.Drawing.Size(165, 38);
            this.botaoFuncionarios.TabIndex = 0;
            this.botaoFuncionarios.Text = "Funcionários";
            this.botaoFuncionarios.UseVisualStyleBackColor = false;
            this.botaoFuncionarios.Click += new System.EventHandler(this.botaoFuncionarios_Click);
            // 
            // botaoClientes
            // 
            this.botaoClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoClientes.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoClientes.Location = new System.Drawing.Point(297, 198);
            this.botaoClientes.Name = "botaoClientes";
            this.botaoClientes.Size = new System.Drawing.Size(165, 38);
            this.botaoClientes.TabIndex = 2;
            this.botaoClientes.Text = "Clientes";
            this.botaoClientes.UseVisualStyleBackColor = false;
            this.botaoClientes.Click += new System.EventHandler(this.botaoClientes_Click);
            // 
            // botaoViaturas
            // 
            this.botaoViaturas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoViaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoViaturas.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoViaturas.Location = new System.Drawing.Point(297, 256);
            this.botaoViaturas.Name = "botaoViaturas";
            this.botaoViaturas.Size = new System.Drawing.Size(165, 38);
            this.botaoViaturas.TabIndex = 3;
            this.botaoViaturas.Text = "Viaturas";
            this.botaoViaturas.UseVisualStyleBackColor = false;
            this.botaoViaturas.Click += new System.EventHandler(this.botaoViaturas_Click);
            // 
            // botaoTrabalhos
            // 
            this.botaoTrabalhos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoTrabalhos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTrabalhos.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoTrabalhos.Location = new System.Drawing.Point(297, 313);
            this.botaoTrabalhos.Name = "botaoTrabalhos";
            this.botaoTrabalhos.Size = new System.Drawing.Size(165, 38);
            this.botaoTrabalhos.TabIndex = 4;
            this.botaoTrabalhos.Text = "Trabalhos";
            this.botaoTrabalhos.UseVisualStyleBackColor = false;
            this.botaoTrabalhos.Click += new System.EventHandler(this.botaoTrabalhos_Click);
            // 
            // botaoFaturacao
            // 
            this.botaoFaturacao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoFaturacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFaturacao.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoFaturacao.Location = new System.Drawing.Point(297, 370);
            this.botaoFaturacao.Name = "botaoFaturacao";
            this.botaoFaturacao.Size = new System.Drawing.Size(165, 38);
            this.botaoFaturacao.TabIndex = 5;
            this.botaoFaturacao.Text = "Faturação";
            this.botaoFaturacao.UseVisualStyleBackColor = false;
            this.botaoFaturacao.Click += new System.EventHandler(this.botaoFaturacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(238, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Oficina Mecânica";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoFaturacao);
            this.Controls.Add(this.botaoTrabalhos);
            this.Controls.Add(this.botaoViaturas);
            this.Controls.Add(this.botaoClientes);
            this.Controls.Add(this.botaoFuncionarios);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoFuncionarios;
        private System.Windows.Forms.Button botaoClientes;
        private System.Windows.Forms.Button botaoViaturas;
        private System.Windows.Forms.Button botaoTrabalhos;
        private System.Windows.Forms.Button botaoFaturacao;
        private System.Windows.Forms.Label label1;
    }
}

