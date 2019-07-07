namespace AutopliusCrawler
{
    partial class Form1
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
            this.Price_from = new System.Windows.Forms.NumericUpDown();
            this.PriceFrom = new System.Windows.Forms.Label();
            this.Price_to = new System.Windows.Forms.NumericUpDown();
            this.Year_to = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Year_from = new System.Windows.Forms.NumericUpDown();
            this.City = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searched_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Age_of_advertisement = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mileage_from = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Mileage_to = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Price_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_to)).BeginInit();
            this.SuspendLayout();
            // 
            // Price_from
            // 
            this.Price_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_from.Location = new System.Drawing.Point(12, 32);
            this.Price_from.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Price_from.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Price_from.Name = "Price_from";
            this.Price_from.Size = new System.Drawing.Size(113, 26);
            this.Price_from.TabIndex = 0;
            this.Price_from.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Price_from.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // PriceFrom
            // 
            this.PriceFrom.AutoSize = true;
            this.PriceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceFrom.Location = new System.Drawing.Point(81, 9);
            this.PriceFrom.Name = "PriceFrom";
            this.PriceFrom.Size = new System.Drawing.Size(116, 20);
            this.PriceFrom.TabIndex = 1;
            this.PriceFrom.Text = "Kaina nuo-iki, €";
            this.PriceFrom.Click += new System.EventHandler(this.PriceFrom_Click);
            // 
            // Price_to
            // 
            this.Price_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_to.Location = new System.Drawing.Point(149, 32);
            this.Price_to.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.Price_to.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Price_to.Name = "Price_to";
            this.Price_to.Size = new System.Drawing.Size(113, 26);
            this.Price_to.TabIndex = 3;
            this.Price_to.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Year_to
            // 
            this.Year_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_to.Location = new System.Drawing.Point(149, 84);
            this.Year_to.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.Year_to.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year_to.Name = "Year_to";
            this.Year_to.Size = new System.Drawing.Size(113, 26);
            this.Year_to.TabIndex = 7;
            this.Year_to.Value = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.Year_to.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Metai nuo-iki";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Year_from
            // 
            this.Year_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year_from.Location = new System.Drawing.Point(16, 84);
            this.Year_from.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.Year_from.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year_from.Name = "Year_from";
            this.Year_from.Size = new System.Drawing.Size(113, 26);
            this.Year_from.TabIndex = 4;
            this.Year_from.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.Year_from.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // City
            // 
            this.City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.City.FormattingEnabled = true;
            this.City.Items.AddRange(new object[] {
            "Vilnius",
            "Kaunas",
            "Klaipėda",
            "Visi miestai",
            "Šiauliai",
            "Panevėžys",
            "Akmenė",
            "Alytus",
            "Anykščiai",
            "Ariogala",
            "Birštonas",
            "Biržai",
            "Druskininkai",
            "Elektrėnai",
            "Gargždai",
            "Ignalina",
            "Jonava",
            "Joniškis",
            "Juodkrantė",
            "Jurbarkas",
            "Kaišiadorys",
            "Kalvarija",
            "Karklė",
            "Kėdainiai",
            "Kelmė",
            "Kretinga",
            "Kupiškis",
            "Kuršėnai",
            "Lazdijai",
            "Marijampolė",
            "Mažeikiai",
            "Melnragė",
            "Molėtai",
            "Nemenčinė",
            "Neringa",
            "Nida",
            "Pagėgiai",
            "Pakruojis",
            "Palanga",
            "Pasvalys",
            "Plungė",
            "Prienai",
            "Radviliškis",
            "Raseiniai",
            "Rietavas",
            "Rokiškis",
            "Šakiai",
            "Šalčininkai",
            "Šilalė",
            "ŠIlutė",
            "Širvintos",
            "Skaudvilė",
            "Skuodas",
            "Švenčionys",
            "Šventoji",
            "Tauragė",
            "Telšiai",
            "Trakai",
            "Ukmergė",
            "Utena",
            "Varėna",
            "Vievis",
            "Vilkaviškis",
            "Visaginas",
            "Zarasai"});
            this.City.Location = new System.Drawing.Point(12, 242);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(121, 21);
            this.City.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miestas";
            // 
            // searched_number
            // 
            this.searched_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searched_number.Location = new System.Drawing.Point(12, 325);
            this.searched_number.Name = "searched_number";
            this.searched_number.Size = new System.Drawing.Size(243, 29);
            this.searched_number.TabIndex = 10;
            this.searched_number.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ieškomas numeris";
            // 
            // Age_of_advertisement
            // 
            this.Age_of_advertisement.FormattingEnabled = true;
            this.Age_of_advertisement.Items.AddRange(new object[] {
            "1",
            "3",
            "7",
            "14",
            "30"});
            this.Age_of_advertisement.Location = new System.Drawing.Point(139, 242);
            this.Age_of_advertisement.Name = "Age_of_advertisement";
            this.Age_of_advertisement.Size = new System.Drawing.Size(113, 21);
            this.Age_of_advertisement.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 179);
            this.label6.MaximumSize = new System.Drawing.Size(150, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Skelbimai ne senesni kaip (dienų skaičius)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ieškoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Mileage_from
            // 
            this.Mileage_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mileage_from.Location = new System.Drawing.Point(16, 136);
            this.Mileage_from.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.Mileage_from.Name = "Mileage_from";
            this.Mileage_from.Size = new System.Drawing.Size(113, 26);
            this.Mileage_from.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Rida nuo-iki, km";
            // 
            // Mileage_to
            // 
            this.Mileage_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mileage_to.Location = new System.Drawing.Point(142, 136);
            this.Mileage_to.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.Mileage_to.Name = "Mileage_to";
            this.Mileage_to.Size = new System.Drawing.Size(113, 26);
            this.Mileage_to.TabIndex = 18;
            this.Mileage_to.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(701, 456);
            this.Controls.Add(this.Mileage_to);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mileage_from);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Age_of_advertisement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searched_number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Year_to);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Year_from);
            this.Controls.Add(this.Price_to);
            this.Controls.Add(this.PriceFrom);
            this.Controls.Add(this.Price_from);
            this.Name = "Form1";
            this.Text = "Autoplius";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Price_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mileage_to)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Price_from;
        private System.Windows.Forms.Label PriceFrom;
        private System.Windows.Forms.NumericUpDown Price_to;
        private System.Windows.Forms.NumericUpDown Year_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Year_from;
        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searched_number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Age_of_advertisement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Mileage_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Mileage_to;
    }
}

