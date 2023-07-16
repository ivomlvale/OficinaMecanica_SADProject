
namespace OficinaMecanica
{
    partial class Clientes
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
            this.listaClientes = new System.Windows.Forms.ListView();
            this.nifCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moradaCiente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataNascimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idadeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.botaoCriaCliente = new System.Windows.Forms.Button();
            this.botaoVoltarClientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoAtualizarCliente = new System.Windows.Forms.Button();
            this.botaoApagarCliente = new System.Windows.Forms.Button();
            this.idTabela = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaClientes
            // 
            this.listaClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listaClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nifCliente,
            this.nomeCliente,
            this.moradaCiente,
            this.contactoCliente,
            this.emailCliente,
            this.dataNascimento,
            this.idadeCliente});
            this.listaClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaClientes.ForeColor = System.Drawing.SystemColors.Menu;
            this.listaClientes.FullRowSelect = true;
            this.listaClientes.GridLines = true;
            this.listaClientes.HideSelection = false;
            this.listaClientes.Location = new System.Drawing.Point(31, 63);
            this.listaClientes.MultiSelect = false;
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(818, 274);
            this.listaClientes.TabIndex = 2;
            this.listaClientes.UseCompatibleStateImageBehavior = false;
            this.listaClientes.View = System.Windows.Forms.View.Details;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listaClientes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listaClientes_MouseClick);
            // 
            // nifCliente
            // 
            this.nifCliente.Text = "NIF";
            this.nifCliente.Width = 100;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Text = "Nome";
            this.nomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nomeCliente.Width = 158;
            // 
            // moradaCiente
            // 
            this.moradaCiente.Text = "Morada";
            this.moradaCiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moradaCiente.Width = 148;
            // 
            // contactoCliente
            // 
            this.contactoCliente.Text = "Contacto";
            this.contactoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contactoCliente.Width = 116;
            // 
            // emailCliente
            // 
            this.emailCliente.Text = "Email";
            this.emailCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailCliente.Width = 81;
            // 
            // dataNascimento
            // 
            this.dataNascimento.Text = "Data Nascimento";
            this.dataNascimento.Width = 151;
            // 
            // idadeCliente
            // 
            this.idadeCliente.Text = "Idade";
            // 
            // botaoCriaCliente
            // 
            this.botaoCriaCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoCriaCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCriaCliente.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoCriaCliente.Location = new System.Drawing.Point(695, 343);
            this.botaoCriaCliente.Name = "botaoCriaCliente";
            this.botaoCriaCliente.Size = new System.Drawing.Size(154, 35);
            this.botaoCriaCliente.TabIndex = 3;
            this.botaoCriaCliente.Text = "Adicionar Cliente";
            this.botaoCriaCliente.UseVisualStyleBackColor = false;
            this.botaoCriaCliente.Click += new System.EventHandler(this.botaoAdicionarCliente_Click);
            // 
            // botaoVoltarClientes
            // 
            this.botaoVoltarClientes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoVoltarClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltarClientes.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoVoltarClientes.Location = new System.Drawing.Point(695, 466);
            this.botaoVoltarClientes.Name = "botaoVoltarClientes";
            this.botaoVoltarClientes.Size = new System.Drawing.Size(154, 35);
            this.botaoVoltarClientes.TabIndex = 4;
            this.botaoVoltarClientes.Text = "Voltar";
            this.botaoVoltarClientes.UseVisualStyleBackColor = false;
            this.botaoVoltarClientes.Click += new System.EventHandler(this.botaoVoltarClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(31, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(554, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botaoAtualizarCliente
            // 
            this.botaoAtualizarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoAtualizarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizarCliente.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoAtualizarCliente.Location = new System.Drawing.Point(695, 384);
            this.botaoAtualizarCliente.Name = "botaoAtualizarCliente";
            this.botaoAtualizarCliente.Size = new System.Drawing.Size(154, 35);
            this.botaoAtualizarCliente.TabIndex = 11;
            this.botaoAtualizarCliente.Text = "Atualizar Cliente";
            this.botaoAtualizarCliente.UseVisualStyleBackColor = false;
            this.botaoAtualizarCliente.Click += new System.EventHandler(this.botaoAtualizarCliente_Click);
            // 
            // botaoApagarCliente
            // 
            this.botaoApagarCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.botaoApagarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoApagarCliente.ForeColor = System.Drawing.SystemColors.Menu;
            this.botaoApagarCliente.Location = new System.Drawing.Point(695, 425);
            this.botaoApagarCliente.Name = "botaoApagarCliente";
            this.botaoApagarCliente.Size = new System.Drawing.Size(154, 35);
            this.botaoApagarCliente.TabIndex = 12;
            this.botaoApagarCliente.Text = "Apagar Cliente";
            this.botaoApagarCliente.UseVisualStyleBackColor = false;
            this.botaoApagarCliente.Click += new System.EventHandler(this.botaoApagarCliente_Click);
            // 
            // idTabela
            // 
            this.idTabela.AutoSize = true;
            this.idTabela.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTabela.Location = new System.Drawing.Point(671, 26);
            this.idTabela.Name = "idTabela";
            this.idTabela.Size = new System.Drawing.Size(0, 30);
            this.idTabela.TabIndex = 13;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 509);
            this.Controls.Add(this.idTabela);
            this.Controls.Add(this.botaoApagarCliente);
            this.Controls.Add(this.botaoAtualizarCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoVoltarClientes);
            this.Controls.Add(this.botaoCriaCliente);
            this.Controls.Add(this.listaClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Clientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listaClientes;
        private System.Windows.Forms.ColumnHeader nifCliente;
        private System.Windows.Forms.ColumnHeader nomeCliente;
        private System.Windows.Forms.ColumnHeader moradaCiente;
        private System.Windows.Forms.ColumnHeader contactoCliente;
        private System.Windows.Forms.ColumnHeader emailCliente;
        private System.Windows.Forms.Button botaoCriaCliente;
        private System.Windows.Forms.Button botaoVoltarClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader dataNascimento;
        private System.Windows.Forms.ColumnHeader idadeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoAtualizarCliente;
        private System.Windows.Forms.Button botaoApagarCliente;
        private System.Windows.Forms.Label idTabela;
    }
}