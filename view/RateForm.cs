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
    public partial class RateForm : Form
    {
        private ReceiptController receiptController;
        private User actualUser = new User();
        private String actualValue = "USD";
        private int actualSum = 0;
        private String actualAction;
        private float actualRate;

        public RateForm(User user, ReceiptController controller)
        {
            InitializeComponent();
            Values.Text = "USD";
            Values.Height = Sum.Height;
            actualUser = user;
            receiptController = controller;
        }

        

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            MenuStrip MainMenu = new MenuStrip();
            MainMenu.BackColor = Color.White;
            MainMenu.ForeColor = Color.Black;
            MainMenu.Text = "File Menu";
            this.MainMenuStrip = MainMenu;
            Controls.Add(MainMenu);
        }

        private void UtilsMethod()
        {
            if (Int32.TryParse(Sum.Text, out actualSum))
            {
                switch (Values.Text)
                {
                    case "USD":
                        if (actualAction == "purchase")
                        {
                            actualRate = float.Parse(USDbuy.Text);
                        }
                        else
                        {
                            actualRate = float.Parse(USDSell.Text);
                        }
                        break;
                    case "EUR":
                        if (actualAction == "purchase")
                        {
                            actualRate = float.Parse(EURBuy.Text);
                        }
                        else
                        {
                            actualRate = float.Parse(EURSell.Text);
                        }
                        break;
                    case "RUB":
                        if (actualAction == "purchase")
                        {
                            actualRate = float.Parse(RUBBuy.Text);
                        }
                        else
                        {
                            actualRate = float.Parse(RUBSell.Text);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Enter the desired amount of currency ");
            }
            actualValue = Values.Text;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            actualAction = "purchase";
            UtilsMethod();
            receiptController.ExchangeButtonMethod(actualSum, actualValue, actualAction, actualRate);
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            actualAction = "selling";
            UtilsMethod();
            receiptController.ExchangeButtonMethod(actualSum, actualValue, actualAction, actualRate);
        }

        
        private void Values_DisplayMemberChanged(object sender, EventArgs e)
        {
            actualValue = Values.SelectedItem.ToString();
        }

        public new void Show(){
            if(actualUser.getLogin() != "admin")
            {
                AdminButton.Height = 0;
            }
            base.Show();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            foreach (var receipt in receiptController.getReceipts())
            {
                MessageBox.Show(receipt.ToString());
            }
        }
    }  
}
