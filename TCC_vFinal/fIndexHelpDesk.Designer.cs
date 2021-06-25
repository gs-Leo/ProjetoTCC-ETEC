namespace TCC_vFinal
{
    partial class fIndexHelpDesk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIndexHelpDesk));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEspecifico = new System.Windows.Forms.Button();
            this.btnTodosChamados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChamadosFechados = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnEspecifico
            // 
            this.btnEspecifico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnEspecifico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEspecifico.FlatAppearance.BorderSize = 0;
            this.btnEspecifico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEspecifico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnEspecifico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspecifico.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnEspecifico.ForeColor = System.Drawing.Color.White;
            this.btnEspecifico.Location = new System.Drawing.Point(0, 131);
            this.btnEspecifico.Name = "btnEspecifico";
            this.btnEspecifico.Size = new System.Drawing.Size(142, 42);
            this.btnEspecifico.TabIndex = 5;
            this.btnEspecifico.Text = "Responder Chamados";
            this.btnEspecifico.UseVisualStyleBackColor = false;
            this.btnEspecifico.Click += new System.EventHandler(this.btnEspecifico_Click);
            // 
            // btnTodosChamados
            // 
            this.btnTodosChamados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnTodosChamados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosChamados.FlatAppearance.BorderSize = 0;
            this.btnTodosChamados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTodosChamados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnTodosChamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosChamados.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnTodosChamados.ForeColor = System.Drawing.Color.White;
            this.btnTodosChamados.Location = new System.Drawing.Point(0, 83);
            this.btnTodosChamados.Name = "btnTodosChamados";
            this.btnTodosChamados.Size = new System.Drawing.Size(142, 42);
            this.btnTodosChamados.TabIndex = 4;
            this.btnTodosChamados.Text = "Chamados Abertos";
            this.btnTodosChamados.UseVisualStyleBackColor = false;
            this.btnTodosChamados.Click += new System.EventHandler(this.btnTodosChamados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnChamadosFechados);
            this.panel1.Controls.Add(this.btnTodosChamados);
            this.panel1.Controls.Add(this.btnEspecifico);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 359);
            this.panel1.TabIndex = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 227);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 42);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChamadosFechados
            // 
            this.btnChamadosFechados.FlatAppearance.BorderSize = 0;
            this.btnChamadosFechados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChamadosFechados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnChamadosFechados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamadosFechados.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnChamadosFechados.ForeColor = System.Drawing.Color.White;
            this.btnChamadosFechados.Location = new System.Drawing.Point(0, 179);
            this.btnChamadosFechados.Name = "btnChamadosFechados";
            this.btnChamadosFechados.Size = new System.Drawing.Size(142, 42);
            this.btnChamadosFechados.TabIndex = 10;
            this.btnChamadosFechados.Text = "Chamados Fechados";
            this.btnChamadosFechados.UseVisualStyleBackColor = true;
            this.btnChamadosFechados.Click += new System.EventHandler(this.btnChamadosFechados_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(129, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 39);
            this.panel2.TabIndex = 11;
            // 
            // fIndexHelpDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fIndexHelpDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEspecifico;
        private System.Windows.Forms.Button btnTodosChamados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChamadosFechados;
        private System.Windows.Forms.Button btnLogout;
    }
}