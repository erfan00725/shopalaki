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
        private int ProductOrdersListX = 142;
        private int ProductOrdersListY = 26;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainTabs.Size = this.Size;
            ShowMakers();
            ShowOrders();
            ShowProducts();

            createAddOrder();
        }
        private void tabPage1_Click_1(object sender, EventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void button1_Click_2(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void tabPage4_Click(object sender, EventArgs e) { }
        private void tabPage5_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void makersTab_Click(object sender, EventArgs e) { }

        private List<string> test = new List<string>();

        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Shopdb.accdb;Persist Security Info=False");
        private OleDbCommand myCommand1 = new OleDbCommand(), myCommand2 = new OleDbCommand(), myCommand3 = new OleDbCommand();
        private OleDbDataAdapter adapter1 = new OleDbDataAdapter(), adapter2 = new OleDbDataAdapter(), adapter3 = new OleDbDataAdapter();
        private DataSet dataSet1 = new DataSet(), dataSet2 = new DataSet(), dataSet3 = new DataSet();
        private List<ComboBox> orderBoxes = new List<ComboBox>();
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
        internal void AddOrder(string Product_IDs, string CustomerFirstName, string CustomerLastName, string CustomerAddress, string CustomerPhone)
        {
            connection.Open();
            string query = $"insert into Orders (Product_IDs, CustomerFirstName, CustomerLastName, CustomerAddress, CustomerPhone) values('{Product_IDs}''{CustomerFirstName}','{CustomerLastName}','{CustomerAddress}','{CustomerPhone}');";

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

        private void productsTabs_Click(object sender, EventArgs e)
        {
        }
        string Orders = "";
        private void button2_Click(object sender, EventArgs e)
        {
            ComboBox cb = new ComboBox();
            cb.Location = new Point(100, 100);
            cb.Size = new Size(100, 20);
            cb.Name = "cb1";
            Orders = "";
            foreach (ComboBox order in orderBoxes)
            {
                Orders += order.Text;
            }

            AddOrder(Orders,);
            tabPage3.Controls.Add(cb);
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void createAddOrder()
        {
            if (ProductOrdersListNum == 12)
            {
                return;
            }
            else if (ProductOrdersListNum % 4 == 0 && ProductOrdersListNum != 0)
            {
                ProductOrdersListY = ProductOrdersListY + 50;
                ProductOrdersListX = 142;
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
            cb.Size = new Size(121, 23);
            cb.Name = "ProductOrdersList" + ProductOrdersListNum++.ToString();
            cb.DataSource = cbdata;
            orderBoxes.Add(cb);
            tabPage3.Controls.Add(cb);
            ProductOrdersListX += 150;
            addProductsListButton.Location = new Point(ProductOrdersListX + 5, ProductOrdersListY - 10);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            createAddOrder();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
        }
    }
}