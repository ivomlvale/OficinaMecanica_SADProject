
namespace OficinaMecanica
{
    partial class Indisponivel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.botaoVoltarClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORA DE SERVIÇO";
            // 
            // botaoVoltarClientes
            // 
            this.botaoVoltarClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoVoltarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarClientes.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoVoltarClientes.Location = new System.Drawing.Point(311, 264);
            this.botaoVoltarClientes.Name = "botaoVoltarClientes";
            this.botaoVoltarClientes.Size = new System.Drawing.Size(154, 35);
            this.botaoVoltarClientes.TabIndex = 5;
            this.botaoVoltarClientes.Text = "Voltar";
            this.botaoVoltarClientes.UseVisualStyleBackColor = false;
            this.botaoVoltarClientes.Click += new System.EventHandler(this.botaoVoltarClientes_Click);
            // 
            // Indisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoVoltarClientes);
            this.Controls.Add(this.label1);
            this.Name = "Indisponivel";
            this.Text = "Indisponivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoVoltarClientes;
    }
}