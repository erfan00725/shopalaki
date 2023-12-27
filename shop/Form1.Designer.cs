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
            ordersDGV = new DataGridView();
            tabPage3 = new TabPage();
            addProductsListButton = new Button();
            textBox10 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
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
            productsTabs.Location = new Point(-4, 0);
            productsTabs.Margin = new Padding(3, 2, 3, 2);
            productsTabs.Name = "productsTabs";
            productsTabs.SelectedIndex = 0;
            productsTabs.Size = new Size(873, 403);
            productsTabs.TabIndex = 0;
            productsTabs.Click += productsTabs_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(productsDGV);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(865, 375);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "نمایش محصولات";
            tabPage4.UseVisualStyleBackColor = true;
            tabPage4.Click += tabPage4_Click;
            // 
            // productsDGV
            // 
            productsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDGV.Location = new Point(7, 4);
            productsDGV.Margin = new Padding(3, 2, 3, 2);
            productsDGV.Name = "productsDGV";
            productsDGV.RowHeadersWidth = 51;
            productsDGV.RowTemplate.Height = 29;
            productsDGV.Size = new Size(838, 280);
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
            tabPage5.Location = new Point(4, 24);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 2, 3, 2);
            tabPage5.Size = new Size(865, 375);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "اضافه کردن محصول";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // addProductStackBox
            // 
            addProductStackBox.Location = new Point(454, 182);
            addProductStackBox.Margin = new Padding(3, 2, 3, 2);
            addProductStackBox.Name = "addProductStackBox";
            addProductStackBox.Size = new Size(176, 23);
            addProductStackBox.TabIndex = 2;
            addProductStackBox.TextChanged += textBox1_TextChanged;
            // 
            // addProductPriceBox
            // 
            addProductPriceBox.Location = new Point(454, 134);
            addProductPriceBox.Margin = new Padding(3, 2, 3, 2);
            addProductPriceBox.Name = "addProductPriceBox";
            addProductPriceBox.Size = new Size(176, 23);
            addProductPriceBox.TabIndex = 2;
            addProductPriceBox.TextChanged += textBox1_TextChanged;
            // 
            // addProductAuthorIDBox
            // 
            addProductAuthorIDBox.Location = new Point(454, 88);
            addProductAuthorIDBox.Margin = new Padding(3, 2, 3, 2);
            addProductAuthorIDBox.Name = "addProductAuthorIDBox";
            addProductAuthorIDBox.Size = new Size(176, 23);
            addProductAuthorIDBox.TabIndex = 2;
            addProductAuthorIDBox.TextChanged += textBox1_TextChanged;
            // 
            // addProductNameBox
            // 
            addProductNameBox.Location = new Point(454, 44);
            addProductNameBox.Margin = new Padding(3, 2, 3, 2);
            addProductNameBox.Name = "addProductNameBox";
            addProductNameBox.Size = new Size(176, 23);
            addProductNameBox.TabIndex = 2;
            addProductNameBox.TextChanged += textBox1_TextChanged;
            // 
            // addProductStack
            // 
            addProductStack.AutoSize = true;
            addProductStack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductStack.Location = new Point(285, 182);
            addProductStack.Name = "addProductStack";
            addProductStack.Size = new Size(102, 21);
            addProductStack.TabIndex = 1;
            addProductStack.Text = "تعداد موجودی";
            addProductStack.Click += label1_Click;
            // 
            // addProductPrice
            // 
            addProductPrice.AutoSize = true;
            addProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductPrice.Location = new Point(319, 134);
            addProductPrice.Name = "addProductPrice";
            addProductPrice.Size = new Size(72, 21);
            addProductPrice.TabIndex = 1;
            addProductPrice.Text = "قیمت کالا";
            addProductPrice.Click += label1_Click;
            // 
            // addProductAuthorID
            // 
            addProductAuthorID.AutoSize = true;
            addProductAuthorID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductAuthorID.Location = new Point(304, 88);
            addProductAuthorID.Name = "addProductAuthorID";
            addProductAuthorID.Size = new Size(87, 21);
            addProductAuthorID.TabIndex = 1;
            addProductAuthorID.Text = "آیدی سازنده";
            addProductAuthorID.Click += label1_Click;
            // 
            // addProductName
            // 
            addProductName.AutoSize = true;
            addProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addProductName.Location = new Point(340, 43);
            addProductName.Name = "addProductName";
            addProductName.Size = new Size(53, 21);
            addProductName.TabIndex = 1;
            addProductName.Text = "نام کالا";
            addProductName.Click += label1_Click;
            // 
            // addProductBTN
            // 
            addProductBTN.Location = new Point(374, 288);
            addProductBTN.Margin = new Padding(3, 2, 3, 2);
            addProductBTN.Name = "addProductBTN";
            addProductBTN.Size = new Size(144, 34);
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
            mainTabs.Margin = new Padding(3, 2, 3, 2);
            mainTabs.Name = "mainTabs";
            mainTabs.SelectedIndex = 0;
            mainTabs.Size = new Size(879, 432);
            mainTabs.TabIndex = 0;
            // 
            // ProductsTab
            // 
            ProductsTab.Controls.Add(productsTabs);
            ProductsTab.Location = new Point(4, 24);
            ProductsTab.Margin = new Padding(3, 2, 3, 2);
            ProductsTab.Name = "ProductsTab";
            ProductsTab.Padding = new Padding(3, 2, 3, 2);
            ProductsTab.Size = new Size(871, 404);
            ProductsTab.TabIndex = 0;
            ProductsTab.Text = "محصولات";
            ProductsTab.UseVisualStyleBackColor = true;
            ProductsTab.Click += tabPage1_Click_1;
            // 
            // MakersTab
            // 
            MakersTab.Controls.Add(makersTabs);
            MakersTab.Location = new Point(4, 24);
            MakersTab.Margin = new Padding(3, 2, 3, 2);
            MakersTab.Name = "MakersTab";
            MakersTab.Padding = new Padding(3, 2, 3, 2);
            MakersTab.Size = new Size(871, 404);
            MakersTab.TabIndex = 1;
            MakersTab.Text = "سازندگان";
            MakersTab.UseVisualStyleBackColor = true;
            MakersTab.Click += makersTab_Click;
            // 
            // makersTabs
            // 
            makersTabs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            makersTabs.Controls.Add(tabPage1);
            makersTabs.Controls.Add(addMakerTab);
            makersTabs.Location = new Point(-4, 0);
            makersTabs.Margin = new Padding(3, 2, 3, 2);
            makersTabs.Name = "makersTabs";
            makersTabs.SelectedIndex = 0;
            makersTabs.Size = new Size(871, 403);
            makersTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(makersDGV);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(863, 375);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "نمایش سازندگان";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // makersDGV
            // 
            makersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            makersDGV.Location = new Point(7, 4);
            makersDGV.Margin = new Padding(3, 2, 3, 2);
            makersDGV.Name = "makersDGV";
            makersDGV.RowHeadersWidth = 51;
            makersDGV.RowTemplate.Height = 29;
            makersDGV.Size = new Size(838, 274);
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
            addMakerTab.Location = new Point(4, 24);
            addMakerTab.Margin = new Padding(3, 2, 3, 2);
            addMakerTab.Name = "addMakerTab";
            addMakerTab.Padding = new Padding(3, 2, 3, 2);
            addMakerTab.Size = new Size(863, 375);
            addMakerTab.TabIndex = 1;
            addMakerTab.Text = "اضافه کردن سازنده";
            addMakerTab.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(429, 231);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(176, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, 189);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 23);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(429, 141);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(429, 94);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 23);
            textBox3.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(293, 231);
            label9.Name = "label9";
            label9.Size = new Size(47, 21);
            label9.TabIndex = 4;
            label9.Text = "آدرس";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(429, 50);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 23);
            textBox4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(260, 189);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 4;
            label1.Text = "تلفن تماس";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(283, 139);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 5;
            label2.Text = "کد ملی";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(249, 92);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 6;
            label3.Text = "نام خانوادگی";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 50);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 7;
            label4.Text = "نام";
            // 
            // button1
            // 
            button1.Location = new Point(349, 295);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(144, 34);
            button1.TabIndex = 3;
            button1.Text = "اضافه کردن";
            button1.UseVisualStyleBackColor = true;
            // 
            // ordersTabs
            // 
            ordersTabs.Controls.Add(tabControl1);
            ordersTabs.Location = new Point(4, 24);
            ordersTabs.Margin = new Padding(3, 2, 3, 2);
            ordersTabs.Name = "ordersTabs";
            ordersTabs.Padding = new Padding(3, 2, 3, 2);
            ordersTabs.Size = new Size(871, 404);
            ordersTabs.TabIndex = 2;
            ordersTabs.Text = "سفارشات";
            ordersTabs.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ordersTab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(3, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(927, 432);
            tabControl1.TabIndex = 0;
            // 
            // ordersTab
            // 
            ordersTab.Controls.Add(ordersDGV);
            ordersTab.Location = new Point(4, 24);
            ordersTab.Margin = new Padding(3, 2, 3, 2);
            ordersTab.Name = "ordersTab";
            ordersTab.Padding = new Padding(3, 2, 3, 2);
            ordersTab.Size = new Size(919, 404);
            ordersTab.TabIndex = 0;
            ordersTab.Text = "سفارشات";
            ordersTab.UseVisualStyleBackColor = true;
            // 
            // ordersDGV
            // 
            ordersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDGV.Location = new Point(5, 4);
            ordersDGV.Margin = new Padding(3, 2, 3, 2);
            ordersDGV.Name = "ordersDGV";
            ordersDGV.RowHeadersWidth = 51;
            ordersDGV.RowTemplate.Height = 29;
            ordersDGV.Size = new Size(834, 272);
            ordersDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(addProductsListButton);
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(textBox7);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(button2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(919, 404);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "افزودن سفارش";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // addProductsListButton
            // 
            addProductsListButton.Location = new Point(280, 16);
            addProductsListButton.Name = "addProductsListButton";
            addProductsListButton.Size = new Size(79, 45);
            addProductsListButton.TabIndex = 12;
            addProductsListButton.Text = "اضافه کردن سفارش";
            addProductsListButton.UseVisualStyleBackColor = true;
            addProductsListButton.Click += button3_Click_1;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(628, 249);
            textBox10.Margin = new Padding(3, 2, 3, 2);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(176, 23);
            textBox10.TabIndex = 8;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(628, 207);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(176, 23);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(223, 249);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(176, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(223, 203);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(176, 23);
            textBox7.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(485, 247);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 4;
            label10.Text = "آدرس";
            label10.Click += label10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(459, 207);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 4;
            label5.Text = "تلفن تماس";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 251);
            label6.Name = "label6";
            label6.Size = new Size(91, 21);
            label6.TabIndex = 5;
            label6.Text = "نام خانوادگی";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(61, 205);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 6;
            label7.Text = "نام خریدار";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(61, 26);
            label8.Name = "label8";
            label8.Size = new Size(73, 21);
            label8.TabIndex = 7;
            label8.Text = "سفارشات";
            // 
            // button2
            // 
            button2.Location = new Point(377, 309);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 34);
            button2.TabIndex = 3;
            button2.Text = "اضافه کردن";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(162, 301);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 415);
            Controls.Add(mainTabs);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
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
        private TextBox textBox10;
        private Label label10;
        private Button addProductsListButton;
        private Button button3;
    }
}