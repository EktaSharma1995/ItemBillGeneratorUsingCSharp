using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        ISet<Item> itemHashSet = new HashSet<Item>();
        IDictionary<int, Bill> billDictionary = new Dictionary<int, Bill>();
        IDictionary<string, double> itemPriceDict = new Dictionary<string, double>();

        public Form1()
        {
            InitializeComponent();
            itemPriceDict.Add("AB", 12.75);
            itemPriceDict.Add("BC", 7.99);
            itemPriceDict.Add("CD", 14.79);
            itemPriceDict.Add("DE", 4.59);
            itemPriceDict.Add("EF", 35.02);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                int existingBillNum = int.Parse(billNumTxt.Text); 

                if (billDictionary.ContainsKey(existingBillNum))
                {
                    Bill billObj = billDictionary[existingBillNum];

                    Item itemObj = new Item();
                    itemObj.Code = textBoxCode.Text;
                    itemObj.Quantity = int.Parse(textBoxQuantity.Text);
                    itemObj.Price = itemPriceDict[itemObj.Code];
                    billObj.addItem(itemObj);
                   
                    lblMessage.Text = "Item added";
                }
                else
                {
                    lblMessage.Text = "Bill does not exist";
                }                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                int existingBillNum = int.Parse(billNumTxt.Text);

                if (billDictionary.ContainsKey(existingBillNum))
                {
                    Bill billObj = billDictionary[existingBillNum];
                    int idx = billObj.getIndexOfItem(textBoxCode.Text);
                    billObj.removeItem(idx);
                    lblMessage.Text = "Item removed";
                }
                else
                {
                    lblMessage.Text = "Bill does not exist";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            try
            {
                int existingBillNum = int.Parse(billNumTxt.Text);

                if (billDictionary.ContainsKey(existingBillNum))
                {
                    Bill billObj = billDictionary[existingBillNum];
                    int idx = billObj.getIndexOfItem(textBoxCode.Text);
                    billObj.updateItemQuantity(idx, int.Parse(textBoxQuantity.Text));
                    lblMessage.Text = "Item updated";
                }
                else
                {
                    lblMessage.Text = "Bill does not exist";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item();
                Bill bill = new Bill();

                item.Code = textBoxCode.Text;
                item.Quantity = int.Parse(textBoxQuantity.Text);
                item.Price = itemPriceDict[item.Code];
                bill.addItem(item);
               
                billNumTxt.Text = bill.BillNumber.ToString();
                billDictionary.Add(int.Parse(billNumTxt.Text), bill);

                lblMessage.Text = "Bill created";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindBill_Click(object sender, EventArgs e)
        {
            try
            {
                int existingBillNumToFind = int.Parse(billNumTxt.Text);

                if (billDictionary.ContainsKey(existingBillNumToFind))
                {
                    lblMessage.Text = "Bill exists";
                    Bill billObj = billDictionary[existingBillNumToFind];

                    displayBox.Items.Clear();

                    displayBox.Items.Add(billObj.ToString());

                    List<Item> items = billObj.getItems();

                    foreach (Item item in items)
                    {
                        displayBox.Items.Add(item.ToString());
                    }

                }
                else
                {
                    lblMessage.Text = "Bill does not exist";
                    displayBox.Items.Clear();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayBill_Click(object sender, EventArgs e)
        {
            

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayBox.Items.Clear();

            foreach (var billDetails in billDictionary)
            {
                Bill bill = billDetails.Value;
                displayBox.Items.Add(bill.ToString());
                List<Item> items = bill.getItems();

                foreach (Item item in items)
                {
                    displayBox.Items.Add(item.ToString());
                }
            }

        }
    }
}
