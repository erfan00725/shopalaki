using shop;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;


namespace shop
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Shopdb.accdb;Persist Security Info=False");
        private OleDbCommand myCommand1 = new OleDbCommand(), myCommand2 = new OleDbCommand(), myCommand3 = new OleDbCommand();
        private OleDbDataAdapter adapter1 = new OleDbDataAdapter(), adapter2 = new OleDbDataAdapter(), adapter3 = new OleDbDataAdapter();
        private DataSet dataSet1 = new DataSet(), dataSet2 = new DataSet(), dataSet3 = new DataSet();


        private List<ComboBox> orderBoxes = new List<ComboBox>();
        private string query = "", SelectedRowID, Orders = "";
        private const int ProductOrdersListXCONST = 150;
        private int ProductOrdersListNum = 0, ProductOrdersListX = ProductOrdersListXCONST, ProductOrdersListY = 34;

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTabs.Size = this.Size;
            InitializeDataGridView(productsDGV);
            InitializeDataGridView(makersDGV);
            InitializeDataGridView(ordersDGV);

            show("Products");
            show("Makers");
            show("Orders");
            createAddOrder();
        }
        internal void add(string TableName, params string[] Values)
        {
            switch (TableName)
            {
                case "Products":
                    query = $"insert into Products (ProductName ,Maker_ID, Price, Stuck, ProductType) " +
                        $"values('{Values[0]}','{Values[1]}','{Values[2]}','{Values[3]}','{Values[4]}');";
                    break;
                case "Makers":
                    query = $"insert into Makers (FirstName, LastName, PhoneNumber, MakerAddress, NationalCode) " +
                        $"values(\'{Values[0]}','{Values[1]}','{Values[2]}','{Values[3]}','{Values[4]}');";
                    break;
                case "Orders":
                    query = $"insert into Orders (Product_IDs, CustomerFirstName, CustomerLastName, CustomerAddress, CustomerPhone) " +
                        $"values(\'{Values[0]} \',\' {Values[1]} \',\' {Values[2]} \',\' {Values[3]} \',\' {Values[4]}');";
                    break;
                default:
                    break;
            }

            connection.Open();

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            myCommand1.ExecuteNonQuery();

            connection.Close();
        }
        internal void delete(string TableName, int ID)
        {
            switch (TableName)
            {
                case "Products":
                    query = $"DELETE FROM Products WHERE Product_ID = {ID};";
                    break;
                case "Makers":
                    query = $"DELETE FROM Makers WHERE Maker_ID = {ID};";
                    break;
                case "Orders":
                    query = $"DELETE FROM Orders WHERE Order_ID = {ID};";
                    break;
                default:
                    break;
            }

            connection.Open();

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            myCommand1.ExecuteNonQuery();

            connection.Close();
        }
        internal void show(string TableName)
        {
            connection.Open();

            switch (TableName)
            {
                case "Products":
                    query = $"select Product_ID, ProductName, Maker_ID, Price, Stuck, ProductType from {TableName}";
                    dataSet2.Clear();
                    myCommand2.CommandText = query;
                    myCommand2.Connection = connection;
                    adapter2.SelectCommand = myCommand2;
                    adapter2.Fill(dataSet2, TableName);
                    productsDGV.DataSource = dataSet2.Tables[0].DefaultView;
                    productsDGV.Refresh();
                    break;
                case "Makers":
                    query = $"select * from {TableName}";
                    dataSet1.Clear();
                    myCommand1.CommandText = query;
                    myCommand1.Connection = connection;
                    adapter1.SelectCommand = myCommand1;
                    adapter1.Fill(dataSet1, TableName);
                    makersDGV.DataSource = dataSet1.Tables[0].DefaultView;
                    makersDGV.Refresh();
                    break;
                case "Orders":
                    query = $"select * from {TableName}";
                    dataSet3.Clear();
                    myCommand3.CommandText = query;
                    myCommand3.Connection = connection;
                    adapter3.SelectCommand = myCommand3;
                    adapter3.Fill(dataSet3, TableName);
                    ordersDGV.DataSource = dataSet3.Tables[0].DefaultView;
                    ordersDGV.Refresh();
                    break;
                default:
                    break;
            }

            connection.Close();
        }


        private void createAddOrder()
        {
            if (ProductOrdersListNum == 12)
            {
                return;
            }
            else if (ProductOrdersListNum % 4 == 0 && ProductOrdersListNum != 0)
            {
                ProductOrdersListY = ProductOrdersListY + 50;
                ProductOrdersListX = ProductOrdersListXCONST;
            }
            connection.Open();
            string query = $"select * from Products;";

            dataSet2.Clear();
            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            adapter2.SelectCommand = myCommand2;
            adapter2.Fill(dataSet2, "Products");
            connection.Close();

            List<string> cbdata = new List<string>();

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    cbdata.Add(dataSet2.Tables[0].Rows[i][1].ToString());

                }
                catch
                {
                    break;
                }
            }


            ComboBox cb = new ComboBox();
            cb.Location = new Point(ProductOrdersListX, ProductOrdersListY);
            cb.Size = new Size(145, 28);
            cb.Name = "ProductOrdersList" + ProductOrdersListNum++.ToString();
            cb.DataSource = cbdata;
            orderBoxes.Add(cb);
            tabPage3.Controls.Add(cb);
            ProductOrdersListX += 150;
            addProductsListButton.Location = new Point(ProductOrdersListX + 5, ProductOrdersListY - 10);

        }
        private void InitializeDataGridView(DataGridView dgv)
        {
            // Initialize basic DataGridView properties.
            dgv.Dock = DockStyle.Fill;
            dgv.BackgroundColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.Fixed3D;

            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeColumns = false;
            dgv.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersWidthSizeMode =
                DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Set the selection background color for all the cells.
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dgv.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;

            // Set the row and column header styles.
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            // Attach a handler to the CellFormatting event.
            dgv.CellFormatting += new
                DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            show("Products");
        }

        //private void addProductBTN_Click(object sender, EventArgs e)
        //{
        //    string productName = addProductNameBox.Text, productMakerID = addProductAuthorIDBox.Text, productPrice = addProductPriceBox.Text, productStack = addProductStackBox.Text, productType = "";
        //    add("Products", productName, productMakerID, productPrice, productPrice, productType);
        //    addProductNameBox.Text = ""; addProductAuthorIDBox.Text = ""; addProductPriceBox.Text = ""; addProductStackBox.Text = "";
        //    show("Products");
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ComboBox order in orderBoxes)
            {
                Orders += order.Text + " , ";
            }

            if (AddBuyerAddressTextBox.Text != "" && AddbuyerFirsTextBox.Text != "" && AddBuyerLastTextBox.Text != "" && AddBuyerNumTextBox.Text != "")
            {
                add("Orders", Orders, AddbuyerFirsTextBox.Text, AddBuyerLastTextBox.Text, AddBuyerAddressTextBox.Text, AddBuyerNumTextBox.Text);
                AddbuyerFirsTextBox.Text = ""; AddBuyerLastTextBox.Text = ""; AddBuyerAddressTextBox.Text = ""; AddBuyerNumTextBox.Text = "";
                ProductOrdersListNum = 0;
                ProductOrdersListX = ProductOrdersListXCONST;
                ProductOrdersListY = 34;
                Orders = "";
            }
            foreach (var item in orderBoxes)
            {
                tabPage3.Controls.Remove(item);
            }

            createAddOrder();
            show("Orders");
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            createAddOrder();
        }


        private void Productdelbtn_Click(object sender, EventArgs e)
        {
            if (productsDGV.SelectedCells.Count > 0)
            {
                int selectedrowindex = productsDGV.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = productsDGV.Rows[selectedrowindex];
                SelectedRowID = Convert.ToString(selectedRow.Cells[0].Value);
                delete("Products", int.Parse(SelectedRowID));
                show("Products");
            }
            else
            {
                MessageBox.Show("لیست شما اطلاعاتی ندارد", "لیست خالی است", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void Makerdelbtn_Click(object sender, EventArgs e)
        {
            if (productsDGV.SelectedCells.Count > 0)
            {
                int selectedrowindex = productsDGV.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = makersDGV.Rows[selectedrowindex];
                SelectedRowID = Convert.ToString(selectedRow.Cells[0].Value);
                delete("Makers", int.Parse(SelectedRowID));
                show("Makers");
            }
            else
            {
                MessageBox.Show("لیست شما اطلاعاتی ندارد", "لیست خالی است", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void Orderdelbtn_Click(object sender, EventArgs e)
        {

            if (productsDGV.SelectedCells.Count > 0)
            {
                int selectedrowindex = ordersDGV.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = ordersDGV.Rows[selectedrowindex];
                SelectedRowID = Convert.ToString(selectedRow.Cells[0].Value);
                delete("Orders", int.Parse(SelectedRowID));
                show("Orders");
            }
            else
            {
                MessageBox.Show("لیست شما اطلاعاتی ندارد", "لیست خالی است", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private string[] showForm(string[] inputs, string[]? inputsText)
        {
            string[] outputs = [];
            void editExit(string[] edited)
            {
                outputs = edited;
            }

            editForm productsEdit = new editForm(inputs, editExit, inputsText);

            productsEdit.Show();

            return outputs;
        }

        private void productsEditBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام کالا", "آیدی سازنده", "قیمت کالا", "تعداد موجودی"];

            showForm(inputs, []);
        }

        private void AddBuyerNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addProductsBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام کالا", "آیدی سازنده", "قیمت کالا", "تعداد موجودی"];

            showForm(inputs, []);
        }

        private void makersEditBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام", "نام خانوادگی", "کد ملی", "تلفن تماس", "آدرس"];

            showForm(inputs, []);
        }

        private void MakersAddBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام", "نام خانوادگی", "کد ملی", "تلفن تماس", "آدرس"];

            showForm(inputs, []);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}