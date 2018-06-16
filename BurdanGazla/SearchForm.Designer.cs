namespace BurdanGazla
{
    partial class SearchForm
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
            this.DgwIlan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.minPriceBox = new System.Windows.Forms.TextBox();
            this.maxPriceBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FuelBox = new System.Windows.Forms.ComboBox();
            this.gearComboBox = new System.Windows.Forms.ComboBox();
            this.minKmBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxKmBox = new System.Windows.Forms.TextBox();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).BeginInit();
            this.Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgwIlan
            // 
            this.DgwIlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwIlan.Location = new System.Drawing.Point(12, 21);
            this.DgwIlan.Name = "DgwIlan";
            this.DgwIlan.Size = new System.Drawing.Size(698, 173);
            this.DgwIlan.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şehir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat Aralığı (min)-(max):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yakıt Türü:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Vites Türü:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Km Aralığı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Renk:";
            // 
            // CityComboBox
            // 
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(129, 15);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(137, 21);
            this.CityComboBox.TabIndex = 10;
            this.CityComboBox.SelectedIndexChanged += new System.EventHandler(this.CityComboBox_SelectedIndexChanged);
            // 
            // minPriceBox
            // 
            this.minPriceBox.Location = new System.Drawing.Point(129, 66);
            this.minPriceBox.Name = "minPriceBox";
            this.minPriceBox.Size = new System.Drawing.Size(137, 20);
            this.minPriceBox.TabIndex = 11;
            // 
            // maxPriceBox
            // 
            this.maxPriceBox.Location = new System.Drawing.Point(290, 66);
            this.maxPriceBox.Name = "maxPriceBox";
            this.maxPriceBox.Size = new System.Drawing.Size(137, 20);
            this.maxPriceBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "-";
            // 
            // FuelBox
            // 
            this.FuelBox.FormattingEnabled = true;
            this.FuelBox.Location = new System.Drawing.Point(129, 42);
            this.FuelBox.Name = "FuelBox";
            this.FuelBox.Size = new System.Drawing.Size(137, 21);
            this.FuelBox.TabIndex = 14;
            this.FuelBox.SelectedIndexChanged += new System.EventHandler(this.FuelBox_SelectedIndexChanged);
            // 
            // gearComboBox
            // 
            this.gearComboBox.FormattingEnabled = true;
            this.gearComboBox.Location = new System.Drawing.Point(525, 20);
            this.gearComboBox.Name = "gearComboBox";
            this.gearComboBox.Size = new System.Drawing.Size(137, 21);
            this.gearComboBox.TabIndex = 15;
            this.gearComboBox.SelectedIndexChanged += new System.EventHandler(this.gearComboBox_SelectedIndexChanged);
            // 
            // minKmBox
            // 
            this.minKmBox.Location = new System.Drawing.Point(129, 37);
            this.minKmBox.Name = "minKmBox";
            this.minKmBox.Size = new System.Drawing.Size(137, 20);
            this.minKmBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "-";
            // 
            // maxKmBox
            // 
            this.maxKmBox.Location = new System.Drawing.Point(290, 37);
            this.maxKmBox.Name = "maxKmBox";
            this.maxKmBox.Size = new System.Drawing.Size(137, 20);
            this.maxKmBox.TabIndex = 18;
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(525, 50);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(137, 21);
            this.ColorComboBox.TabIndex = 19;
            this.ColorComboBox.SelectedIndexChanged += new System.EventHandler(this.ColorComboBox_SelectedIndexChanged);
            // 
            // Filter
            // 
            this.Filter.Controls.Add(this.label9);
            this.Filter.Controls.Add(this.NameSearch);
            this.Filter.Controls.Add(this.FuelBox);
            this.Filter.Controls.Add(this.ColorComboBox);
            this.Filter.Controls.Add(this.label3);
            this.Filter.Controls.Add(this.label1);
            this.Filter.Controls.Add(this.label4);
            this.Filter.Controls.Add(this.gearComboBox);
            this.Filter.Controls.Add(this.label6);
            this.Filter.Controls.Add(this.CityComboBox);
            this.Filter.Location = new System.Drawing.Point(12, 218);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(698, 99);
            this.Filter.TabIndex = 20;
            this.Filter.TabStop = false;
            this.Filter.Text = "Filtrele";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "İlan Adı:";
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(129, 69);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(137, 20);
            this.NameSearch.TabIndex = 21;
            this.NameSearch.TextChanged += new System.EventHandler(this.NameSearch_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(444, 34);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 23);
            this.SearchButton.TabIndex = 20;
            this.SearchButton.Text = "Ara";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.minPriceBox);
            this.groupBox1.Controls.Add(this.maxPriceBox);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maxKmBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.minKmBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(717, 21);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(25, 23);
            this.DownButton.TabIndex = 22;
            this.DownButton.Text = "Aşağı Ok";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(717, 50);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(25, 23);
            this.UpButton.TabIndex = 23;
            this.UpButton.Text = "Yukarı Ok";
            this.UpButton.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 483);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.DgwIlan);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwIlan)).EndInit();
            this.Filter.ResumeLayout(false);
            this.Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwIlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.TextBox minPriceBox;
        private System.Windows.Forms.TextBox maxPriceBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FuelBox;
        private System.Windows.Forms.ComboBox gearComboBox;
        private System.Windows.Forms.TextBox minKmBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxKmBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.GroupBox Filter;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
    }
}