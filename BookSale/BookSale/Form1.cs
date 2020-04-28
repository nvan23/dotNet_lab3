using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSale
{
    public partial class BookSale : Form
    {
        private clsBookSale mBookSale;

        public BookSale()
        {
            InitializeComponent();
        }

        private void BookSale_Load(object sender, EventArgs e)
        {
            txtExPrice.ReadOnly = true;
            txtDiscount.ReadOnly = true;
            txtNetDue.ReadOnly = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                mBookSale = new clsStudentBookSale(
                                    txtTitle.Text,
                                    Convert.ToInt32(txtQuantity.Text),
                                    Convert.ToDecimal(txtPrice.Text),
                                    chkDiscount.Checked, chkDisStu.Checked
                            );

                txtPrice.Text = mBookSale.Price.ToString("C");
                txtExPrice.Text = mBookSale.ExtendedPrice().ToString("C");
                txtDiscount.Text = mBookSale.DiscountAmount().ToString("C");
                txtNetDue.Text = mBookSale.NetDue().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price. " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();

            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtExPrice.Text = "";
            txtDiscount.Text = "";
            txtNetDue.Text = "";

            txtTitle.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string strMessage = "Sales Total: " + clsBookSale.SalesTotal.ToString("C")
                                + "\nSales Count: " + clsBookSale.SalesCount.ToString();
            MessageBox.Show(strMessage, "Summary Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chkDisStu_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }


    class clsBookSale
    {
        string strTitle;
        int intQuantity;
        decimal decPrice;

        static decimal decSalesTotal = 0;
        static int intSalesCount = 0;

        public clsBookSale(string title, int quantity, decimal price, bool discount)
        {
            this.Title = title;
            this.Quantity = quantity;
            this.Price = price;
            this.Discount = discount;
        }

        public string Title
        {
            get
            {
                return strTitle;
            }
            set
            {
                strTitle = value;
            }
        }

        public int Quantity
        {
            get
            {
                return intQuantity;
            }
            set
            {
                if (value > 0)
                    intQuantity = value;
                else throw new Exception();
            }
        }

        public decimal Price
        {
            get
            {
                return decPrice;
            }
            set
            {
                if (value >= 0)
                    decPrice = value;
                else throw new Exception();
            }
        }

        public decimal ExtendedPrice()
        {
            decimal decExtendedPrice = intQuantity * decPrice;

            return decExtendedPrice;
        }

        public static decimal SalesTotal
        {
            get
            {
                return decSalesTotal;
            }
        }

        public static int SalesCount
        {
            get
            {
                return intSalesCount;
            }
        }

        const float sngDISCOUNT_RATE = 0.1F;
        bool blnDiscount;

        public bool Discount
        {
            get
            {
                return blnDiscount;
            }
            set
            {
                blnDiscount = value;
            }
        }
        
        public virtual decimal DiscountAmount()
        {
            decimal decDiscountAamount;

            if (blnDiscount)
                decDiscountAamount = intQuantity * decPrice * Convert.ToDecimal(sngDISCOUNT_RATE);
            else
                decDiscountAamount = 0M;

            return decDiscountAamount;
        }

        public decimal NetDue()
        {
            decimal decNetDue = ExtendedPrice() - DiscountAmount();

            decSalesTotal += decNetDue; ;
            intSalesCount += 1;

            return decNetDue;
        }

        

    }

    class clsStudentBookSale:clsBookSale
    {
        bool blnStudentDiscount;
        const float sngSTUDENT_DISCOUNT_RATE = 0.15F;

        public bool StudentDiscount
        {
            get
            {
                return blnStudentDiscount;
            }
            set
            {
                blnStudentDiscount = value;
            }
        }

        public clsStudentBookSale(string title, int quantity, decimal price, bool discount, bool student):base(title, quantity, price, discount)
        {
            blnStudentDiscount = student;
        }

        

        public override decimal DiscountAmount()
        {
            decimal decDiscountAmount;

            decDiscountAmount = base.DiscountAmount();

            if (StudentDiscount)
                decDiscountAmount += ExtendedPrice() * Convert.ToDecimal(sngSTUDENT_DISCOUNT_RATE);
            return decDiscountAmount;
        }
    }
}
