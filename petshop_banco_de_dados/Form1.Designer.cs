
namespace petshop_banco_de_dados
{
    partial class petshop
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
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbCpf = new System.Windows.Forms.TextBox();
            this.tbEspecie = new System.Windows.Forms.TextBox();
            this.tbPet = new System.Windows.Forms.TextBox();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.dgPetshop = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb0 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPetshop)).BeginInit();
            this.SuspendLayout();
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(811, 32);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(31, 13);
            this.lb5.TabIndex = 9;
            this.lb5.Text = "CEP:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(628, 32);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(71, 13);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "Nome do pet:";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(435, 32);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(81, 13);
            this.lb3.TabIndex = 7;
            this.lb3.Text = "Espécie do pet:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(293, 32);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(30, 13);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "CPF:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(94, 32);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(87, 13);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Nome do cliente:";
            // 
            // tbCliente
            // 
            this.tbCliente.Location = new System.Drawing.Point(187, 29);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(100, 20);
            this.tbCliente.TabIndex = 10;
            // 
            // tbCpf
            // 
            this.tbCpf.Location = new System.Drawing.Point(329, 29);
            this.tbCpf.Name = "tbCpf";
            this.tbCpf.Size = new System.Drawing.Size(100, 20);
            this.tbCpf.TabIndex = 11;
            // 
            // tbEspecie
            // 
            this.tbEspecie.Location = new System.Drawing.Point(522, 29);
            this.tbEspecie.Name = "tbEspecie";
            this.tbEspecie.Size = new System.Drawing.Size(100, 20);
            this.tbEspecie.TabIndex = 12;
            // 
            // tbPet
            // 
            this.tbPet.Location = new System.Drawing.Point(705, 29);
            this.tbPet.Name = "tbPet";
            this.tbPet.Size = new System.Drawing.Size(100, 20);
            this.tbPet.TabIndex = 13;
            // 
            // tbCep
            // 
            this.tbCep.Location = new System.Drawing.Point(848, 29);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(100, 20);
            this.tbCep.TabIndex = 14;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(103, 69);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 15;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(194, 69);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 16;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // dgPetshop
            // 
            this.dgPetshop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPetshop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCliente,
            this.colCpf,
            this.colEspecie,
            this.colPet,
            this.colCep});
            this.dgPetshop.Location = new System.Drawing.Point(15, 111);
            this.dgPetshop.Name = "dgPetshop";
            this.dgPetshop.Size = new System.Drawing.Size(933, 408);
            this.dgPetshop.TabIndex = 17;
            this.dgPetshop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPetshop_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Width = 50;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 250;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "CPF";
            this.colCpf.Name = "colCpf";
            this.colCpf.Width = 130;
            // 
            // colEspecie
            // 
            this.colEspecie.HeaderText = "Espécie";
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.Width = 150;
            // 
            // colPet
            // 
            this.colPet.HeaderText = "Pet";
            this.colPet.Name = "colPet";
            this.colPet.Width = 170;
            // 
            // colCep
            // 
            this.colCep.HeaderText = "CEP";
            this.colCep.Name = "colCep";
            this.colCep.Width = 130;
            // 
            // lb0
            // 
            this.lb0.AutoSize = true;
            this.lb0.Location = new System.Drawing.Point(26, 32);
            this.lb0.Name = "lb0";
            this.lb0.Size = new System.Drawing.Size(21, 13);
            this.lb0.TabIndex = 18;
            this.lb0.Text = "ID:";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(53, 29);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(34, 20);
            this.tbId.TabIndex = 19;
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(379, 69);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 20;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(287, 69);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 23);
            this.btnalterar.TabIndex = 21;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btalterar_Click);
            // 
            // petshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 531);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lb0);
            this.Controls.Add(this.dgPetshop);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.tbPet);
            this.Controls.Add(this.tbEspecie);
            this.Controls.Add(this.tbCpf);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "petshop";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPetshop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.TextBox tbCpf;
        private System.Windows.Forms.TextBox tbEspecie;
        private System.Windows.Forms.TextBox tbPet;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridView dgPetshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCep;
        private System.Windows.Forms.Label lb0;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btnalterar;
    }
}

