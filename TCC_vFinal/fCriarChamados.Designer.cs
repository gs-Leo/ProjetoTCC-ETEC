namespace TCC_vFinal
{
    partial class fCriarChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCriarChamados));
            this.label12 = new System.Windows.Forms.Label();
            this.mtxtboxDataHora = new System.Windows.Forms.MaskedTextBox();
            this.cbxSetores = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTxtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnchamado = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richtxtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuário = new System.Windows.Forms.TextBox();
            this.btnConsulChamado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label12.Location = new System.Drawing.Point(41, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 15);
            this.label12.TabIndex = 96;
            this.label12.Text = "Data e Hora";
            // 
            // mtxtboxDataHora
            // 
            this.mtxtboxDataHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtboxDataHora.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.mtxtboxDataHora.Location = new System.Drawing.Point(174, 100);
            this.mtxtboxDataHora.Mask = "00/00/0000 90:00";
            this.mtxtboxDataHora.Name = "mtxtboxDataHora";
            this.mtxtboxDataHora.Size = new System.Drawing.Size(108, 23);
            this.mtxtboxDataHora.TabIndex = 95;
            this.mtxtboxDataHora.TabStop = false;
            this.mtxtboxDataHora.ValidatingType = typeof(System.DateTime);
            // 
            // cbxSetores
            // 
            this.cbxSetores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSetores.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cbxSetores.FormattingEnabled = true;
            this.cbxSetores.Items.AddRange(new object[] {
            "Administrativo",
            "Financeiro",
            "Recursos Humanos",
            "Comercial",
            "Operacional"});
            this.cbxSetores.Location = new System.Drawing.Point(514, 99);
            this.cbxSetores.Name = "cbxSetores";
            this.cbxSetores.Size = new System.Drawing.Size(121, 23);
            this.cbxSetores.TabIndex = 94;
            this.cbxSetores.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtEmail.Location = new System.Drawing.Point(514, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 23);
            this.txtEmail.TabIndex = 91;
            this.txtEmail.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label5.Location = new System.Drawing.Point(435, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 90;
            this.label5.Text = "Email";
            // 
            // mTxtBoxTelefone
            // 
            this.mTxtBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mTxtBoxTelefone.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.mTxtBoxTelefone.Location = new System.Drawing.Point(514, 153);
            this.mTxtBoxTelefone.Mask = "(99) 0000-0000";
            this.mTxtBoxTelefone.Name = "mTxtBoxTelefone";
            this.mTxtBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.mTxtBoxTelefone.TabIndex = 89;
            this.mTxtBoxTelefone.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label9.Location = new System.Drawing.Point(435, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 87;
            this.label9.Text = "Telefone";
            // 
            // btnchamado
            // 
            this.btnchamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnchamado.FlatAppearance.BorderSize = 0;
            this.btnchamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnchamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnchamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchamado.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnchamado.ForeColor = System.Drawing.Color.White;
            this.btnchamado.Location = new System.Drawing.Point(319, 305);
            this.btnchamado.Name = "btnchamado";
            this.btnchamado.Size = new System.Drawing.Size(95, 24);
            this.btnchamado.TabIndex = 86;
            this.btnchamado.TabStop = false;
            this.btnchamado.Text = "Abrir Chamado";
            this.btnchamado.UseVisualStyleBackColor = false;
            this.btnchamado.Click += new System.EventHandler(this.btnchamado_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtTitulo.Location = new System.Drawing.Point(174, 153);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(173, 23);
            this.txtTitulo.TabIndex = 85;
            this.txtTitulo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label8.Location = new System.Drawing.Point(41, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 84;
            this.label8.Text = "Título";
            // 
            // richtxtDescricao
            // 
            this.richtxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtDescricao.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.richtxtDescricao.Location = new System.Drawing.Point(174, 209);
            this.richtxtDescricao.MaxLength = 140;
            this.richtxtDescricao.Name = "richtxtDescricao";
            this.richtxtDescricao.Size = new System.Drawing.Size(219, 65);
            this.richtxtDescricao.TabIndex = 83;
            this.richtxtDescricao.TabStop = false;
            this.richtxtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label7.Location = new System.Drawing.Point(41, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 82;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label6.Location = new System.Drawing.Point(435, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 81;
            this.label6.Text = "Setor";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(174, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(219, 23);
            this.txtNome.TabIndex = 80;
            this.txtNome.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label4.Location = new System.Drawing.Point(41, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.label1.Location = new System.Drawing.Point(435, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 100;
            this.label1.Text = "Login";
            // 
            // txtUsuário
            // 
            this.txtUsuário.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuário.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtUsuário.Location = new System.Drawing.Point(514, 44);
            this.txtUsuário.MaxLength = 11;
            this.txtUsuário.Name = "txtUsuário";
            this.txtUsuário.Size = new System.Drawing.Size(121, 23);
            this.txtUsuário.TabIndex = 101;
            this.txtUsuário.TabStop = false;
            this.txtUsuário.TextChanged += new System.EventHandler(this.txtUsuário_TextChanged);
            // 
            // btnConsulChamado
            // 
            this.btnConsulChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnConsulChamado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsulChamado.FlatAppearance.BorderSize = 0;
            this.btnConsulChamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulChamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnConsulChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulChamado.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnConsulChamado.ForeColor = System.Drawing.Color.White;
            this.btnConsulChamado.Location = new System.Drawing.Point(456, -1);
            this.btnConsulChamado.Name = "btnConsulChamado";
            this.btnConsulChamado.Size = new System.Drawing.Size(125, 30);
            this.btnConsulChamado.TabIndex = 102;
            this.btnConsulChamado.Text = "Consultar chamado";
            this.btnConsulChamado.UseVisualStyleBackColor = false;
            this.btnConsulChamado.Click += new System.EventHandler(this.btnConsulChamado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnConsulChamado);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(-18, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 27);
            this.panel1.TabIndex = 108;
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
            this.btnHome.Location = new System.Drawing.Point(586, 0);
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
            this.btnLogout.Location = new System.Drawing.Point(651, -1);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 30);
            this.btnLogout.TabIndex = 105;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // fCriarChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsuário);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtxtboxDataHora);
            this.Controls.Add(this.cbxSetores);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTxtBoxTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnchamado);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richtxtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fCriarChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criação de Chamados";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtxtboxDataHora;
        private System.Windows.Forms.ComboBox cbxSetores;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTxtBoxTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnchamado;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richtxtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuário;
        private System.Windows.Forms.Button btnConsulChamado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLogout;
    }
}