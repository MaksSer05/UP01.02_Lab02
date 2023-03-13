namespace OOO_Violet
{
    partial class FlowerCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbname = new System.Windows.Forms.GroupBox();
            this.bbuy = new System.Windows.Forms.Button();
            this.tbcategory = new System.Windows.Forms.TextBox();
            this.lcategory = new System.Windows.Forms.Label();
            this.rtbOpisanie = new System.Windows.Forms.RichTextBox();
            this.lopicanie = new System.Windows.Forms.Label();
            this.tbquantity = new System.Windows.Forms.TextBox();
            this.lprovide = new System.Windows.Forms.Label();
            this.tbcost = new System.Windows.Forms.TextBox();
            this.lCost = new System.Windows.Forms.Label();
            this.tbprovide = new System.Windows.Forms.TextBox();
            this.lquantity = new System.Windows.Forms.Label();
            this.pbFlower = new System.Windows.Forms.PictureBox();
            this.gbname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // gbname
            // 
            this.gbname.Controls.Add(this.bbuy);
            this.gbname.Controls.Add(this.tbcategory);
            this.gbname.Controls.Add(this.lcategory);
            this.gbname.Controls.Add(this.rtbOpisanie);
            this.gbname.Controls.Add(this.lopicanie);
            this.gbname.Controls.Add(this.tbquantity);
            this.gbname.Controls.Add(this.lprovide);
            this.gbname.Controls.Add(this.tbcost);
            this.gbname.Controls.Add(this.lCost);
            this.gbname.Controls.Add(this.tbprovide);
            this.gbname.Controls.Add(this.lquantity);
            this.gbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.gbname.Location = new System.Drawing.Point(256, 14);
            this.gbname.Name = "gbname";
            this.gbname.Size = new System.Drawing.Size(505, 201);
            this.gbname.TabIndex = 14;
            this.gbname.TabStop = false;
            this.gbname.Text = "Наименование товара";
            // 
            // bbuy
            // 
            this.bbuy.Location = new System.Drawing.Point(404, 162);
            this.bbuy.Name = "bbuy";
            this.bbuy.Size = new System.Drawing.Size(90, 26);
            this.bbuy.TabIndex = 14;
            this.bbuy.Text = "Купить";
            this.bbuy.UseVisualStyleBackColor = true;
            this.bbuy.Click += new System.EventHandler(this.bbuy_Click);
            // 
            // tbcategory
            // 
            this.tbcategory.Location = new System.Drawing.Point(164, 169);
            this.tbcategory.Name = "tbcategory";
            this.tbcategory.Size = new System.Drawing.Size(157, 24);
            this.tbcategory.TabIndex = 13;
            // 
            // lcategory
            // 
            this.lcategory.AutoSize = true;
            this.lcategory.Location = new System.Drawing.Point(22, 169);
            this.lcategory.Name = "lcategory";
            this.lcategory.Size = new System.Drawing.Size(80, 18);
            this.lcategory.TabIndex = 12;
            this.lcategory.Text = "Категории";
            // 
            // rtbOpisanie
            // 
            this.rtbOpisanie.Location = new System.Drawing.Point(164, 19);
            this.rtbOpisanie.Name = "rtbOpisanie";
            this.rtbOpisanie.Size = new System.Drawing.Size(330, 58);
            this.rtbOpisanie.TabIndex = 11;
            this.rtbOpisanie.Text = "";
            // 
            // lopicanie
            // 
            this.lopicanie.AutoSize = true;
            this.lopicanie.Location = new System.Drawing.Point(22, 19);
            this.lopicanie.Name = "lopicanie";
            this.lopicanie.Size = new System.Drawing.Size(76, 18);
            this.lopicanie.TabIndex = 2;
            this.lopicanie.Text = "Описание";
            // 
            // tbquantity
            // 
            this.tbquantity.Location = new System.Drawing.Point(164, 141);
            this.tbquantity.Name = "tbquantity";
            this.tbquantity.Size = new System.Drawing.Size(157, 24);
            this.tbquantity.TabIndex = 9;
            // 
            // lprovide
            // 
            this.lprovide.AutoSize = true;
            this.lprovide.Location = new System.Drawing.Point(22, 90);
            this.lprovide.Name = "lprovide";
            this.lprovide.Size = new System.Drawing.Size(118, 18);
            this.lprovide.TabIndex = 3;
            this.lprovide.Text = "Производитель";
            // 
            // tbcost
            // 
            this.tbcost.Location = new System.Drawing.Point(164, 113);
            this.tbcost.Name = "tbcost";
            this.tbcost.Size = new System.Drawing.Size(157, 24);
            this.tbcost.TabIndex = 8;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(22, 120);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(43, 18);
            this.lCost.TabIndex = 4;
            this.lCost.Text = "Цена";
            // 
            // tbprovide
            // 
            this.tbprovide.Location = new System.Drawing.Point(164, 83);
            this.tbprovide.Name = "tbprovide";
            this.tbprovide.Size = new System.Drawing.Size(157, 24);
            this.tbprovide.TabIndex = 7;
            // 
            // lquantity
            // 
            this.lquantity.AutoSize = true;
            this.lquantity.Location = new System.Drawing.Point(22, 145);
            this.lquantity.Name = "lquantity";
            this.lquantity.Size = new System.Drawing.Size(124, 18);
            this.lquantity.TabIndex = 5;
            this.lquantity.Text = "Количество (шт)";
            // 
            // pbFlower
            // 
            this.pbFlower.Location = new System.Drawing.Point(15, 14);
            this.pbFlower.Name = "pbFlower";
            this.pbFlower.Size = new System.Drawing.Size(220, 201);
            this.pbFlower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlower.TabIndex = 13;
            this.pbFlower.TabStop = false;
            // 
            // FlowerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbname);
            this.Controls.Add(this.pbFlower);
            this.Name = "FlowerCard";
            this.Size = new System.Drawing.Size(787, 231);
            this.Load += new System.EventHandler(this.FlowerCard_Load);
            this.gbname.ResumeLayout(false);
            this.gbname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gbname;
        public System.Windows.Forms.RichTextBox rtbOpisanie;
        private System.Windows.Forms.Label lopicanie;
        public System.Windows.Forms.TextBox tbquantity;
        private System.Windows.Forms.Label lprovide;
        public System.Windows.Forms.TextBox tbcost;
        private System.Windows.Forms.Label lCost;
        public System.Windows.Forms.TextBox tbprovide;
        private System.Windows.Forms.Label lquantity;
        public System.Windows.Forms.PictureBox pbFlower;
        public System.Windows.Forms.TextBox tbcategory;
        private System.Windows.Forms.Label lcategory;
        private System.Windows.Forms.Button bbuy;
    }
}
