namespace TCC_vFinal
{
    partial class fIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fIndex));
            this.pbRoot = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnHelpDesk = new System.Windows.Forms.Button();
            this.btnLoginGeral = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRoot
            // 
            this.pbRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbRoot.Image = ((System.Drawing.Image)(resources.GetObject("pbRoot.Image")));
            this.pbRoot.Location = new System.Drawing.Point(239, 110);
            this.pbRoot.Name = "pbRoot";
            this.pbRoot.Size = new System.Drawing.Size(401, 153);
            this.pbRoot.TabIndex = 9;
            this.pbRoot.TabStop = false;
            this.pbRoot.Click += new System.EventHandler(this.pbRoot_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel4.Controls.Add(this.btnHelpDesk);
            this.panel4.Controls.Add(this.btnLoginGeral);
            this.panel4.Location = new System.Drawing.Point(0, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 193);
            this.panel4.TabIndex = 8;
            // 
            // btnHelpDesk
            // 
            this.btnHelpDesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnHelpDesk.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHelpDesk.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelpDesk.FlatAppearance.BorderSize = 0;
            this.btnHelpDesk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnHelpDesk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnHelpDesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpDesk.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnHelpDesk.ForeColor = System.Drawing.Color.White;
            this.btnHelpDesk.Location = new System.Drawing.Point(-2, 55);
            this.btnHelpDesk.Name = "btnHelpDesk";
            this.btnHelpDesk.Size = new System.Drawing.Size(210, 53);
            this.btnHelpDesk.TabIndex = 1;
            this.btnHelpDesk.Text = "Login Administração do Sistema";
            this.btnHelpDesk.UseVisualStyleBackColor = false;
            this.btnHelpDesk.Click += new System.EventHandler(this.btnHelpDesk_Click);
            // 
            // btnLoginGeral
            // 
            this.btnLoginGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnLoginGeral.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoginGeral.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoginGeral.FlatAppearance.BorderSize = 0;
            this.btnLoginGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLoginGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.btnLoginGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginGeral.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.btnLoginGeral.ForeColor = System.Drawing.Color.White;
            this.btnLoginGeral.Location = new System.Drawing.Point(1, 5);
            this.btnLoginGeral.Name = "btnLoginGeral";
            this.btnLoginGeral.Size = new System.Drawing.Size(210, 47);
            this.btnLoginGeral.TabIndex = 0;
            this.btnLoginGeral.Text = "Login Funcionários";
            this.btnLoginGeral.UseVisualStyleBackColor = false;
            this.btnLoginGeral.Click += new System.EventHandler(this.btnLoginGeral_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel5.Location = new System.Drawing.Point(0, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(676, 11);
            this.panel5.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(676, 10);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 72);
            this.panel1.TabIndex = 5;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(587, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(41, 37);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEM VINDO AO SISTEMA DE CHAMADOS";
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
            this.button1.Location = new System.Drawing.Point(624, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panel3.Location = new System.Drawing.Point(195, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 12);
            this.panel3.TabIndex = 10;
            // 
            // fIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 280);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pbRoot);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRoot;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnHelpDesk;
        private System.Windows.Forms.Button btnLoginGeral;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimizar;
    }
}

