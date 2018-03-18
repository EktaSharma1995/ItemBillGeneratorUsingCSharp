namespace Assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.codeLbl = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnFindBill = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.ListBox();
            this.billNumTxt = new System.Windows.Forms.TextBox();
            this.billNumLbl = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Location = new System.Drawing.Point(12, 31);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(55, 13);
            this.codeLbl.TabIndex = 0;
            this.codeLbl.Text = "Item Code";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(15, 78);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(69, 13);
            this.quantityLbl.TabIndex = 1;
            this.quantityLbl.Text = "Item Quantity";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(104, 31);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(104, 70);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(9, 239);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(90, 239);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(86, 23);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(182, 239);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateItem.TabIndex = 6;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 168);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(49, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "message";
            // 
            // btnAddBill
            // 
            this.btnAddBill.Location = new System.Drawing.Point(9, 198);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(75, 23);
            this.btnAddBill.TabIndex = 9;
            this.btnAddBill.Text = "Create Bill";
            this.btnAddBill.UseVisualStyleBackColor = true;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnFindBill
            // 
            this.btnFindBill.Location = new System.Drawing.Point(90, 198);
            this.btnFindBill.Name = "btnFindBill";
            this.btnFindBill.Size = new System.Drawing.Size(75, 23);
            this.btnFindBill.TabIndex = 10;
            this.btnFindBill.Text = "Find";
            this.btnFindBill.UseVisualStyleBackColor = true;
            this.btnFindBill.Click += new System.EventHandler(this.btnFindBill_Click);
            // 
            // displayBox
            // 
            this.displayBox.FormattingEnabled = true;
            this.displayBox.Location = new System.Drawing.Point(291, 14);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(387, 251);
            this.displayBox.TabIndex = 12;
            // 
            // billNumTxt
            // 
            this.billNumTxt.Location = new System.Drawing.Point(105, 6);
            this.billNumTxt.Name = "billNumTxt";
            this.billNumTxt.Size = new System.Drawing.Size(100, 20);
            this.billNumTxt.TabIndex = 14;
            // 
            // billNumLbl
            // 
            this.billNumLbl.AutoSize = true;
            this.billNumLbl.Location = new System.Drawing.Point(12, 14);
            this.billNumLbl.Name = "billNumLbl";
            this.billNumLbl.Size = new System.Drawing.Size(30, 13);
            this.billNumLbl.TabIndex = 13;
            this.billNumLbl.Text = "Bill #";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(171, 198);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 15;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 278);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.billNumTxt);
            this.Controls.Add(this.billNumLbl);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.btnFindBill);
            this.Controls.Add(this.btnAddBill);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.quantityLbl);
            this.Controls.Add(this.codeLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnFindBill;
        private System.Windows.Forms.ListBox displayBox;
        private System.Windows.Forms.TextBox billNumTxt;
        private System.Windows.Forms.Label billNumLbl;
        private System.Windows.Forms.Button btnDisplay;
    }
}

