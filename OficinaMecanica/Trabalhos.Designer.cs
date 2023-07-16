
namespace OficinaMecanica
{
    partial class Trabalhos
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
            this.botaoVoltarTrabalhos = new System.Windows.Forms.Button();
            this.botaoCriaTrabalho = new System.Windows.Forms.Button();
            this.listaServicos = new System.Windows.Forms.ListView();
            this.trabalhoID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataTrabalho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clienteTrabalho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viaturaTrabalho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servicosPrestados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoVoltarTrabalhos
            // 
            this.botaoVoltarTrabalhos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoVoltarTrabalhos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarTrabalhos.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoVoltarTrabalhos.Location = new System.Drawing.Point(692, 388);
            this.botaoVoltarTrabalhos.Name = "botaoVoltarTrabalhos";
            this.botaoVoltarTrabalhos.Size = new System.Drawing.Size(154, 35);
            this.botaoVoltarTrabalhos.TabIndex = 11;
            this.botaoVoltarTrabalhos.Text = "Voltar";
            this.botaoVoltarTrabalhos.UseVisualStyleBackColor = false;
            this.botaoVoltarTrabalhos.Click += new System.EventHandler(this.botaoVoltarTrabalhos_Click);
            // 
            // botaoCriaTrabalho
            // 
            this.botaoCriaTrabalho.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCriaTrabalho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriaTrabalho.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoCriaTrabalho.Location = new System.Drawing.Point(518, 388);
            this.botaoCriaTrabalho.Name = "botaoCriaTrabalho";
            this.botaoCriaTrabalho.Size = new System.Drawing.Size(168, 35);
            this.botaoCriaTrabalho.TabIndex = 10;
            this.botaoCriaTrabalho.Text = "Adicionar Trabalho";
            this.botaoCriaTrabalho.UseVisualStyleBackColor = false;
            this.botaoCriaTrabalho.Click += new System.EventHandler(this.botaoCriaTrabalho_Click);
            // 
            // listaServicos
            // 
            this.listaServicos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listaServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trabalhoID,
            this.dataTrabalho,
            this.clienteTrabalho,
            this.viaturaTrabalho,
            this.servicosPrestados});
            this.listaServicos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaServicos.ForeColor = System.Drawing.SystemColors.Menu;
            this.listaServicos.FullRowSelect = true;
            this.listaServicos.GridLines = true;
            this.listaServicos.HideSelection = false;
            this.listaServicos.Location = new System.Drawing.Point(23, 93);
            this.listaServicos.MultiSelect = false;
            this.listaServicos.Name = "listaServicos";
            this.listaServicos.Size = new System.Drawing.Size(823, 278);
            this.listaServicos.TabIndex = 9;
            this.listaServicos.UseCompatibleStateImageBehavior = false;
            this.listaServicos.View = System.Windows.Forms.View.Details;
            // 
            // trabalhoID
            // 
            this.trabalhoID.Text = "TrabalhoID";
            this.trabalhoID.Width = 98;
            // 
            // dataTrabalho
            // 
            this.dataTrabalho.Text = "Data";
            this.dataTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataTrabalho.Width = 87;
            // 
            // clienteTrabalho
            // 
            this.clienteTrabalho.Text = "Cliente";
            this.clienteTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clienteTrabalho.Width = 180;
            // 
            // viaturaTrabalho
            // 
            this.viaturaTrabalho.Text = "Viatura";
            this.viaturaTrabalho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viaturaTrabalho.Width = 180;
            // 
            // servicosPrestados
            // 
            this.servicosPrestados.Text = "Serviços Prestados";
            this.servicosPrestados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.servicosPrestados.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trabalhos";
            // 
            // Trabalhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoVoltarTrabalhos);
            this.Controls.Add(this.botaoCriaTrabalho);
            this.Controls.Add(this.listaServicos);
            this.Name = "Trabalhos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltarTrabalhos;
        private System.Windows.Forms.Button botaoCriaTrabalho;
        private System.Windows.Forms.ListView listaServicos;
        private System.Windows.Forms.ColumnHeader trabalhoID;
        private System.Windows.Forms.ColumnHeader dataTrabalho;
        private System.Windows.Forms.ColumnHeader clienteTrabalho;
        private System.Windows.Forms.ColumnHeader viaturaTrabalho;
        private System.Windows.Forms.ColumnHeader servicosPrestados;
        private System.Windows.Forms.Label label1;
    }
}