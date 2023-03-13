namespace OOO_Violet
{
    partial class FAutores
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAutores));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lnazvanie = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.tblogin = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.bGuest = new System.Windows.Forms.Button();
            this.lPassword = new System.Windows.Forms.Label();
            this.bAutores = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel1.Controls.Add(this.bExit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lnazvanie, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lLogin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tblogin, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbpassword, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bGuest, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bAutores, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(749, 526);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bExit.BackColor = System.Drawing.Color.Khaki;
            this.bExit.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.bExit.Location = new System.Drawing.Point(624, 40);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(89, 44);
            this.bExit.TabIndex = 9;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lnazvanie
            // 
            this.Lnazvanie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lnazvanie.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.Lnazvanie, 2);
            this.Lnazvanie.Font = new System.Drawing.Font("Segoe Print", 16.25F);
            this.Lnazvanie.Location = new System.Drawing.Point(172, 0);
            this.Lnazvanie.Name = "Lnazvanie";
            this.Lnazvanie.Size = new System.Drawing.Size(414, 124);
            this.Lnazvanie.TabIndex = 1;
            this.Lnazvanie.Text = "OOO \"Фиалка\"";
            this.Lnazvanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLogin
            // 
            this.lLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.lLogin.Location = new System.Drawing.Point(172, 124);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(163, 124);
            this.lLogin.TabIndex = 10;
            this.lLogin.Text = "Логин";
            this.lLogin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tblogin
            // 
            this.tblogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tblogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tblogin.Location = new System.Drawing.Point(341, 219);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(245, 26);
            this.tblogin.TabIndex = 12;
            // 
            // tbpassword
            // 
            this.tbpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbpassword.Location = new System.Drawing.Point(341, 251);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(245, 26);
            this.tbpassword.TabIndex = 13;
            // 
            // bGuest
            // 
            this.bGuest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bGuest.BackColor = System.Drawing.Color.Khaki;
            this.bGuest.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.bGuest.Location = new System.Drawing.Point(172, 313);
            this.bGuest.Name = "bGuest";
            this.bGuest.Size = new System.Drawing.Size(163, 45);
            this.bGuest.TabIndex = 14;
            this.bGuest.Text = "Гость";
            this.bGuest.UseVisualStyleBackColor = false;
            this.bGuest.Click += new System.EventHandler(this.bGuest_Click);
            // 
            // lPassword
            // 
            this.lPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.lPassword.Location = new System.Drawing.Point(172, 248);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(163, 62);
            this.lPassword.TabIndex = 11;
            this.lPassword.Text = "Пароль";
            this.lPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // bAutores
            // 
            this.bAutores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bAutores.BackColor = System.Drawing.Color.Khaki;
            this.bAutores.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.bAutores.Location = new System.Drawing.Point(341, 313);
            this.bAutores.Name = "bAutores";
            this.bAutores.Size = new System.Drawing.Size(156, 45);
            this.bAutores.TabIndex = 15;
            this.bAutores.Text = "Войти";
            this.bAutores.UseVisualStyleBackColor = false;
            this.bAutores.Click += new System.EventHandler(this.bAutores_Click);
            // 
            // FAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(752, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FAutores";
            this.Text = "Authorization";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lnazvanie;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tblogin;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button bGuest;
        private System.Windows.Forms.Button bAutores;
    }
}

