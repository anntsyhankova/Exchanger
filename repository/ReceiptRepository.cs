using Exchanger.entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.repository
{
    class ReceiptRepository
    {
        public ArrayList receiptList = new ArrayList();

        public void createReceipt(entity.Receipt receipt) {
            receiptList.Add(receipt);
        }

        public ArrayList getAllReceipts() {
            return receiptList;
        }
    }
}
