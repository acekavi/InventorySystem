namespace ProjectDiSE
{
    partial class Storage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Storage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.Button();
            this.clsbtn = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.rmvInv = new System.Windows.Forms.Button();
            this.addCart = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtInventory = new System.Windows.Forms.DataGridView();
            this.InventoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtStockReport = new System.Windows.Forms.DataGridView();
            this.transID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveStock = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrnsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.clsbtn.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInventory)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStockReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.clsbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 29);
            this.panel1.TabIndex = 100;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.min);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(571, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(36, 29);
            this.panel4.TabIndex = 12;
            // 
            // min
            // 
            this.min.ForeColor = System.Drawing.Color.DarkGreen;
            this.min.Location = new System.Drawing.Point(0, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(30, 23);
            this.min.TabIndex = 7;
            this.min.Text = "🗕";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.max);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(607, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(36, 29);
            this.panel3.TabIndex = 12;
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(0, 3);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(30, 23);
            this.max.TabIndex = 8;
            this.max.Text = "🗖";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // clsbtn
            // 
            this.clsbtn.Controls.Add(this.exit);
            this.clsbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.clsbtn.Location = new System.Drawing.Point(643, 0);
            this.clsbtn.Name = "clsbtn";
            this.clsbtn.Size = new System.Drawing.Size(37, 29);
            this.clsbtn.TabIndex = 12;
            // 
            // exit
            // 
            this.exit.ForeColor = System.Drawing.Color.Red;
            this.exit.Location = new System.Drawing.Point(0, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 23);
            this.exit.TabIndex = 9;
            this.exit.Text = "×";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "+ Storage";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(30, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 124;
            this.label2.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cboID);
            this.panel2.Controls.Add(this.rmvInv);
            this.panel2.Controls.Add(this.addCart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 84);
            this.panel2.TabIndex = 0;
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.SystemColors.Menu;
            this.txtQty.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(324, 36);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(94, 25);
            this.txtQty.TabIndex = 2;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Menu;
            this.label7.Location = new System.Drawing.Point(321, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 137;
            this.label7.Text = "Quantity (Pkts)";
            // 
            // cboID
            // 
            this.cboID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboID.BackColor = System.Drawing.SystemColors.Menu;
            this.cboID.DropDownHeight = 150;
            this.cboID.Font = new System.Drawing.Font("Trebuchet MS", 11.25F);
            this.cboID.FormattingEnabled = true;
            this.cboID.IntegralHeight = false;
            this.cboID.Location = new System.Drawing.Point(33, 36);
            this.cboID.MaxDropDownItems = 5;
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(240, 28);
            this.cboID.TabIndex = 1;
            // 
            // rmvInv
            // 
            this.rmvInv.Location = new System.Drawing.Point(537, 39);
            this.rmvInv.Name = "rmvInv";
            this.rmvInv.Size = new System.Drawing.Size(75, 23);
            this.rmvInv.TabIndex = 132;
            this.rmvInv.Text = "Remove";
            this.rmvInv.UseVisualStyleBackColor = true;
            this.rmvInv.Click += new System.EventHandler(this.rmvInv_Click);
            // 
            // addCart
            // 
            this.addCart.Location = new System.Drawing.Point(456, 39);
            this.addCart.Name = "addCart";
            this.addCart.Size = new System.Drawing.Size(75, 23);
            this.addCart.TabIndex = 3;
            this.addCart.Text = "Add to Cart";
            this.addCart.UseVisualStyleBackColor = true;
            this.addCart.Click += new System.EventHandler(this.addCart_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtInventory);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 200);
            this.panel5.TabIndex = 128;
            // 
            // dtInventory
            // 
            this.dtInventory.AllowUserToAddRows = false;
            this.dtInventory.AllowUserToDeleteRows = false;
            this.dtInventory.AllowUserToResizeColumns = false;
            this.dtInventory.AllowUserToResizeRows = false;
            this.dtInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dtInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InventoryID,
            this.ItemID,
            this.remStock,
            this.aStock,
            this.price});
            this.dtInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtInventory.Location = new System.Drawing.Point(0, 0);
            this.dtInventory.MultiSelect = false;
            this.dtInventory.Name = "dtInventory";
            this.dtInventory.ReadOnly = true;
            this.dtInventory.RowHeadersVisible = false;
            this.dtInventory.Size = new System.Drawing.Size(680, 200);
            this.dtInventory.TabIndex = 1;
            this.dtInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtInventory_CellClick);
            this.dtInventory.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtInventory_RowsAdded);
            // 
            // InventoryID
            // 
            this.InventoryID.HeaderText = "Inventory ID";
            this.InventoryID.Name = "InventoryID";
            this.InventoryID.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // remStock
            // 
            this.remStock.HeaderText = "Remaining Stock";
            this.remStock.Name = "remStock";
            this.remStock.ReadOnly = true;
            // 
            // aStock
            // 
            this.aStock.HeaderText = "Arrival Stock";
            this.aStock.Name = "aStock";
            this.aStock.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtStockReport);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 394);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(680, 223);
            this.panel6.TabIndex = 129;
            // 
            // dtStockReport
            // 
            this.dtStockReport.AllowUserToAddRows = false;
            this.dtStockReport.AllowUserToDeleteRows = false;
            this.dtStockReport.AllowUserToResizeColumns = false;
            this.dtStockReport.AllowUserToResizeRows = false;
            this.dtStockReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtStockReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.dtStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transID,
            this.user,
            this.type,
            this.Date,
            this.items,
            this.stockPrice});
            this.dtStockReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtStockReport.Location = new System.Drawing.Point(0, 0);
            this.dtStockReport.Name = "dtStockReport";
            this.dtStockReport.RowHeadersVisible = false;
            this.dtStockReport.Size = new System.Drawing.Size(680, 223);
            this.dtStockReport.TabIndex = 2;
            // 
            // transID
            // 
            this.transID.DataPropertyName = "transID";
            this.transID.HeaderText = "Transaction ID";
            this.transID.Name = "transID";
            // 
            // user
            // 
            this.user.DataPropertyName = "user";
            this.user.HeaderText = "User";
            this.user.Name = "user";
            // 
            // type
            // 
            this.type.DataPropertyName = "transType";
            this.type.HeaderText = "Transaction Type";
            this.type.Name = "type";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "transDate";
            this.Date.HeaderText = "Date Added";
            this.Date.Name = "Date";
            // 
            // items
            // 
            this.items.DataPropertyName = "items";
            this.items.HeaderText = "Item List";
            this.items.Name = "items";
            // 
            // stockPrice
            // 
            this.stockPrice.DataPropertyName = "stockPrice";
            this.stockPrice.HeaderText = "Stock Price";
            this.stockPrice.Name = "stockPrice";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveStock
            // 
            this.saveStock.Location = new System.Drawing.Point(456, 348);
            this.saveStock.Name = "saveStock";
            this.saveStock.Size = new System.Drawing.Size(75, 23);
            this.saveStock.TabIndex = 5;
            this.saveStock.Text = "Save Cart";
            this.saveStock.UseVisualStyleBackColor = true;
            this.saveStock.Click += new System.EventHandler(this.saveStock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Menu;
            this.label6.Location = new System.Drawing.Point(321, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 140;
            this.label6.Text = "Total Stock Price";
            // 
            // txtStPrice
            // 
            this.txtStPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStPrice.Enabled = false;
            this.txtStPrice.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStPrice.Location = new System.Drawing.Point(324, 348);
            this.txtStPrice.Name = "txtStPrice";
            this.txtStPrice.Size = new System.Drawing.Size(94, 25);
            this.txtStPrice.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(30, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 138;
            this.label4.Text = "Transaction ID";
            // 
            // txtTrnsID
            // 
            this.txtTrnsID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTrnsID.Enabled = false;
            this.txtTrnsID.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrnsID.Location = new System.Drawing.Point(33, 348);
            this.txtTrnsID.Name = "txtTrnsID";
            this.txtTrnsID.Size = new System.Drawing.Size(94, 25);
            this.txtTrnsID.TabIndex = 137;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(176, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 136;
            this.label3.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(179, 348);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(94, 25);
            this.txtDate.TabIndex = 135;
            // 
            // Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(680, 617);
            this.Controls.Add(this.saveStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTrnsID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Storage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Storage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.clsbtn.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtInventory)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtStockReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Panel clsbtn;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.DataGridView dtInventory;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.DataGridView dtStockReport;
        private System.Windows.Forms.Button rmvInv;
        private System.Windows.Forms.Button addCart;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button saveStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrnsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn remStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn aStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn transID;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn items;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPrice;
    }
}