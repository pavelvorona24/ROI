namespace ROI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DownPayment_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MortgageRate_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AmortYears_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.PropertyCost_label = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.MortgagePrincipal_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Vacancy_box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MonthlyRent_box = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GrossRentalIncome_label = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NetRentalIncome_label = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ROI_label = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ClosingCost_box = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.MaintenanceExpenses_box = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.InsuranceExpenses_box = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.PropertyTax_box = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.OtherExpenses_box = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "ROI Real Estate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Property Cost($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(2, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Down Payment:";
            // 
            // DownPayment_label
            // 
            this.DownPayment_label.AutoSize = true;
            this.DownPayment_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DownPayment_label.Location = new System.Drawing.Point(345, 196);
            this.DownPayment_label.Name = "DownPayment_label";
            this.DownPayment_label.Size = new System.Drawing.Size(0, 27);
            this.DownPayment_label.TabIndex = 7;
            this.DownPayment_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mortgage rate:";
            // 
            // MortgageRate_box
            // 
            this.MortgageRate_box.Location = new System.Drawing.Point(193, 304);
            this.MortgageRate_box.Multiline = true;
            this.MortgageRate_box.Name = "MortgageRate_box";
            this.MortgageRate_box.Size = new System.Drawing.Size(193, 34);
            this.MortgageRate_box.TabIndex = 9;
            this.MortgageRate_box.TextChanged += new System.EventHandler(this.MortgageRate_box_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(2, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Years:";
            // 
            // AmortYears_box
            // 
            this.AmortYears_box.Location = new System.Drawing.Point(193, 338);
            this.AmortYears_box.Multiline = true;
            this.AmortYears_box.Name = "AmortYears_box";
            this.AmortYears_box.Size = new System.Drawing.Size(193, 34);
            this.AmortYears_box.TabIndex = 11;
            this.AmortYears_box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(870, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mortgage:";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(2, 113);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(398, 56);
            this.trackBar2.TabIndex = 14;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // PropertyCost_label
            // 
            this.PropertyCost_label.AutoSize = true;
            this.PropertyCost_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PropertyCost_label.Location = new System.Drawing.Point(249, 83);
            this.PropertyCost_label.Name = "PropertyCost_label";
            this.PropertyCost_label.Size = new System.Drawing.Size(0, 27);
            this.PropertyCost_label.TabIndex = 15;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(2, 226);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(398, 56);
            this.trackBar1.TabIndex = 16;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // MortgagePrincipal_label
            // 
            this.MortgagePrincipal_label.AutoSize = true;
            this.MortgagePrincipal_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MortgagePrincipal_label.Location = new System.Drawing.Point(999, 142);
            this.MortgagePrincipal_label.Name = "MortgagePrincipal_label";
            this.MortgagePrincipal_label.Size = new System.Drawing.Size(0, 27);
            this.MortgagePrincipal_label.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::ROI.Properties.Resources.calculator_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(45, 436);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(287, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(406, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 435);
            this.label4.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(837, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 436);
            this.label8.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(146, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Purchase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(579, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Income";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(416, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(420, 10);
            this.label11.TabIndex = 23;
            // 
            // Vacancy_box
            // 
            this.Vacancy_box.Location = new System.Drawing.Point(625, 176);
            this.Vacancy_box.Multiline = true;
            this.Vacancy_box.Name = "Vacancy_box";
            this.Vacancy_box.Size = new System.Drawing.Size(193, 34);
            this.Vacancy_box.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(434, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 27);
            this.label12.TabIndex = 26;
            this.label12.Text = "Vacancy:";
            // 
            // MonthlyRent_box
            // 
            this.MonthlyRent_box.Location = new System.Drawing.Point(625, 142);
            this.MonthlyRent_box.Multiline = true;
            this.MonthlyRent_box.Name = "MonthlyRent_box";
            this.MonthlyRent_box.Size = new System.Drawing.Size(193, 34);
            this.MonthlyRent_box.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(434, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 27);
            this.label13.TabIndex = 24;
            this.label13.Text = "Monthly Rent:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(993, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 28);
            this.label14.TabIndex = 28;
            this.label14.Text = "ROI Summary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(870, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(244, 27);
            this.label15.TabIndex = 29;
            this.label15.Text = "Gross Yearly Income:";
            // 
            // GrossRentalIncome_label
            // 
            this.GrossRentalIncome_label.AutoSize = true;
            this.GrossRentalIncome_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GrossRentalIncome_label.Location = new System.Drawing.Point(1131, 100);
            this.GrossRentalIncome_label.Name = "GrossRentalIncome_label";
            this.GrossRentalIncome_label.Size = new System.Drawing.Size(0, 27);
            this.GrossRentalIncome_label.TabIndex = 30;
            this.GrossRentalIncome_label.Click += new System.EventHandler(this.GrossRentalIncome_label_Click);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(929, 444);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(276, 86);
            this.label16.TabIndex = 31;
            this.label16.Text = "GRAPHICS";
            // 
            // NetRentalIncome_label
            // 
            this.NetRentalIncome_label.AutoSize = true;
            this.NetRentalIncome_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NetRentalIncome_label.Location = new System.Drawing.Point(1114, 183);
            this.NetRentalIncome_label.Name = "NetRentalIncome_label";
            this.NetRentalIncome_label.Size = new System.Drawing.Size(0, 27);
            this.NetRentalIncome_label.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(870, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(221, 27);
            this.label18.TabIndex = 32;
            this.label18.Text = "Net Rental Income:";
            // 
            // ROI_label
            // 
            this.ROI_label.AutoSize = true;
            this.ROI_label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ROI_label.Location = new System.Drawing.Point(1114, 226);
            this.ROI_label.Name = "ROI_label";
            this.ROI_label.Size = new System.Drawing.Size(0, 27);
            this.ROI_label.TabIndex = 35;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(870, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 27);
            this.label19.TabIndex = 34;
            this.label19.Text = "ROI:";
            // 
            // ClosingCost_box
            // 
            this.ClosingCost_box.Location = new System.Drawing.Point(193, 369);
            this.ClosingCost_box.Multiline = true;
            this.ClosingCost_box.Name = "ClosingCost_box";
            this.ClosingCost_box.Size = new System.Drawing.Size(193, 34);
            this.ClosingCost_box.TabIndex = 37;
            this.ClosingCost_box.TextChanged += new System.EventHandler(this.ClosingCost_box_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(2, 369);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 27);
            this.label17.TabIndex = 36;
            this.label17.Text = "Closing Cost:";
            // 
            // MaintenanceExpenses_box
            // 
            this.MaintenanceExpenses_box.Location = new System.Drawing.Point(705, 444);
            this.MaintenanceExpenses_box.Multiline = true;
            this.MaintenanceExpenses_box.Name = "MaintenanceExpenses_box";
            this.MaintenanceExpenses_box.Size = new System.Drawing.Size(101, 27);
            this.MaintenanceExpenses_box.TabIndex = 43;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(422, 441);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(277, 27);
            this.label20.TabIndex = 42;
            this.label20.Text = "Maintenance Expenses:";
            // 
            // InsuranceExpenses_box
            // 
            this.InsuranceExpenses_box.Location = new System.Drawing.Point(661, 410);
            this.InsuranceExpenses_box.Multiline = true;
            this.InsuranceExpenses_box.Name = "InsuranceExpenses_box";
            this.InsuranceExpenses_box.Size = new System.Drawing.Size(157, 28);
            this.InsuranceExpenses_box.TabIndex = 41;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(422, 411);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(244, 27);
            this.label21.TabIndex = 40;
            this.label21.Text = "Insurance Expenses:";
            // 
            // PropertyTax_box
            // 
            this.PropertyTax_box.Location = new System.Drawing.Point(575, 377);
            this.PropertyTax_box.Multiline = true;
            this.PropertyTax_box.Name = "PropertyTax_box";
            this.PropertyTax_box.Size = new System.Drawing.Size(193, 27);
            this.PropertyTax_box.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(422, 377);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(156, 27);
            this.label22.TabIndex = 38;
            this.label22.Text = "Property Tax:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(499, 300);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(269, 28);
            this.label23.TabIndex = 44;
            this.label23.Text = "Annual Operating Expenses";
            // 
            // OtherExpenses_box
            // 
            this.OtherExpenses_box.Location = new System.Drawing.Point(510, 477);
            this.OtherExpenses_box.Multiline = true;
            this.OtherExpenses_box.Name = "OtherExpenses_box";
            this.OtherExpenses_box.Size = new System.Drawing.Size(165, 27);
            this.OtherExpenses_box.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(422, 474);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(82, 27);
            this.label24.TabIndex = 45;
            this.label24.Text = "Other:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(863, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 185);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // lblOutput
            // 
            this.lblOutput.FormattingEnabled = true;
            this.lblOutput.ItemHeight = 20;
            this.lblOutput.Location = new System.Drawing.Point(863, 256);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(188, 84);
            this.lblOutput.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 513);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OtherExpenses_box);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.MaintenanceExpenses_box);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.InsuranceExpenses_box);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.PropertyTax_box);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.ClosingCost_box);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ROI_label);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.NetRentalIncome_label);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.GrossRentalIncome_label);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Vacancy_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.MonthlyRent_box);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MortgagePrincipal_label);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.PropertyCost_label);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AmortYears_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MortgageRate_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DownPayment_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label DownPayment_label;
        private Label label5;
        private TextBox MortgageRate_box;
        private Label label6;
        private TextBox AmortYears_box;
        private Label label7;
        private TrackBar trackBar2;
        private Label PropertyCost_label;
        private Button button1;
        private TrackBar trackBar1;
        private Label MortgagePrincipal_label;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox Vacancy_box;
        private Label label12;
        private TextBox MonthlyRent_box;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label GrossRentalIncome_label;
        private Label label16;
        private Label NetRentalIncome_label;
        private Label label18;
        private Label ROI_label;
        private Label label19;
        private TextBox ClosingCost_box;
        private Label label17;
        private TextBox MaintenanceExpenses_box;
        private Label label20;
        private TextBox InsuranceExpenses_box;
        private Label label21;
        private TextBox PropertyTax_box;
        private Label label22;
        private Label label23;
        private TextBox OtherExpenses_box;
        private Label label24;
        private PictureBox pictureBox1;
        private ListBox lblOutput;
    }
}