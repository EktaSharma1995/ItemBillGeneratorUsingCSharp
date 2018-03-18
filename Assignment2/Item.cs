﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Item
    {
        private string code;
        private double price;
        private int quantity;

        public Item()
        {

        }

        public Item(string code, double price, int quantity)
        {
            this.code = code;
            this.price = price;
            this.quantity = quantity;
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                if (value == null || value == "")
                {
                    throw new NullReferenceException("Code not provided");
                }
                
                else
                {
                    code = value;
                }

            }

        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value == 0 || value < 0)
                {
                    throw new NullReferenceException("Price can't be negative or zero");
                }

                else
                {
                    price = value;
                }

            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value == 0 || value < 0)
                {
                    throw new NullReferenceException("Quantity can't be negative or zero");
                }

                else
                {
                    quantity = value;
                }

            }
        }

        public double setPrice()
        {
            //foreach()
            if(code.Equals("One"))      //a bill can have more than 1 item so using if
            {
                this.price = 10.0;
            }

            if (code.Equals("Two"))
            {
                this.price = 20.0;
            }

            return price;
        }

        public override string ToString()
        {
            return "Code:" + code + ", " + "Price:" + setPrice() + ", " + "Quantity:" + quantity + "\n";
        }

    }
}
