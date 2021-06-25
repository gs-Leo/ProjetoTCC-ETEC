namespace TCC_vFinal
{
    partial class fRoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRoot));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadGeral = new System.Windows.Forms.Button();
            this.btnCadHp = new System.Windows.Forms.Button();
            this.btnIndexHp = new System.Windows.Forms.Button();
            this.btnIndexGeral = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnCadGeral);
            this.panel1.Controls.Add(this.btnCadHp);
            this.panel1.Controls.Add(this.btnIndexHp);
            this.panel1.Controls.Add(this.btnIndexGeral);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 358);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCadGeral
            // 
            this.btnCadGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCadGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadGeral.FlatAppearance.BorderSize = 0;
            this.btnCadGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCadGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadGeral.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnCadGeral.ForeColor = System.Drawing.Color.White;
            this.btnCadGeral.Location = new System.Drawing.Point(0, 77);
            this.btnCadGeral.Name = "btnCadGeral";
            this.btnCadGeral.Size = new System.Drawing.Size(142, 42);
            this.btnCadGeral.TabIndex = 10;
            this.btnCadGeral.Text = "Cadastro Geral";
            this.btnCadGeral.UseVisualStyleBackColor = false;
            this.btnCadGeral.Click += new System.EventHandler(this.btnCadGeral_Click);
            // 
            // btnCadHp
            // 
            this.btnCadHp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCadHp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadHp.FlatAppearance.BorderSize = 0;
            this.btnCadHp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadHp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnCadHp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadHp.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnCadHp.ForeColor = System.Drawing.Color.White;
            this.btnCadHp.Location = new System.Drawing.Point(0, 119);
            this.btnCadHp.Name = "btnCadHp";
            this.btnCadHp.Size = new System.Drawing.Size(142, 42);
            this.btnCadHp.TabIndex = 11;
            this.btnCadHp.Text = "Todos os Funcionários";
            this.btnCadHp.UseVisualStyleBackColor = false;
            this.btnCadHp.Click += new System.EventHandler(this.btnCadHp_Click);
            // 
            // btnIndexHp
            // 
            this.btnIndexHp.FlatAppearance.BorderSize = 0;
            this.btnIndexHp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIndexHp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnIndexHp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndexHp.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnIndexHp.ForeColor = System.Drawing.Color.White;
            this.btnIndexHp.Location = new System.Drawing.Point(0, 215);
            this.btnIndexHp.Name = "btnIndexHp";
            this.btnIndexHp.Size = new System.Drawing.Size(142, 42);
            this.btnIndexHp.TabIndex = 13;
            this.btnIndexHp.Text = "Área de resposta de chamados";
            this.btnIndexHp.UseVisualStyleBackColor = true;
            this.btnIndexHp.Click += new System.EventHandler(this.btnIndexHp_Click);
            // 
            // btnIndexGeral
            // 
            this.btnIndexGeral.FlatAppearance.BorderSize = 0;
            this.btnIndexGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIndexGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnIndexGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndexGeral.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnIndexGeral.ForeColor = System.Drawing.Color.White;
            this.btnIndexGeral.Location = new System.Drawing.Point(0, 167);
            this.btnIndexGeral.Name = "btnIndexGeral";
            this.btnIndexGeral.Size = new System.Drawing.Size(142, 42);
            this.btnIndexGeral.TabIndex = 12;
            this.btnIndexGeral.Text = "Área de abertura de chamados";
            this.btnIndexGeral.UseVisualStyleBackColor = true;
            this.btnIndexGeral.Click += new System.EventHandler(this.btnIndexGeral_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(-1, 254);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 42);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(23, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 39);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(649, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // fRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fRoot";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCadGeral;
        private System.Windows.Forms.Button btnCadHp;
        private System.Windows.Forms.Button btnIndexHp;
        private System.Windows.Forms.Button btnIndexGeral;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}