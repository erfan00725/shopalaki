using shop;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTabs.Size = this.Size;
            ShowMadadju();
            ShowOrders();
            ShowProducts();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
        private class Products
        {
            public string name { get; set; }
            public int price { get; set; }
            public int ID { get; set; }
            public int stack { get; set; }
            public Products(string name, int price, int ID, int stack)
            {
                this.name = name;
                this.price = price;
                this.ID = ID;
                this.stack = stack;
            }
        }
        Products[] pro = new Products[] { new Products("mast", 5000, 1, 10), new Products("khiar", 20000, 1, 30), new Products("noon", 2000, 1, 230), new Products("dogh", 12000, 1, 52) };

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (var item in pro)
            {
                MessageBox.Show(item.name);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void makersTab_Click(object sender, EventArgs e)
        {

        }

        private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Shopdb.accdb;Persist Security Info=False");
        private OleDbCommand myCommand1 = new OleDbCommand(), myCommand2 = new OleDbCommand(), myCommand3 = new OleDbCommand();
        private OleDbDataAdapter adapter1 = new OleDbDataAdapter(), adapter2 = new OleDbDataAdapter(), adapter3 = new OleDbDataAdapter();
        private DataSet dataSet1 = new DataSet(), dataSet2 = new DataSet(), dataSet3 = new DataSet();
        internal void AddMadadju(string FirstName, string LastName, string Address, string PhoneNumber)
        {
            connection.Open();
            string query = $"insert into Madadjuyan (FirstName, LastName, Address, PhoneNumber) values(\'{FirstName}\',\'{LastName}\',\'{Address}\',\'{PhoneNumber}\');";

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            myCommand1.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowMadadju()
        {
            connection.Open();
            string query = $"select * from Madadjuyan;";

            myCommand1.CommandText = query;
            myCommand1.Connection = connection;
            adapter1.SelectCommand = myCommand1;
            adapter1.Fill(dataSet1, "Madadjuyan");
            makersDGV.DataSource = dataSet1.Tables[0].DefaultView;

            connection.Close();
        }
        internal void AddProduct(string ProductName)
        {
            connection.Open();
            string query = $"insert into Products (ProductName) values(\'{ProductName}\');";

            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            myCommand2.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowProducts()
        {
            connection.Open();
            string query = $"select * from Products;";

            myCommand2.CommandText = query;
            myCommand2.Connection = connection;
            adapter2.SelectCommand = myCommand2;
            adapter2.Fill(dataSet2, "Products");
            productsDGV.DataSource = dataSet2.Tables[0].DefaultView;

            connection.Close();
        }
        internal void AddOrder(string CustomerFirstName, string CustomerLastName)
        {
            connection.Open();
            string query = $"insert into Orders (CustomerFirstName, CustomerLastName) values(\'{CustomerFirstName}\',\'{CustomerLastName}\');";

            myCommand3.CommandText = query;
            myCommand3.Connection = connection;
            myCommand3.ExecuteNonQuery();

            connection.Close();
        }
        internal void ShowOrders()
        {
            connection.Open();
            string query = $"select * from Orders;";

            myCommand3.CommandText = query;
            myCommand3.Connection = connection;
            adapter3.SelectCommand = myCommand3;
            adapter3.Fill(dataSet3, "Orders");
            ordersDGV.DataSource = dataSet3.Tables[0].DefaultView;

            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowProducts();
        }

        private void addProductBTN_Click(object sender, EventArgs e)
        {
            string productName = addProductNameBox.Text;
            AddProduct(productName);
            addProductNameBox.Text = "";
            productsDGV.Columns.Clear();
            ShowProducts();
        }

        private void productsTabs_Click(object sender, EventArgs e)
        {
        }
    }
}