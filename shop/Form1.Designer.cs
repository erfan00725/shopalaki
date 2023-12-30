namespace shop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addProductsBTN = new Button();
            productsEditBTN = new Button();
            Productdelbtn = new Button();
            productsDGV = new DataGridView();
            mainTabs = new TabControl();
            ProductsTab = new TabPage();
            MakersTab = new TabPage();
            MakersAddBTN = new Button();
            makersEditBTN = new Button();
            Makerdelbtn = new Button();
            makersDGV = new DataGridView();
            ordersTabs = new TabPage();
            tabControl1 = new TabControl();
            ordersTab = new TabPage();
            Orderdelbtn = new Button();
            ordersDGV = new DataGridView();
            tabPage3 = new TabPage();
            addProductsListButton = new Button();
            AddBuyerAddressTextBox = new TextBox();
            AddBuyerNumTextBox = new TextBox();
            AddBuyerLastTextBox = new TextBox();
            AddbuyerFirsTextBox = new TextBox();
            label10 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            TahvilIsOk = new Button();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            mainTabs.SuspendLayout();
            ProductsTab.SuspendLayout();
            MakersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)makersDGV).BeginInit();
            ordersTabs.SuspendLayout();
            tabControl1.SuspendLayout();
            ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDGV).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // addProductsBTN
            // 
            addProductsBTN.Location = new Point(571, 413);
            addProductsBTN.Name = "addProductsBTN";
            addProductsBTN.Size = new Size(97, 39);
            addProductsBTN.TabIndex = 2;
            addProductsBTN.Text = "اضافه کردن";
            addProductsBTN.UseVisualStyleBackColor = true;
            addProductsBTN.Click += addProductsBTN_Click;
            // 
            // productsEditBTN
            // 
            productsEditBTN.Location = new Point(330, 413);
            productsEditBTN.Name = "productsEditBTN";
            productsEditBTN.Size = new Size(94, 39);
            productsEditBTN.TabIndex = 1;
            productsEditBTN.Text = "ادیت";
            productsEditBTN.UseVisualStyleBackColor = true;
            productsEditBTN.Click += productsEditBTN_Click;
            // 
            // Productdelbtn
            // 
            Productdelbtn.Location = new Point(448, 413);
            Productdelbtn.Name = "Productdelbtn";
            Productdelbtn.Size = new Size(96, 39);
            Productdelbtn.TabIndex = 1;
            Productdelbtn.Text = "حذف";
            Productdelbtn.UseVisualStyleBackColor = true;
            Productdelbtn.Click += Productdelbtn_Click;
            // 
            // productsDGV
            // 
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(3, 5);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersWidth = 51;
            productsDGV.RowTemplate.Height = 29;
            productsDGV.Size = new Size(941, 373);
            productsDGV.TabIndex = 0;
            productsDGV.CellFormatting += dgv_CellFormatting;
            // 
            // mainTabs
            // 
            mainTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainTabs.Controls.Add(ProductsTab);
            mainTabs.Controls.Add(MakersTab);
            mainTabs.Controls.Add(ordersTabs);
            mainTabs.Location = new Point(0, 0);
            mainTabs.Name = "mainTabs";
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new Size(976, 563);
            mainTabs.TabIndex = 0;
            // 
            // ProductsTab
            // 
            ProductsTab.Controls.Add(addProductsBTN);
            ProductsTab.Controls.Add(productsEditBTN);
            ProductsTab.Controls.Add(Productdelbtn);
            ProductsTab.Controls.Add(productsDGV);
            ProductsTab.Location = new Point(4, 29);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Padding = new Padding(3, 3, 3, 3);
            ProductsTab.Size = new Size(968, 530);
            ProductsTab.TabIndex = 0;
            ProductsTab.Text = "محصولات";
            ProductsTab.UseVisualStyleBackColor = true;
            // 
            // MakersTab
            // 
            MakersTab.Controls.Add(MakersAddBTN);
            MakersTab.Controls.Add(makersEditBTN);
            MakersTab.Controls.Add(Makerdelbtn);
            MakersTab.Controls.Add(makersDGV);
            MakersTab.Location = new Point(4, 29);
            MakersTab.Name = "MakersTab";
            MakersTab.Padding = new Padding(3, 3, 3, 3);
            MakersTab.Size = new Size(968, 530);
            MakersTab.TabIndex = 1;
            MakersTab.Text = "سازندگان";
            MakersTab.UseVisualStyleBackColor = true;
            // 
            // MakersAddBTN
            // 
            MakersAddBTN.Location = new Point(570, 413);
            MakersAddBTN.Name = "MakersAddBTN";
            MakersAddBTN.Size = new Size(97, 39);
            MakersAddBTN.TabIndex = 4;
            MakersAddBTN.Text = "اضافه کردن";
            MakersAddBTN.UseVisualStyleBackColor = true;
            MakersAddBTN.Click += MakersAddBTN_Click;
            // 
            // makersEditBTN
            // 
            makersEditBTN.Location = new Point(325, 413);
            makersEditBTN.Name = "makersEditBTN";
            makersEditBTN.Size = new Size(94, 39);
            makersEditBTN.TabIndex = 3;
            makersEditBTN.Text = "ادیت";
            makersEditBTN.UseVisualStyleBackColor = true;
            makersEditBTN.Click += makersEditBTN_Click;
            // 
            // Makerdelbtn
            // 
            Makerdelbtn.Location = new Point(448, 413);
            Makerdelbtn.Name = "Makerdelbtn";
            Makerdelbtn.Size = new Size(94, 39);
            Makerdelbtn.TabIndex = 2;
            Makerdelbtn.Text = "حذف";
            Makerdelbtn.UseVisualStyleBackColor = true;
            Makerdelbtn.Click += Makerdelbtn_Click;
            // 
            // makersDGV
            // 
            makersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makersDGV.Location = new Point(3, 5);
            makersDGV.Name = "makersDGV";
            makersDGV.RowHeadersWidth = 51;
            makersDGV.RowTemplate.Height = 29;
            makersDGV.Size = new Size(941, 373);
            makersDGV.TabIndex = 0;
            makersDGV.CellFormatting += dgv_CellFormatting;
            // 
            // ordersTabs
            // 
            ordersTabs.Controls.Add(tabControl1);
            ordersTabs.Location = new Point(4, 29);
            ordersTabs.Name = "ordersTabs";
            ordersTabs.Padding = new Padding(3, 3, 3, 3);
            ordersTabs.Size = new Size(968, 530);
            ordersTabs.TabIndex = 2;
            ordersTabs.Text = "سفارشات";
            ordersTabs.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ordersTab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1059, 576);
            tabControl1.TabIndex = 0;
            // 
            // ordersTab
            // 
            ordersTab.Controls.Add(TahvilIsOk);
            ordersTab.Controls.Add(Orderdelbtn);
            ordersTab.Controls.Add(ordersDGV);
            ordersTab.Location = new Point(4, 29);
            ordersTab.Name = "ordersTab";
            ordersTab.Padding = new Padding(3, 3, 3, 3);
            ordersTab.Size = new Size(1051, 543);
            ordersTab.TabIndex = 0;
            ordersTab.Text = "سفارشات";
            ordersTab.UseVisualStyleBackColor = true;
            // 
            // Orderdelbtn
            // 
            Orderdelbtn.Location = new Point(330, 403);
            Orderdelbtn.Name = "Orderdelbtn";
            Orderdelbtn.Size = new Size(114, 43);
            Orderdelbtn.TabIndex = 3;
            Orderdelbtn.Text = "حذف";
            Orderdelbtn.UseVisualStyleBackColor = true;
            Orderdelbtn.Click += Orderdelbtn_Click;
            // 
            // ordersDGV
            // 
            ordersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDGV.Location = new Point(0, 5);
            ordersDGV.Name = "ordersDGV";
            ordersDGV.RowHeadersWidth = 51;
            ordersDGV.RowTemplate.Height = 29;
            ordersDGV.Size = new Size(938, 363);
            ordersDGV.TabIndex = 0;
            ordersDGV.CellFormatting += dgv_CellFormatting;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(addProductsListButton);
            tabPage3.Controls.Add(AddBuyerAddressTextBox);
            tabPage3.Controls.Add(AddBuyerNumTextBox);
            tabPage3.Controls.Add(AddBuyerLastTextBox);
            tabPage3.Controls.Add(AddbuyerFirsTextBox);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 3, 3, 3);
            tabPage3.Size = new Size(1051, 543);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "افزودن سفارش";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addProductsListButton
            // 
            addProductsListButton.Location = new Point(320, 45);
            addProductsListButton.Margin = new Padding(3, 4, 3, 4);
            addProductsListButton.Name = "addProductsListButton";
            addProductsListButton.Size = new Size(86, 60);
            addProductsListButton.TabIndex = 12;
            addProductsListButton.Text = "اضافه کردن سفارش";
            addProductsListButton.UseVisualStyleBackColor = true;
            addProductsListButton.Click += button3_Click_1;
            // 
            // AddBuyerAddressTextBox
            // 
            AddBuyerAddressTextBox.Location = new Point(694, 332);
            AddBuyerAddressTextBox.Name = "AddBuyerAddressTextBox";
            AddBuyerAddressTextBox.Size = new Size(201, 27);
            AddBuyerAddressTextBox.TabIndex = 8;
            // 
            // AddBuyerNumTextBox
            // 
            AddBuyerNumTextBox.Location = new Point(694, 276);
            AddBuyerNumTextBox.Name = "AddBuyerNumTextBox";
            AddBuyerNumTextBox.Size = new Size(201, 27);
            AddBuyerNumTextBox.TabIndex = 8;
            AddBuyerNumTextBox.KeyPress += AddBuyerNumTextBox_KeyPress;
            // 
            // AddBuyerLastTextBox
            // 
            AddBuyerLastTextBox.Location = new Point(229, 332);
            AddBuyerLastTextBox.Name = "AddBuyerLastTextBox";
            AddBuyerLastTextBox.Size = new Size(201, 27);
            AddBuyerLastTextBox.TabIndex = 9;
            // 
            // AddbuyerFirsTextBox
            // 
            AddbuyerFirsTextBox.Location = new Point(229, 271);
            AddbuyerFirsTextBox.Name = "AddbuyerFirsTextBox";
            AddbuyerFirsTextBox.Size = new Size(201, 27);
            AddbuyerFirsTextBox.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(554, 329);
            label10.Name = "label10";
            label10.Size = new Size(56, 28);
            label10.TabIndex = 4;
            label10.Text = "آدرس";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(525, 276);
            label5.Name = "label5";
            label5.Size = new Size(101, 28);
            label5.TabIndex = 4;
            label5.Text = "تلفن تماس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(49, 335);
            label6.Name = "label6";
            label6.Size = new Size(117, 28);
            label6.TabIndex = 5;
            label6.Text = "نام خانوادگی";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(70, 273);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 6;
            label7.Text = "نام خریدار";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 45);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 7;
            label8.Text = "سفارشات :";
            // 
            // button2
            // 
            button2.Location = new Point(431, 412);
            button2.Name = "button2";
            button2.Size = new Size(165, 45);
            button2.TabIndex = 3;
            button2.Text = "اضافه کردن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TahvilIsOk
            // 
            TahvilIsOk.Location = new Point(473, 403);
            TahvilIsOk.Name = "TahvilIsOk";
            TahvilIsOk.Size = new Size(114, 43);
            TahvilIsOk.TabIndex = 4;
            TahvilIsOk.Text = "تایید تحویل";
            TahvilIsOk.UseVisualStyleBackColor = true;
            TahvilIsOk.Click += TahvilIsOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(953, 548);
            Controls.Add(mainTabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "shop";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            mainTabs.ResumeLayout(false);
            ProductsTab.ResumeLayout(false);
            MakersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)makersDGV).EndInit();
            ordersTabs.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ordersDGV).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl mainTabs;
        private TabPage MakersTab;
        private TabPage ordersTabs;
        private TabPage ProductsTab;
        private TabControl tabControl1;
        private TabPage ordersTab;
        private TabPage tabPage3;
        private TextBox AddBuyerNumTextBox;
        private TextBox AddBuyerLastTextBox;
        private TextBox AddbuyerFirsTextBox;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button2;
        private DataGridView productsDGV;
        private DataGridView makersDGV;
        private DataGridView ordersDGV;
        private TextBox AddBuyerAddressTextBox;
        private Label label10;
        private Button addProductsListButton;
        private Button Productdelbtn;
        private Button Makerdelbtn;
        private Button Orderdelbtn;
        private Button addProductsBTN;
        private Button productsEditBTN;
        private Button MakersAddBTN;
        private Button makersEditBTN;
        private Button TahvilIsOk;
    }
}