using Exchanger.controller;
using Exchanger.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchanger
{
    public partial class ReceiptForm : Form
    {
        private ReceiptController receiptController = new ReceiptController();
        public ReceiptForm(Receipt receipt, User actualUser)
        {
            InitializeComponent();
            StringBuilder str = new StringBuilder("Thank You " + actualUser.Login + " for " + receipt.Action + " " + receipt.Sum + receipt.Value
                +"\n");
            if (receipt.Action == "purchase")
            {
                str.Append(" you spended " + receipt.Sum * receipt.Rate + " BYN.");
            }
            else 
            {
                str.Append(" you got " + receipt.Sum * receipt.Rate + " BYN.");
            }

            responce.Text = str.ToString();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            receiptController.openRateFormFromReceiptForm(this);
        }
    }
}
