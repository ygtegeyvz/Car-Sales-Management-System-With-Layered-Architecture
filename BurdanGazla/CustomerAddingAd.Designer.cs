namespace BurdanGazla
{
    partial class CustomerAddingAd
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.DgwIlan = new System.Windows.Forms.DataGridView();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddCityBox = new System.Windows.Forms.ComboBox();
            this.AddKmBox = new System.Windows.Forms.TextBox();
            this.AddPriceBox = new System.Windows.Forms.TextBox();
            this.AddNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).BeginInit();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "İlana ekleme yada güncelleme yaparken eklemek istediğiniz aracı yukarıdaki tablod" +
    "an seçiniz.";
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(12, 209);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.Size = new System.Drawing.Size(760, 173);
            this.dgwCars.TabIndex = 12;
            // 
            // DgwIlan
            // 
            this.DgwIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwIlan.Location = new System.Drawing.Point(12, 22);
            this.DgwIlan.Name = "DgwIlan";
            this.DgwIlan.Size = new System.Drawing.Size(760, 173);
            this.DgwIlan.TabIndex = 9;
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.AddButton);
            this.AddGroupBox.Controls.Add(this.AddDateTimePicker);
            this.AddGroupBox.Controls.Add(this.AddCityBox);
            this.AddGroupBox.Controls.Add(this.AddKmBox);
            this.AddGroupBox.Controls.Add(this.AddPriceBox);
            this.AddGroupBox.Controls.Add(this.AddNameBox);
            this.AddGroupBox.Controls.Add(this.label6);
            this.AddGroupBox.Controls.Add(this.label5);
            this.AddGroupBox.Controls.Add(this.label4);
            this.AddGroupBox.Controls.Add(this.label3);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Location = new System.Drawing.Point(12, 404);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(327, 247);
            this.AddGroupBox.TabIndex = 8;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "İlan Ekle";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(129, 209);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(143, 23);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Ekle";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddDateTimePicker
            // 
            this.AddDateTimePicker.Location = new System.Drawing.Point(129, 168);
            this.AddDateTimePicker.Name = "AddDateTimePicker";
            this.AddDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.AddDateTimePicker.TabIndex = 11;
            // 
            // AddCityBox
            // 
            this.AddCityBox.FormattingEnabled = true;
            this.AddCityBox.Location = new System.Drawing.Point(129, 131);
            this.AddCityBox.Name = "AddCityBox";
            this.AddCityBox.Size = new System.Drawing.Size(143, 21);
            this.AddCityBox.TabIndex = 10;
            // 
            // AddKmBox
            // 
            this.AddKmBox.Location = new System.Drawing.Point(129, 90);
            this.AddKmBox.Name = "AddKmBox";
            this.AddKmBox.Size = new System.Drawing.Size(143, 20);
            this.AddKmBox.TabIndex = 8;
            // 
            // AddPriceBox
            // 
            this.AddPriceBox.Location = new System.Drawing.Point(129, 59);
            this.AddPriceBox.Name = "AddPriceBox";
            this.AddPriceBox.Size = new System.Drawing.Size(143, 20);
            this.AddPriceBox.TabIndex = 7;
            // 
            // AddNameBox
            // 
            this.AddNameBox.Location = new System.Drawing.Point(129, 29);
            this.AddNameBox.Name = "AddNameBox";
            this.AddNameBox.Size = new System.Drawing.Size(143, 20);
            this.AddNameBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan Adı";
            // 
            // CustomerAddingAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgwCars);
            this.Controls.Add(this.DgwIlan);
            this.Controls.Add(this.AddGroupBox);
            this.Name = "CustomerAddingAd";
            this.Text = "CustomerAddingAd";
            this.Load += new System.EventHandler(this.CustomerAddingAd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).EndInit();
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.DataGridView DgwIlan;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker AddDateTimePicker;
        private System.Windows.Forms.ComboBox AddCityBox;
        private System.Windows.Forms.TextBox AddKmBox;
        private System.Windows.Forms.TextBox AddPriceBox;
        private System.Windows.Forms.TextBox AddNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}