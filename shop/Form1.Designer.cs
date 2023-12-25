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
            TabControl productsTabs;
            tabPage4 = new TabPage();
            Productdelbtn = new Button();
            productsDGV = new DataGridView();
            tabPage5 = new TabPage();
            addProductStackBox = new TextBox();
            addProductPriceBox = new TextBox();
            addProductAuthorIDBox = new TextBox();
            addProductNameBox = new TextBox();
            addProductStack = new Label();
            addProductPrice = new Label();
            addProductAuthorID = new Label();
            addProductName = new Label();
            addProductBTN = new Button();
            mainTabs = new TabControl();
            ProductsTab = new TabPage();
            MakersTab = new TabPage();
            makersTabs = new TabControl();
            tabPage1 = new TabPage();
            Makerdelbtn = new Button();
            makersDGV = new DataGridView();
            addMakerTab = new TabPage();
            textBox9 = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
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
            button3 = new Button();
            productsTabs = new TabControl();
            productsTabs.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsDGV).BeginInit();
            tabPage5.SuspendLayout();
            mainTabs.SuspendLayout();
            ProductsTab.SuspendLayout();
            MakersTab.SuspendLayout();
            makersTabs.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)makersDGV).BeginInit();
            addMakerTab.SuspendLayout();
            ordersTabs.SuspendLayout();
            tabControl1.SuspendLayout();
            ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDGV).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // productsTabs
            // 
            productsTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsTabs.Controls.Add(tabPage4);
            productsTabs.Controls.Add(tabPage5);
            productsTabs.Location = new Point(-5, 0);
            productsTabs.Name = "productsTabs";
            productsTabs.SelectedIndex = 0;
            productsTabs.Size = new Size(998, 537);
            productsTabs.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(Productdelbtn);
            tabPage4.Controls.Add(productsDGV);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(990, 504);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "نمایش محصولات";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Productdelbtn
            // 
            Productdelbtn.Location = new Point(418, 422);
            Productdelbtn.Name = "Productdelbtn";
            Productdelbtn.Size = new Size(94, 29);
            Productdelbtn.TabIndex = 1;
            Productdelbtn.Text = "حذف";
            Productdelbtn.UseVisualStyleBackColor = true;
            Productdelbtn.Click += Productdelbtn_Click;
            // 
            // productsDGV
            // 
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(8, 5);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersWidth = 51;
            productsDGV.RowTemplate.Height = 29;
            productsDGV.Size = new Size(958, 373);
            productsDGV.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(addProductStackBox);
            tabPage5.Controls.Add(addProductPriceBox);
            tabPage5.Controls.Add(addProductAuthorIDBox);
            tabPage5.Controls.Add(addProductNameBox);
            tabPage5.Controls.Add(addProductStack);
            tabPage5.Controls.Add(addProductPrice);
            tabPage5.Controls.Add(addProductAuthorID);
            tabPage5.Controls.Add(addProductName);
            tabPage5.Controls.Add(addProductBTN);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(990, 504);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "اضافه کردن محصول";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // addProductStackBox
            // 
            addProductStackBox.Location = new Point(519, 243);
            addProductStackBox.Name = "addProductStackBox";
            addProductStackBox.Size = new Size(201, 27);
            addProductStackBox.TabIndex = 2;
            // 
            // addProductPriceBox
            // 
            addProductPriceBox.Location = new Point(519, 179);
            addProductPriceBox.Name = "addProductPriceBox";
            addProductPriceBox.Size = new Size(201, 27);
            addProductPriceBox.TabIndex = 2;
            // 
            // addProductAuthorIDBox
            // 
            addProductAuthorIDBox.Location = new Point(519, 117);
            addProductAuthorIDBox.Name = "addProductAuthorIDBox";
            addProductAuthorIDBox.Size = new Size(201, 27);
            addProductAuthorIDBox.TabIndex = 2;
            // 
            // addProductNameBox
            // 
            addProductNameBox.Location = new Point(519, 59);
            addProductNameBox.Name = "addProductNameBox";
            addProductNameBox.Size = new Size(201, 27);
            addProductNameBox.TabIndex = 2;
            // 
            // addProductStack
            // 
            addProductStack.AutoSize = true;
            addProductStack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductStack.Location = new Point(326, 243);
            addProductStack.Name = "addProductStack";
            addProductStack.Size = new Size(130, 28);
            addProductStack.TabIndex = 1;
            addProductStack.Text = "تعداد موجودی";
            // 
            // addProductPrice
            // 
            addProductPrice.AutoSize = true;
            addProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductPrice.Location = new Point(365, 179);
            addProductPrice.Name = "addProductPrice";
            addProductPrice.Size = new Size(91, 28);
            addProductPrice.TabIndex = 1;
            addProductPrice.Text = "قیمت کالا";
            // 
            // addProductAuthorID
            // 
            addProductAuthorID.AutoSize = true;
            addProductAuthorID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductAuthorID.Location = new Point(347, 117);
            addProductAuthorID.Name = "addProductAuthorID";
            addProductAuthorID.Size = new Size(109, 28);
            addProductAuthorID.TabIndex = 1;
            addProductAuthorID.Text = "آیدی سازنده";
            // 
            // addProductName
            // 
            addProductName.AutoSize = true;
            addProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductName.Location = new Point(389, 57);
            addProductName.Name = "addProductName";
            addProductName.Size = new Size(68, 28);
            addProductName.TabIndex = 1;
            addProductName.Text = "نام کالا";
            // 
            // addProductBTN
            // 
            addProductBTN.Location = new Point(427, 384);
            addProductBTN.Name = "addProductBTN";
            addProductBTN.Size = new Size(165, 45);
            addProductBTN.TabIndex = 0;
            addProductBTN.Text = "اضافه کردن";
            addProductBTN.UseVisualStyleBackColor = true;
            addProductBTN.Click += addProductBTN_Click;
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
            mainTabs.Size = new Size(1005, 576);
            mainTabs.TabIndex = 0;
            // 
            // ProductsTab
            // 
            ProductsTab.Controls.Add(productsTabs);
            ProductsTab.Location = new Point(4, 29);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Padding = new Padding(3);
            ProductsTab.Size = new Size(997, 543);
            ProductsTab.TabIndex = 0;
            ProductsTab.Text = "محصولات";
            ProductsTab.UseVisualStyleBackColor = true;
            // 
            // MakersTab
            // 
            MakersTab.Controls.Add(makersTabs);
            MakersTab.Location = new Point(4, 29);
            MakersTab.Name = "MakersTab";
            MakersTab.Padding = new Padding(3);
            MakersTab.Size = new Size(997, 543);
            MakersTab.TabIndex = 1;
            MakersTab.Text = "سازندگان";
            MakersTab.UseVisualStyleBackColor = true;
            // 
            // makersTabs
            // 
            makersTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            makersTabs.Controls.Add(tabPage1);
            makersTabs.Controls.Add(addMakerTab);
            makersTabs.Location = new Point(-5, 0);
            makersTabs.Name = "makersTabs";
            makersTabs.SelectedIndex = 0;
            makersTabs.Size = new Size(995, 537);
            makersTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Makerdelbtn);
            tabPage1.Controls.Add(makersDGV);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(987, 504);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "نمایش سازندگان";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Makerdelbtn
            // 
            Makerdelbtn.Location = new Point(408, 415);
            Makerdelbtn.Name = "Makerdelbtn";
            Makerdelbtn.Size = new Size(94, 29);
            Makerdelbtn.TabIndex = 2;
            Makerdelbtn.Text = "حذف";
            Makerdelbtn.UseVisualStyleBackColor = true;
            Makerdelbtn.Click += Makerdelbtn_Click;
            // 
            // makersDGV
            // 
            makersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makersDGV.Location = new Point(8, 5);
            makersDGV.Name = "makersDGV";
            makersDGV.RowHeadersWidth = 51;
            makersDGV.RowTemplate.Height = 29;
            makersDGV.Size = new Size(958, 365);
            makersDGV.TabIndex = 0;
            // 
            // addMakerTab
            // 
            addMakerTab.Controls.Add(textBox9);
            addMakerTab.Controls.Add(textBox1);
            addMakerTab.Controls.Add(textBox2);
            addMakerTab.Controls.Add(textBox3);
            addMakerTab.Controls.Add(label9);
            addMakerTab.Controls.Add(textBox4);
            addMakerTab.Controls.Add(label1);
            addMakerTab.Controls.Add(label2);
            addMakerTab.Controls.Add(label3);
            addMakerTab.Controls.Add(label4);
            addMakerTab.Controls.Add(button1);
            addMakerTab.Location = new Point(4, 29);
            addMakerTab.Name = "addMakerTab";
            addMakerTab.Padding = new Padding(3);
            addMakerTab.Size = new Size(987, 504);
            addMakerTab.TabIndex = 1;
            addMakerTab.Text = "اضافه کردن سازنده";
            addMakerTab.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(490, 308);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(201, 27);
            textBox9.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(490, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(490, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(201, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(490, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(201, 27);
            textBox3.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(335, 308);
            label9.Name = "label9";
            label9.Size = new Size(56, 28);
            label9.TabIndex = 4;
            label9.Text = "آدرس";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(490, 67);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(201, 27);
            textBox4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 252);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 4;
            label1.Text = "تلفن تماس";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(323, 185);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 5;
            label2.Text = "کد ملی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(285, 123);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 6;
            label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(357, 67);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 7;
            label4.Text = "نام";
            // 
            // button1
            // 
            button1.Location = new Point(399, 393);
            button1.Name = "button1";
            button1.Size = new Size(165, 45);
            button1.TabIndex = 3;
            button1.Text = "اضافه کردن";
            button1.UseVisualStyleBackColor = true;
            // 
            // ordersTabs
            // 
            ordersTabs.Controls.Add(tabControl1);
            ordersTabs.Location = new Point(4, 29);
            ordersTabs.Name = "ordersTabs";
            ordersTabs.Padding = new Padding(3);
            ordersTabs.Size = new Size(997, 543);
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
            ordersTab.Controls.Add(Orderdelbtn);
            ordersTab.Controls.Add(ordersDGV);
            ordersTab.Location = new Point(4, 29);
            ordersTab.Name = "ordersTab";
            ordersTab.Padding = new Padding(3);
            ordersTab.Size = new Size(1051, 543);
            ordersTab.TabIndex = 0;
            ordersTab.Text = "سفارشات";
            ordersTab.UseVisualStyleBackColor = true;
            // 
            // Orderdelbtn
            // 
            Orderdelbtn.Location = new Point(398, 413);
            Orderdelbtn.Name = "Orderdelbtn";
            Orderdelbtn.Size = new Size(94, 29);
            Orderdelbtn.TabIndex = 3;
            Orderdelbtn.Text = "حذف";
            Orderdelbtn.UseVisualStyleBackColor = true;
            Orderdelbtn.Click += Orderdelbtn_Click;
            // 
            // ordersDGV
            // 
            ordersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDGV.Location = new Point(6, 5);
            ordersDGV.Name = "ordersDGV";
            ordersDGV.RowHeadersWidth = 51;
            ordersDGV.RowTemplate.Height = 29;
            ordersDGV.Size = new Size(953, 363);
            ordersDGV.TabIndex = 0;
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
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1051, 543);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "افزودن سفارش";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addProductsListButton
            // 
            addProductsListButton.Location = new Point(320, 21);
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
            AddBuyerAddressTextBox.Location = new Point(718, 332);
            AddBuyerAddressTextBox.Name = "AddBuyerAddressTextBox";
            AddBuyerAddressTextBox.Size = new Size(201, 27);
            AddBuyerAddressTextBox.TabIndex = 8;
            // 
            // AddBuyerNumTextBox
            // 
            AddBuyerNumTextBox.Location = new Point(718, 276);
            AddBuyerNumTextBox.Name = "AddBuyerNumTextBox";
            AddBuyerNumTextBox.Size = new Size(201, 27);
            AddBuyerNumTextBox.TabIndex = 8;
            // 
            // AddBuyerLastTextBox
            // 
            AddBuyerLastTextBox.Location = new Point(255, 332);
            AddBuyerLastTextBox.Name = "AddBuyerLastTextBox";
            AddBuyerLastTextBox.Size = new Size(201, 27);
            AddBuyerLastTextBox.TabIndex = 9;
            // 
            // AddbuyerFirsTextBox
            // 
            AddbuyerFirsTextBox.Location = new Point(255, 271);
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
            label8.Location = new Point(49, 34);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 7;
            label8.Text = "سفارشات";
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
            // button3
            // 
            button3.Location = new Point(534, 422);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "ثبت تغییرات";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(mainTabs);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            productsTabs.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productsDGV).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            mainTabs.ResumeLayout(false);
            ProductsTab.ResumeLayout(false);
            MakersTab.ResumeLayout(false);
            makersTabs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)makersDGV).EndInit();
            addMakerTab.ResumeLayout(false);
            addMakerTab.PerformLayout();
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
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TextBox addProductNameBox;
        private Label addProductName;
        private Button addProductBTN;
        private TextBox addProductStackBox;
        private TextBox addProductPriceBox;
        private TextBox addProductAuthorIDBox;
        private Label addProductStack;
        private Label addProductPrice;
        private Label addProductAuthorID;
        private TabControl makersTabs;
        private TabPage tabPage1;
        private TabPage addMakerTab;
        private TabControl tabControl1;
        private TabPage ordersTab;
        private TabPage tabPage3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
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
        private TextBox textBox9;
        private Label label9;
        private TextBox AddBuyerAddressTextBox;
        private Label label10;
        private Button addProductsListButton;
        private Button Productdelbtn;
        private Button Makerdelbtn;
        private Button Orderdelbtn;
        private Button button3;
    }
}