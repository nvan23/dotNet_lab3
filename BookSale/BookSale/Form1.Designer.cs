namespace BookSale
{
    partial class BookSale
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtExPrice = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblNetDue = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNetDue = new System.Windows.Forms.TextBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.chkDisStu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(26, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(26, 71);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(26, 108);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblEPrice
            // 
            this.lblEPrice.AutoSize = true;
            this.lblEPrice.Location = new System.Drawing.Point(26, 152);
            this.lblEPrice.Name = "lblEPrice";
            this.lblEPrice.Size = new System.Drawing.Size(79, 13);
            this.lblEPrice.TabIndex = 3;
            this.lblEPrice.Text = "Extended Price";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(129, 26);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(276, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(129, 64);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(139, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(129, 101);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(139, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtExPrice
            // 
            this.txtExPrice.Location = new System.Drawing.Point(129, 145);
            this.txtExPrice.Name = "txtExPrice";
            this.txtExPrice.Size = new System.Drawing.Size(139, 20);
            this.txtExPrice.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(39, 369);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(142, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(240, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(335, 369);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 11;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(26, 193);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "Discount";
            // 
            // lblNetDue
            // 
            this.lblNetDue.AutoSize = true;
            this.lblNetDue.Location = new System.Drawing.Point(26, 235);
            this.lblNetDue.Name = "lblNetDue";
            this.lblNetDue.Size = new System.Drawing.Size(47, 13);
            this.lblNetDue.TabIndex = 13;
            this.lblNetDue.Text = "Net Due";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(129, 186);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(139, 20);
            this.txtDiscount.TabIndex = 14;
            // 
            // txtNetDue
            // 
            this.txtNetDue.Location = new System.Drawing.Point(129, 228);
            this.txtNetDue.Name = "txtNetDue";
            this.txtNetDue.Size = new System.Drawing.Size(139, 20);
            this.txtNetDue.TabIndex = 15;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(309, 188);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(104, 17);
            this.chkDiscount.TabIndex = 16;
            this.chkDiscount.Text = "Normal Discount";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // chkDisStu
            // 
            this.chkDisStu.AutoSize = true;
            this.chkDisStu.Location = new System.Drawing.Point(309, 228);
            this.chkDisStu.Name = "chkDisStu";
            this.chkDisStu.Size = new System.Drawing.Size(101, 17);
            this.chkDisStu.TabIndex = 17;
            this.chkDisStu.Text = "Distinct Student";
            this.chkDisStu.UseVisualStyleBackColor = true;
            this.chkDisStu.CheckedChanged += new System.EventHandler(this.chkDisStu_CheckedChanged);
            // 
            // BookSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 415);
            this.Controls.Add(this.chkDisStu);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.txtNetDue);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblNetDue);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtExPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblEPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTitle);
            this.Name = "BookSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookSale";
            this.Load += new System.EventHandler(this.BookSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtExPrice;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblNetDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtNetDue;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.CheckBox chkDisStu;
    }
}

