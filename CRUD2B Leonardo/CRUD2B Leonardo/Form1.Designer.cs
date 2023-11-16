namespace CRUD2B_Leonardo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btmAlterar = new System.Windows.Forms.Button();
            this.btmExcluir = new System.Windows.Forms.Button();
            this.btmSalvar = new System.Windows.Forms.Button();
            this.btmPesquisar = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "*CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "*Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "*Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "*Nome";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Endereço";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bairro";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CEP";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(150, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cidade";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "UF";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Celular";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(13, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(16, 186);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 23);
            this.txtEndereco.TabIndex = 1;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(303, 186);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 23);
            this.txtBairro.TabIndex = 1;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(153, 260);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 23);
            this.txtCidade.TabIndex = 1;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(153, 29);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(100, 23);
            this.mtbCPF.TabIndex = 2;
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(15, 260);
            this.mtbCEP.Mask = "00,000-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(100, 23);
            this.mtbCEP.TabIndex = 2;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCelular.Location = new System.Drawing.Point(441, 260);
            this.mtbCelular.Mask = "(99) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 23);
            this.mtbCelular.TabIndex = 2;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbSexo.Location = new System.Drawing.Point(289, 28);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 3;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBox1.Location = new System.Drawing.Point(303, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // dtNascimento
            // 
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(441, 28);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(200, 23);
            this.dtNascimento.TabIndex = 4;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(15, 306);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(240, 150);
            this.dataGridView.TabIndex = 5;
            // 
            // btmAlterar
            // 
            this.btmAlterar.Location = new System.Drawing.Point(667, 78);
            this.btmAlterar.Name = "btmAlterar";
            this.btmAlterar.Size = new System.Drawing.Size(75, 23);
            this.btmAlterar.TabIndex = 6;
            this.btmAlterar.Text = "Alterar";
            this.btmAlterar.UseVisualStyleBackColor = true;
            // 
            // btmExcluir
            // 
            this.btmExcluir.Location = new System.Drawing.Point(667, 107);
            this.btmExcluir.Name = "btmExcluir";
            this.btmExcluir.Size = new System.Drawing.Size(75, 23);
            this.btmExcluir.TabIndex = 6;
            this.btmExcluir.Text = "Excluir";
            this.btmExcluir.UseVisualStyleBackColor = true;
            // 
            // btmSalvar
            // 
            this.btmSalvar.Location = new System.Drawing.Point(667, 49);
            this.btmSalvar.Name = "btmSalvar";
            this.btmSalvar.Size = new System.Drawing.Size(75, 23);
            this.btmSalvar.TabIndex = 6;
            this.btmSalvar.Text = "Salvar";
            this.btmSalvar.UseVisualStyleBackColor = true;
            // 
            // btmPesquisar
            // 
            this.btmPesquisar.Location = new System.Drawing.Point(667, 136);
            this.btmPesquisar.Name = "btmPesquisar";
            this.btmPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btmPesquisar.TabIndex = 6;
            this.btmPesquisar.Text = "Pesquisar";
            this.btmPesquisar.UseVisualStyleBackColor = true;
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(667, 165);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(75, 23);
            this.btmCancelar.TabIndex = 6;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::CRUD2B_Leonardo.Properties.Resources.douglas_legramante;
            this.ClientSize = new System.Drawing.Size(834, 530);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btmPesquisar);
            this.Controls.Add(this.btmExcluir);
            this.Controls.Add(this.btmSalvar);
            this.Controls.Add(this.btmAlterar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btmAlterar;
        private System.Windows.Forms.Button btmExcluir;
        private System.Windows.Forms.Button btmSalvar;
        private System.Windows.Forms.Button btmPesquisar;
        private System.Windows.Forms.Button btmCancelar;
    }
}

