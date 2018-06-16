namespace BurdanGazla
{
    partial class AdminForm
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
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
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
            this.DgwIlan = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateCityComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateKmBox = new System.Windows.Forms.TextBox();
            this.UpdatePriceBox = new System.Windows.Forms.TextBox();
            this.UpdateNameBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AddGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            this.SuspendLayout();
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
            this.AddGroupBox.Location = new System.Drawing.Point(46, 400);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(327, 247);
            this.AddGroupBox.TabIndex = 1;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "İlan Ekle";
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
            // DgwIlan
            // 
            this.DgwIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwIlan.Location = new System.Drawing.Point(46, 13);
            this.DgwIlan.Name = "DgwIlan";
            this.DgwIlan.Size = new System.Drawing.Size(760, 173);
            this.DgwIlan.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(669, 371);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Seçili Aracı Sil";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpdateButton);
            this.groupBox1.Controls.Add(this.UpdateDateTimePicker);
            this.groupBox1.Controls.Add(this.UpdateCityComboBox);
            this.groupBox1.Controls.Add(this.UpdateKmBox);
            this.groupBox1.Controls.Add(this.UpdatePriceBox);
            this.groupBox1.Controls.Add(this.UpdateNameBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(465, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hatalı İlanı Güncelle";
            // 
            // UpdateDateTimePicker
            // 
            this.UpdateDateTimePicker.Location = new System.Drawing.Point(129, 158);
            this.UpdateDateTimePicker.Name = "UpdateDateTimePicker";
            this.UpdateDateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.UpdateDateTimePicker.TabIndex = 11;
            // 
            // UpdateCityComboBox
            // 
            this.UpdateCityComboBox.FormattingEnabled = true;
            this.UpdateCityComboBox.Location = new System.Drawing.Point(129, 126);
            this.UpdateCityComboBox.Name = "UpdateCityComboBox";
            this.UpdateCityComboBox.Size = new System.Drawing.Size(143, 21);
            this.UpdateCityComboBox.TabIndex = 10;
            // 
            // UpdateKmBox
            // 
            this.UpdateKmBox.Location = new System.Drawing.Point(129, 90);
            this.UpdateKmBox.Name = "UpdateKmBox";
            this.UpdateKmBox.Size = new System.Drawing.Size(143, 20);
            this.UpdateKmBox.TabIndex = 8;
            // 
            // UpdatePriceBox
            // 
            this.UpdatePriceBox.Location = new System.Drawing.Point(129, 59);
            this.UpdatePriceBox.Name = "UpdatePriceBox";
            this.UpdatePriceBox.Size = new System.Drawing.Size(143, 20);
            this.UpdatePriceBox.TabIndex = 7;
            // 
            // UpdateNameBox
            // 
            this.UpdateNameBox.Location = new System.Drawing.Point(129, 29);
            this.UpdateNameBox.Name = "UpdateNameBox";
            this.UpdateNameBox.Size = new System.Drawing.Size(143, 20);
            this.UpdateNameBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Şehir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Km";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fiyat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "İlan Adı";
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
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(129, 209);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(143, 23);
            this.UpdateButton.TabIndex = 13;
            this.UpdateButton.Text = "Güncelle";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(46, 192);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.Size = new System.Drawing.Size(760, 173);
            this.dgwCars.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Seçili İlanı Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "İlana ekleme yada güncelleme yaparken eklemek istediğiniz aracı yukarıdaki tablod" +
    "an seçiniz.";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwCars);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DgwIlan);
            this.Controls.Add(this.AddGroupBox);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.DataGridView DgwIlan;
        private System.Windows.Forms.Button DeleteButton;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker UpdateDateTimePicker;
        private System.Windows.Forms.ComboBox UpdateCityComboBox;
        private System.Windows.Forms.TextBox UpdateKmBox;
        private System.Windows.Forms.TextBox UpdatePriceBox;
        private System.Windows.Forms.TextBox UpdateNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}