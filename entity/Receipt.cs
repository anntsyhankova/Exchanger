using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.entity
{
    public class Receipt
    {
        //сумма для продажи/покупки
        private int sum;
        //валюта
        private String value;
        //продажа или покупка
        private String action;
        //обменный курс
        private float rate;

        public Receipt(int sum, string value, string action, float rate)
        {   

            this.Sum = sum;
            this.Value = value;
            this.Action = action;
            this.Rate = rate;
        }

        public int Sum { get => sum; set => sum = value; }
        public string Value { get => value; set => this.value = value; }
        public string Action { get => action; set => action = value; }
        public float Rate { get => rate; set => rate = value; }

        public override bool Equals(object obj)
        {
            return obj is Receipt receipt &&
                   Sum == receipt.Sum &&
                   Value == receipt.Value &&
                   Action == receipt.Action &&
                   Rate == receipt.Rate;
        }

        public override int GetHashCode()
        {
            int hashCode = -899304688;
            hashCode = hashCode * -1521134295 + Sum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Action);
            hashCode = hashCode * -1521134295 + Rate.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return new StringBuilder("{ \n Sum of currancy: ").Append(sum).Append("\n").Append("currancy type: ").Append(value).Append("\n").Append("action: ").Append(action).Append("\n").Append("rate: ").Append(rate).Append("\n").Append("}").ToString();
        }
    }
}
