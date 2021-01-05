using System;
using System.Collections;
using System.Windows.Forms;
using Exchanger.entity;
using Exchanger.repository;
namespace Exchanger.controller
{
    public class ReceiptController
    {   
        private UserController userController = new UserController();
        private ReceiptRepository receiptRepository = new ReceiptRepository();
        private static RateForm rateForm;

        public void saveReceipt(Receipt receipt) {
            receiptRepository.createReceipt(receipt);
        }

        public ArrayList getReceipts() {
            return receiptRepository.getAllReceipts();
        }

        public void openRateFormFromLoginForm(LoginForm sender)
        {
            sender.Hide();
            rateForm = new RateForm(userController.getActualUser(), this);
            rateForm.Show();
        }

        public void openRateFormFromReceiptForm(Form sender)
        {
            sender.Hide();
            rateForm.Show();
        }

        public void openReceiptForm(Receipt receipt, Form sender)
        {
            sender.Hide();
            new ReceiptForm(receipt, userController.getActualUser())
                .Show();
        }

        public void ExchangeButtonMethod(int actualSum,String actualValue, String actualAction, float actualRate)
        {   
           if (actualSum <= 1000)
           {
                Receipt receipt = new Receipt(actualSum, actualValue, actualAction, actualRate);
                saveReceipt(receipt);
                openReceiptForm(receipt, rateForm);
           }
           else 
           { 
             MessageBox.Show("Enter number less than 1000"); 
           }
        }
    }
}