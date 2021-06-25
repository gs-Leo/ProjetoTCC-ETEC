namespace TCC_vFinal
{
    partial class fChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fChamados));
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnBusquecod = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.mtxtboxDataHora = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbxSetores = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.rtxtbixObservacoes = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUrgencia = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAviso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtStatus.Location = new System.Drawing.Point(498, 164);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(86, 23);
            this.txtStatus.TabIndex = 102;
            // 
            // btnBusquecod
            // 
            this.btnBusquecod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnBusquecod.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusquecod.FlatAppearance.BorderSize = 0;
            this.btnBusquecod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBusquecod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnBusquecod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquecod.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnBusquecod.ForeColor = System.Drawing.Color.White;
            this.btnBusquecod.Location = new System.Drawing.Point(421, -1);
            this.btnBusquecod.Name = "btnBusquecod";
            this.btnBusquecod.Size = new System.Drawing.Size(132, 30);
            this.btnBusquecod.TabIndex = 101;
            this.btnBusquecod.Text = "Consultar protocolo";
            this.btnBusquecod.UseVisualStyleBackColor = false;
            this.btnBusquecod.Click += new System.EventHandler(this.btnBusquecod_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label12.Location = new System.Drawing.Point(39, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 100;
            this.label12.Text = "Data e Hora";
            // 
            // mtxtboxDataHora
            // 
            this.mtxtboxDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtboxDataHora.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.mtxtboxDataHora.Location = new System.Drawing.Point(147, 212);
            this.mtxtboxDataHora.Mask = " 00/00/0000 90:00";
            this.mtxtboxDataHora.Name = "mtxtboxDataHora";
            this.mtxtboxDataHora.Size = new System.Drawing.Size(119, 23);
            this.mtxtboxDataHora.TabIndex = 99;
            this.mtxtboxDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtBoxTelefone
            // 
            this.mTxtBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBoxTelefone.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.mTxtBoxTelefone.Location = new System.Drawing.Point(498, 210);
            this.mTxtBoxTelefone.Mask = " (99) 0000-0000";
            this.mTxtBoxTelefone.Name = "mTxtBoxTelefone";
            this.mTxtBoxTelefone.Size = new System.Drawing.Size(109, 23);
            this.mTxtBoxTelefone.TabIndex = 98;
            // 
            // cbxSetores
            // 
            this.cbxSetores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSetores.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cbxSetores.FormattingEnabled = true;
            this.cbxSetores.Items.AddRange(new object[] {
            " Administrativo",
            " Financeiro",
            " Recursos Humanos",
            " Comercial",
            " Operacional"});
            this.cbxSetores.Location = new System.Drawing.Point(498, 113);
            this.cbxSetores.Name = "cbxSetores";
            this.cbxSetores.Size = new System.Drawing.Size(119, 23);
            this.cbxSetores.TabIndex = 97;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(1, 33);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 30);
            this.btnLimpar.TabIndex = 96;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // rtxtbixObservacoes
            // 
            this.rtxtbixObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtbixObservacoes.Enabled = false;
            this.rtxtbixObservacoes.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.rtxtbixObservacoes.Location = new System.Drawing.Point(498, 293);
            this.rtxtbixObservacoes.MaxLength = 100;
            this.rtxtbixObservacoes.Name = "rtxtbixObservacoes";
            this.rtxtbixObservacoes.Size = new System.Drawing.Size(206, 62);
            this.rtxtbixObservacoes.TabIndex = 95;
            this.rtxtbixObservacoes.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label11.Location = new System.Drawing.Point(376, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 15);
            this.label11.TabIndex = 94;
            this.label11.Text = "Descrição Adicional";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(425, 374);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(71, 27);
            this.btnAlterar.TabIndex = 93;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(229, 374);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 29);
            this.btnConsultar.TabIndex = 92;
            this.btnConsultar.Text = "Consultar ";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label10.Location = new System.Drawing.Point(422, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 91;
            this.label10.Text = "Status";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(498, 254);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 23);
            this.txtEmail.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label5.Location = new System.Drawing.Point(422, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 89;
            this.label5.Text = "Email";
            // 
            // cbxUrgencia
            // 
            this.cbxUrgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUrgencia.Enabled = false;
            this.cbxUrgencia.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cbxUrgencia.FormattingEnabled = true;
            this.cbxUrgencia.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbxUrgencia.Location = new System.Drawing.Point(147, 165);
            this.cbxUrgencia.Name = "cbxUrgencia";
            this.cbxUrgencia.Size = new System.Drawing.Size(121, 23);
            this.cbxUrgencia.TabIndex = 88;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "TI - Remoto",
            "TI - Presencial"});
            this.cbxCategoria.Location = new System.Drawing.Point(147, 119);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbxCategoria.TabIndex = 87;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtCodigo.Location = new System.Drawing.Point(269, 38);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 23);
            this.txtCodigo.TabIndex = 86;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label1.Location = new System.Drawing.Point(203, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 85;
            this.label1.Text = "Protocolo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label9.Location = new System.Drawing.Point(419, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 84;
            this.label9.Text = "Telefone";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtTitulo.Location = new System.Drawing.Point(147, 254);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 23);
            this.txtTitulo.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label8.Location = new System.Drawing.Point(39, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 82;
            this.label8.Text = "Título";
            // 
            // richtxtDescricao
            // 
            this.richtxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtDescricao.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.richtxtDescricao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.richtxtDescricao.Location = new System.Drawing.Point(147, 291);
            this.richtxtDescricao.MaxLength = 80;
            this.richtxtDescricao.Name = "richtxtDescricao";
            this.richtxtDescricao.Size = new System.Drawing.Size(219, 64);
            this.richtxtDescricao.TabIndex = 81;
            this.richtxtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label7.Location = new System.Drawing.Point(39, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 80;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label6.Location = new System.Drawing.Point(422, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Setor";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(269, 77);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 23);
            this.txtNome.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label4.Location = new System.Drawing.Point(203, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label3.Location = new System.Drawing.Point(39, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Urgência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label2.Location = new System.Drawing.Point(39, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Categoria";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(545, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(64, 28);
            this.btnHome.TabIndex = 104;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(614, -2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 30);
            this.btnLogout.TabIndex = 105;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAviso
            // 
            this.btnAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnAviso.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAviso.FlatAppearance.BorderSize = 0;
            this.btnAviso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAviso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAviso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAviso.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnAviso.ForeColor = System.Drawing.Color.White;
            this.btnAviso.Location = new System.Drawing.Point(688, -2);
            this.btnAviso.Name = "btnAviso";
            this.btnAviso.Size = new System.Drawing.Size(30, 30);
            this.btnAviso.TabIndex = 106;
            this.btnAviso.Text = "?";
            this.btnAviso.UseVisualStyleBackColor = false;
            this.btnAviso.Click += new System.EventHandler(this.btnAviso_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnAviso);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnBusquecod);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 27);
            this.panel1.TabIndex = 107;
            // 
            // fChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtxtboxDataHora);
            this.Controls.Add(this.mTxtBoxTelefone);
            this.Controls.Add(this.cbxSetores);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.rtxtbixObservacoes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxUrgencia);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richtxtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamento do Chamado";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnBusquecod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtxtboxDataHora;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelefone;
        private System.Windows.Forms.ComboBox cbxSetores;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.RichTextBox rtxtbixObservacoes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxUrgencia;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richtxtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAviso;
        private System.Windows.Forms.Panel panel1;
    }
}