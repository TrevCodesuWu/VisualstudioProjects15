using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_machine
{
    class CardHolder
    {
        private string first_name;
        private string last_name;
        private string card_num;
        private int card_pin;
        private double balance;

        public CardHolder(string first_name, string last_name, string card_num, int card_pin, double balance)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.card_num = card_num;
            this.card_pin = card_pin;
            this.balance = balance;
        }

        public int Card_pin
        {
            get
            {
                return card_pin;
            }

            set
            {
                card_pin = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        public string getfirst_name()
        {
            return this.first_name; 
        }
        public void setfirst_name(string firstn)
        {
            this.first_name = firstn; 
        }

        public string getlast_name()
        {
            return this.last_name; 
        }
        public void setlast_name(string lastn)
        {
            this.last_name = lastn; 
        }
        public string getcard_num()
        {
            return this.card_num; 
        }
        public void setcard_num(string cardnum)
        {
            this.card_num = cardnum; 
        }

    }
}
