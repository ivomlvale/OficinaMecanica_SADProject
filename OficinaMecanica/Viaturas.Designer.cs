
namespace OficinaMecanica
{
    partial class Viaturas
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
            this.botaoVoltarViaturas = new System.Windows.Forms.Button();
            this.botaoCriaViatura = new System.Windows.Forms.Button();
            this.viaturaID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.marcaViatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modeloViatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matriculaViatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.anoViatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeClienteViatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaViaturas = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoRemoverViatura = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.idViatura = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoVoltarViaturas
            // 
            this.botaoVoltarViaturas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoVoltarViaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarViaturas.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoVoltarViaturas.Location = new System.Drawing.Point(702, 453);
            this.botaoVoltarViaturas.Name = "botaoVoltarViaturas";
            this.botaoVoltarViaturas.Size = new System.Drawing.Size(154, 35);
            this.botaoVoltarViaturas.TabIndex = 7;
            this.botaoVoltarViaturas.Text = "Voltar";
            this.botaoVoltarViaturas.UseVisualStyleBackColor = false;
            this.botaoVoltarViaturas.Click += new System.EventHandler(this.botaoVoltarViaturas_Click);
            // 
            // botaoCriaViatura
            // 
            this.botaoCriaViatura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCriaViatura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriaViatura.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoCriaViatura.Location = new System.Drawing.Point(702, 371);
            this.botaoCriaViatura.Name = "botaoCriaViatura";
            this.botaoCriaViatura.Size = new System.Drawing.Size(154, 35);
            this.botaoCriaViatura.TabIndex = 6;
            this.botaoCriaViatura.Text = "Adicionar Viatura";
            this.botaoCriaViatura.UseVisualStyleBackColor = false;
            this.botaoCriaViatura.Click += new System.EventHandler(this.botaoAdicionarViatura_Click);
            // 
            // viaturaID
            // 
            this.viaturaID.Text = "ViaturaID";
            this.viaturaID.Width = 87;
            // 
            // marcaViatura
            // 
            this.marcaViatura.Text = "Marca";
            this.marcaViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.marcaViatura.Width = 150;
            // 
            // modeloViatura
            // 
            this.modeloViatura.Text = "Modelo";
            this.modeloViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modeloViatura.Width = 150;
            // 
            // matriculaViatura
            // 
            this.matriculaViatura.Text = "Matricula";
            this.matriculaViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matriculaViatura.Width = 122;
            // 
            // anoViatura
            // 
            this.anoViatura.Text = "Ano";
            this.anoViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.anoViatura.Width = 80;
            // 
            // nomeClienteViatura
            // 
            this.nomeClienteViatura.Text = "Cliente";
            this.nomeClienteViatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeClienteViatura.Width = 230;
            // 
            // listaViaturas
            // 
            this.listaViaturas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listaViaturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.viaturaID,
            this.marcaViatura,
            this.modeloViatura,
            this.matriculaViatura,
            this.anoViatura,
            this.nomeClienteViatura});
            this.listaViaturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaViaturas.ForeColor = System.Drawing.SystemColors.Menu;
            this.listaViaturas.FullRowSelect = true;
            this.listaViaturas.GridLines = true;
            this.listaViaturas.HideSelection = false;
            this.listaViaturas.Location = new System.Drawing.Point(33, 87);
            this.listaViaturas.MultiSelect = false;
            this.listaViaturas.Name = "listaViaturas";
            this.listaViaturas.Size = new System.Drawing.Size(823, 278);
            this.listaViaturas.TabIndex = 5;
            this.listaViaturas.UseCompatibleStateImageBehavior = false;
            this.listaViaturas.View = System.Windows.Forms.View.Details;
            this.listaViaturas.SelectedIndexChanged += new System.EventHandler(this.listaViaturas_SelectedIndexChanged);
            this.listaViaturas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listaViaturas_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Viaturas";
            // 
            // botaoRemoverViatura
            // 
            this.botaoRemoverViatura.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoRemoverViatura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemoverViatura.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoRemoverViatura.Location = new System.Drawing.Point(702, 412);
            this.botaoRemoverViatura.Name = "botaoRemoverViatura";
            this.botaoRemoverViatura.Size = new System.Drawing.Size(154, 35);
            this.botaoRemoverViatura.TabIndex = 9;
            this.botaoRemoverViatura.Text = "Remover Viatura";
            this.botaoRemoverViatura.UseVisualStyleBackColor = false;
            this.botaoRemoverViatura.Click += new System.EventHandler(this.botaoRemoverViatura_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(544, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Viatura:";
            // 
            // idViatura
            // 
            this.idViatura.AutoSize = true;
            this.idViatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idViatura.Location = new System.Drawing.Point(655, 38);
            this.idViatura.Name = "idViatura";
            this.idViatura.Size = new System.Drawing.Size(0, 29);
            this.idViatura.TabIndex = 11;
            // 
            // Viaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 498);
            this.Controls.Add(this.idViatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoRemoverViatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoVoltarViaturas);
            this.Controls.Add(this.botaoCriaViatura);
            this.Controls.Add(this.listaViaturas);
            this.Name = "Viaturas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Viaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltarViaturas;
        private System.Windows.Forms.Button botaoCriaViatura;
        private System.Windows.Forms.ColumnHeader viaturaID;
        private System.Windows.Forms.ColumnHeader marcaViatura;
        private System.Windows.Forms.ColumnHeader modeloViatura;
        private System.Windows.Forms.ColumnHeader matriculaViatura;
        private System.Windows.Forms.ColumnHeader anoViatura;
        private System.Windows.Forms.ColumnHeader nomeClienteViatura;
        private System.Windows.Forms.ListView listaViaturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoRemoverViatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label idViatura;
    }
}