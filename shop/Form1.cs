using shop;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Collections.Generic;


namespace shop
{
    public partial class Form1 : Form
    {


        private int ProductOrdersListNum = 0;
        private int ProductOrdersListX = 163;
        private int ProductOrdersListY = 34;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainTabs.Size = this.Size;
            ShowMakers();
            ShowOrders();
            ShowProducts();

            createAddOrder();
        }

        private List<string> test = new List<string>();

        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Shopdb.accdb;Persist Security Info=False");
        private OleDbCommand myCommand1 = new OleDbCommand(), myCommand2 = new OleDbCommand(), myCommand3 = new OleDbCommand();
        private OleDbDataAdapter adapter1 = new OleDbDataAdapter(), adapter2 = new OleDbDataAdapter(), adapter3 = new OleDbDataAdapter();
        private DataSet dataSet1 = new DataSet(), dataSet2 = new DataSet(), dataSet3 = new DataSet();
        private List<ComboBox> orderBoxes = new List<ComboBox>();
        string last_se, Orders = "";
        internal void AddMaker(string FirstName, string LastName, string PhoneNumber, string MakerAddress, string NationalCode)
        {

            connection.Open();
            string query = $"insert into Makers (FirstName, LastName, PhoneNumber, MakerAddress, NationalCode) values(\'{FirstName}\',\'{LastName}\',\'{PhoneNumber}\','{MakerAddress}','{NationalCode}');";

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            myCommand1.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowMakers()
        {
            connection.Open();
            string query = $"select * from Makers;";

            dataSet1.Clear();
            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            adapter1.SelectCommand = myCommand1;
            adapter1.Fill(dataSet1, "Makers");
            makersDGV.DataSource = dataSet1.Tables[0].DefaultView;
            makersDGV.Refresh();

            connection.Close();
        }
        internal void DeleteMaker(int ID)
        {

            connection.Open();
            string query = $"DELETE FROM Makers WHERE Maker_ID = {ID};";

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            myCommand1.ExecuteNonQuery();

            connection.Close();
        }
        internal void AddProduct(string ProductName, int Maker_ID, int Price, int Stuck, string ProductType)
        {
            connection.Open();
            string query = $"insert into Products (ProductName ,Maker_ID, Price, Stuck, ProductType) values('{ProductName}','{Maker_ID}','{Price}','{Stuck}','{ProductType}');";

            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            myCommand2.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowProducts()
        {
            connection.Open();
            string query = $"select * from Products;";

            dataSet2.Clear();
            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            adapter2.SelectCommand = myCommand2;
            adapter2.Fill(dataSet2, "Products");
            productsDGV.DataSource = dataSet2.Tables[0].DefaultView;
            productsDGV.Refresh();

            connection.Close();
        }
        internal void DeleteProduct(int ID)
        {

            connection.Open();
            string query = $"DELETE FROM Products WHERE Product_ID = {ID};";

            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            myCommand2.ExecuteNonQuery();

            connection.Close();
        }
        internal void AddOrder(string Product_IDs, string CustomerFirstName, string CustomerLastName, string CustomerAddress, string CustomerPhone)
        {
            connection.Open();
            string query = $"insert into Orders (Product_IDs, CustomerFirstName, CustomerLastName, CustomerAddress, CustomerPhone) values(\'{Product_IDs}\',\'{CustomerFirstName}\',\'{CustomerLastName}\',\'{CustomerAddress}\',\'{CustomerPhone}');";

            myCommand3.CommandText = query;
            myCommand3.Connection = connection;
            myCommand3.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowOrders()
        {
            connection.Open();
            string query = $"select * from Orders;";

            dataSet3.Clear();
            myCommand3.CommandText = query;
            myCommand3.Connection = connection;
            adapter3.SelectCommand = myCommand3;
            adapter3.Fill(dataSet3, "Orders");
            ordersDGV.DataSource = dataSet3.Tables[0].DefaultView;
            ordersDGV.Refresh();

            connection.Close();
        }
        internal void DeleteOrder(int ID)
        {

            connection.Open();
            string query = $"DELETE FROM Orders WHERE Order_ID = {ID};";

            myCommand3.CommandText = query;
            myCommand3.Connection = connection;
            myCommand3.ExecuteNonQuery();

            connection.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
            string productName = addProductNameBox.Text;
            addProductNameBox.Text = "";
            ShowProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            cb.Location = new Point(163, 34);
            cb.Size = new Size(151, 28);
            cb.Name = "cb1";
            Orders = "";
            foreach (ComboBox order in orderBoxes)
            {
                Orders += order.Text + " , ";
            }

            if (AddBuyerAddressTextBox.Text != "" && AddbuyerFirsTextBox.Text != "" && AddBuyerLastTextBox.Text != "" && AddBuyerNumTextBox.Text != "")
            {
                AddOrder(Orders, AddbuyerFirsTextBox.Text, AddBuyerLastTextBox.Text, AddBuyerAddressTextBox.Text, AddBuyerNumTextBox.Text);
                AddbuyerFirsTextBox.Text = ""; AddBuyerLastTextBox.Text = ""; AddBuyerAddressTextBox.Text = ""; AddBuyerNumTextBox.Text = "";
            }
            for (int i = 0; i < ProductOrdersListNum; i++)
            {
            }
            foreach (var item in orderBoxes)
            {
                tabPage3.Controls.Remove(item);
            }
            ProductOrdersListNum = 0;
            ProductOrdersListX = 163;
            ProductOrdersListY = 34;
            addProductsListButton.Location = new Point(320, 21);
            ShowOrders();
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
                ProductOrdersListX = 163;
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
            cb.Size = new Size(151, 28);
            cb.Name = "ProductOrdersList" + ProductOrdersListNum++.ToString();
            cb.DataSource = cbdata;
            orderBoxes.Add(cb);
            tabPage3.Controls.Add(cb);
            ProductOrdersListX += 175;
            addProductsListButton.Location = new Point(ProductOrdersListX + 5, ProductOrdersListY - 10);

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
                last_se = Convert.ToString(selectedRow.Cells[0].Value);
                DeleteProduct(int.Parse(last_se));
                ShowProducts();
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
                last_se = Convert.ToString(selectedRow.Cells[0].Value);
                DeleteMaker(int.Parse(last_se));
                ShowMakers();
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
                last_se = Convert.ToString(selectedRow.Cells[0].Value);
                DeleteOrder(int.Parse(last_se));
                ShowOrders();
            }
            else
            {
                MessageBox.Show("لیست شما اطلاعاتی ندارد", "لیست خالی است", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}