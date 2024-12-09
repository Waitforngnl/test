namespace QuanLiBanVeXemPhim
{
    partial class frmBuyTicket
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuyTicket));
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbAvailableChairs = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDrinks = new System.Windows.Forms.ComboBox();
            this.cbFoods = new System.Windows.Forms.ComboBox();
            this.cbSeatType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbChange = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear_BuyTicket = new System.Windows.Forms.Button();
            this.btnSelectMovie_BuyTicket = new System.Windows.Forms.Button();
            this.lbRegularPrice_BuyTicket = new System.Windows.Forms.Label();
            this.lbAvailableSeat_BuyTicket = new System.Windows.Forms.Label();
            this.lbMovieGenre_BuyTicket = new System.Windows.Forms.Label();
            this.lbMovieName_BuyTicket = new System.Windows.Forms.Label();
            this.lbMovieID_BuyTicket = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbAvailableMovies = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAvailableMovies = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableMovies)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.cbAvailableChairs);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnReceipt);
            this.panel3.Controls.Add(this.btnCalculate);
            this.panel3.Controls.Add(this.btnBuy);
            this.panel3.Controls.Add(this.lbTotalPrice);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.cbDrinks);
            this.panel3.Controls.Add(this.cbFoods);
            this.panel3.Controls.Add(this.cbSeatType);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lbChange);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(653, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 663);
            this.panel3.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(153, 390);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(156, 22);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // cbAvailableChairs
            // 
            this.cbAvailableChairs.FormattingEnabled = true;
            this.cbAvailableChairs.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.cbAvailableChairs.Location = new System.Drawing.Point(137, 85);
            this.cbAvailableChairs.Name = "cbAvailableChairs";
            this.cbAvailableChairs.Size = new System.Drawing.Size(156, 24);
            this.cbAvailableChairs.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(78, 594);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.Location = new System.Drawing.Point(78, 533);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(191, 40);
            this.btnReceipt.TabIndex = 8;
            this.btnReceipt.Text = "RECEIPT";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(137, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(78, 476);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(191, 40);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(152, 355);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(54, 20);
            this.lbTotalPrice.TabIndex = 0;
            this.lbTotalPrice.Text = "$0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 355);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Total Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Available Foods";
            // 
            // cbDrinks
            // 
            this.cbDrinks.FormattingEnabled = true;
            this.cbDrinks.Items.AddRange(new object[] {
            "Coca",
            "Pepsi",
            "Nước Suối",
            "Mirinda",
            "Xá xị",
            "7 Up"});
            this.cbDrinks.Location = new System.Drawing.Point(137, 230);
            this.cbDrinks.Name = "cbDrinks";
            this.cbDrinks.Size = new System.Drawing.Size(156, 24);
            this.cbDrinks.TabIndex = 2;
            // 
            // cbFoods
            // 
            this.cbFoods.FormattingEnabled = true;
            this.cbFoods.Items.AddRange(new object[] {
            "Bắp rang bơ",
            "Bánh gạo",
            "Bim bim",
            "Bánh quy"});
            this.cbFoods.Location = new System.Drawing.Point(137, 184);
            this.cbFoods.Name = "cbFoods";
            this.cbFoods.Size = new System.Drawing.Size(156, 24);
            this.cbFoods.TabIndex = 2;
            // 
            // cbSeatType
            // 
            this.cbSeatType.FormattingEnabled = true;
            this.cbSeatType.Items.AddRange(new object[] {
            "1st Class Seat",
            "2nd Class Seat",
            "Normal Seat"});
            this.cbSeatType.Location = new System.Drawing.Point(137, 36);
            this.cbSeatType.Name = "cbSeatType";
            this.cbSeatType.Size = new System.Drawing.Size(156, 24);
            this.cbSeatType.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Available Chairs:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "Drinks:";
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Location = new System.Drawing.Point(153, 436);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(38, 16);
            this.lbChange.TabIndex = 1;
            this.lbChange.Text = "$0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 436);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "Change:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 397);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Amount:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 184);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Foods:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Seat Type:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear_BuyTicket);
            this.panel2.Controls.Add(this.btnSelectMovie_BuyTicket);
            this.panel2.Controls.Add(this.lbRegularPrice_BuyTicket);
            this.panel2.Controls.Add(this.lbAvailableSeat_BuyTicket);
            this.panel2.Controls.Add(this.lbMovieGenre_BuyTicket);
            this.panel2.Controls.Add(this.lbMovieName_BuyTicket);
            this.panel2.Controls.Add(this.lbMovieID_BuyTicket);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(29, 332);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 353);
            this.panel2.TabIndex = 2;
            // 
            // btnClear_BuyTicket
            // 
            this.btnClear_BuyTicket.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnClear_BuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_BuyTicket.Location = new System.Drawing.Point(433, 253);
            this.btnClear_BuyTicket.Name = "btnClear_BuyTicket";
            this.btnClear_BuyTicket.Size = new System.Drawing.Size(165, 53);
            this.btnClear_BuyTicket.TabIndex = 8;
            this.btnClear_BuyTicket.Text = "CLEAR";
            this.btnClear_BuyTicket.UseVisualStyleBackColor = false;
            this.btnClear_BuyTicket.Click += new System.EventHandler(this.btnClear_BuyTicket_Click);
            // 
            // btnSelectMovie_BuyTicket
            // 
            this.btnSelectMovie_BuyTicket.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnSelectMovie_BuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectMovie_BuyTicket.Location = new System.Drawing.Point(247, 253);
            this.btnSelectMovie_BuyTicket.Name = "btnSelectMovie_BuyTicket";
            this.btnSelectMovie_BuyTicket.Size = new System.Drawing.Size(165, 53);
            this.btnSelectMovie_BuyTicket.TabIndex = 8;
            this.btnSelectMovie_BuyTicket.Text = "SELECT MOVIE";
            this.btnSelectMovie_BuyTicket.UseVisualStyleBackColor = false;
            // 
            // lbRegularPrice_BuyTicket
            // 
            this.lbRegularPrice_BuyTicket.AutoSize = true;
            this.lbRegularPrice_BuyTicket.Location = new System.Drawing.Point(411, 185);
            this.lbRegularPrice_BuyTicket.Name = "lbRegularPrice_BuyTicket";
            this.lbRegularPrice_BuyTicket.Size = new System.Drawing.Size(27, 16);
            this.lbRegularPrice_BuyTicket.TabIndex = 1;
            this.lbRegularPrice_BuyTicket.Text = "-----";
            // 
            // lbAvailableSeat_BuyTicket
            // 
            this.lbAvailableSeat_BuyTicket.AutoSize = true;
            this.lbAvailableSeat_BuyTicket.Location = new System.Drawing.Point(411, 223);
            this.lbAvailableSeat_BuyTicket.Name = "lbAvailableSeat_BuyTicket";
            this.lbAvailableSeat_BuyTicket.Size = new System.Drawing.Size(27, 16);
            this.lbAvailableSeat_BuyTicket.TabIndex = 1;
            this.lbAvailableSeat_BuyTicket.Text = "-----";
            // 
            // lbMovieGenre_BuyTicket
            // 
            this.lbMovieGenre_BuyTicket.AutoSize = true;
            this.lbMovieGenre_BuyTicket.Location = new System.Drawing.Point(411, 145);
            this.lbMovieGenre_BuyTicket.Name = "lbMovieGenre_BuyTicket";
            this.lbMovieGenre_BuyTicket.Size = new System.Drawing.Size(27, 16);
            this.lbMovieGenre_BuyTicket.TabIndex = 1;
            this.lbMovieGenre_BuyTicket.Text = "-----";
            // 
            // lbMovieName_BuyTicket
            // 
            this.lbMovieName_BuyTicket.AutoSize = true;
            this.lbMovieName_BuyTicket.Location = new System.Drawing.Point(411, 106);
            this.lbMovieName_BuyTicket.Name = "lbMovieName_BuyTicket";
            this.lbMovieName_BuyTicket.Size = new System.Drawing.Size(27, 16);
            this.lbMovieName_BuyTicket.TabIndex = 1;
            this.lbMovieName_BuyTicket.Text = "-----";
            // 
            // lbMovieID_BuyTicket
            // 
            this.lbMovieID_BuyTicket.AutoSize = true;
            this.lbMovieID_BuyTicket.Location = new System.Drawing.Point(411, 67);
            this.lbMovieID_BuyTicket.Name = "lbMovieID_BuyTicket";
            this.lbMovieID_BuyTicket.Size = new System.Drawing.Size(27, 16);
            this.lbMovieID_BuyTicket.TabIndex = 1;
            this.lbMovieID_BuyTicket.Text = "-----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Available Seat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Genre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Regular Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Movie Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie ID:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.pbAvailableMovies);
            this.panel4.Location = new System.Drawing.Point(20, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 239);
            this.panel4.TabIndex = 0;
            // 
            // pbAvailableMovies
            // 
            this.pbAvailableMovies.Location = new System.Drawing.Point(0, 0);
            this.pbAvailableMovies.Name = "pbAvailableMovies";
            this.pbAvailableMovies.Size = new System.Drawing.Size(195, 239);
            this.pbAvailableMovies.TabIndex = 1;
            this.pbAvailableMovies.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAvailableMovies);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 292);
            this.panel1.TabIndex = 3;
            // 
            // dgvAvailableMovies
            // 
            this.dgvAvailableMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableMovies.Location = new System.Drawing.Point(18, 36);
            this.dgvAvailableMovies.Name = "dgvAvailableMovies";
            this.dgvAvailableMovies.RowHeadersWidth = 51;
            this.dgvAvailableMovies.RowTemplate.Height = 24;
            this.dgvAvailableMovies.Size = new System.Drawing.Size(581, 218);
            this.dgvAvailableMovies.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Movies";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmBuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBuyTicket";
            this.Size = new System.Drawing.Size(997, 699);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvailableMovies)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbAvailableChairs;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDrinks;
        private System.Windows.Forms.ComboBox cbFoods;
        private System.Windows.Forms.ComboBox cbSeatType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear_BuyTicket;
        private System.Windows.Forms.Button btnSelectMovie_BuyTicket;
        private System.Windows.Forms.Label lbRegularPrice_BuyTicket;
        private System.Windows.Forms.Label lbAvailableSeat_BuyTicket;
        private System.Windows.Forms.Label lbMovieGenre_BuyTicket;
        private System.Windows.Forms.Label lbMovieName_BuyTicket;
        private System.Windows.Forms.Label lbMovieID_BuyTicket;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pbAvailableMovies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAvailableMovies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
