using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Bill
    {
        private int billNumber;
        private DateTime dateOfSale;
        private List<Item> itemList;

        public Bill()
        {
            generateBillNumber();
            generateDate();
            itemList = new List<Item>();
        }

        public void generateBillNumber()
        {
            Random r = new Random();
            this.billNumber = r.Next(1,100);
        }

        public void generateDate()
        {
            this.dateOfSale = DateTime.Today;
        }

        public void addItem(Item item)
        {
            this.itemList.Add(item);
        }

        public int getIndexOfItem(string code)
        {
            int index = -1; // Not found
            foreach(Item item in itemList)
            {
                if (item.Code.Contains(code))
                {
                    index = itemList.IndexOf(item);
                    break;
                }
            }
            return index;

        }

        public void removeItem(int idx)
        {
            this.itemList.RemoveAt(idx);
        }

        public void updateItemQuantity(int idx, int qty)
        {
            Item item = this.itemList[idx];
            item.Quantity = qty;
        }

        public int BillNumber
        {
            get
            {
                return billNumber;
            }

            set
            {
                billNumber = value;
            }

        }

        public DateTime DateOfSale
        {
            get
            {
                return dateOfSale;
            }

            set
            {
                dateOfSale = value;
            }

        }

        public List<Item> getItems()
        {
            return itemList;
        }

        public void setItems(List<Item> itemList)
        {
            this.itemList = itemList;
        }

        public double calAmount()
        {
            double amount = 0;
            foreach (Item item in itemList)
            {
                amount += (item.Price * item.Quantity);
            }

            return amount;
        }

        public bool Equals(Bill other)
        {
            return billNumber.Equals(other.billNumber);
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Bill);
        }

        public override int GetHashCode()
        {
            return billNumber.GetHashCode();
        }

        public override string ToString()
        {
            return "Bill#:" + billNumber + ", " + "Date of Sale:" + dateOfSale + ", " + "Total Amount" +calAmount() ;
        }
    }

}
