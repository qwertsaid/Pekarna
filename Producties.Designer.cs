namespace Pekarna
{
    partial class Producties
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(413, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Категория товара | Наименование товара";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(392, 92);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 16);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Описание";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(392, 130);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(111, 16);
            this.lblProducer.TabIndex = 2;
            this.lblProducer.Text = "Производитель";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(608, 92);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(144, 16);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Действующая скидка";
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(393, 175);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(79, 16);
            this.lblProvider.TabIndex = 4;
            this.lblProvider.Text = "Поставщик";
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Location = new System.Drawing.Point(656, 218);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(40, 16);
            this.lblOldPrice.TabIndex = 5;
            this.lblOldPrice.Text = "Цена";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(393, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Цена";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(393, 311);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(119, 16);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Кол-во на складе";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(393, 261);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(104, 16);
            this.lblUnit.TabIndex = 8;
            this.lblUnit.Text = "Ед. измерения";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(45, 42);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(286, 285);
            this.pbPhoto.TabIndex = 9;
            this.pbPhoto.TabStop = false;
            // 
            // Producties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOldPrice);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Name = "Producties";
            this.Size = new System.Drawing.Size(932, 470);
            this.Load += new System.EventHandler(this.Producties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblOldPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.PictureBox pbPhoto;
    }
}
