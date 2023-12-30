using shop;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.InteropServices;
using System;

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
        private string query = "", Orders = "";
        private const int ProductOrdersListXCONST = 150;
        private int ProductOrdersListNum = 0, ProductOrdersListX = ProductOrdersListXCONST, ProductOrdersListY = 47;

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
                        $"values(\'{Values[0]}\',\'{Values[1]}\',\'{Values[2]}\',\'{Values[3]}\',\'{Values[4]}\');";
                    break;
                case "Makers":
                    query = $"insert into Makers (FirstName, LastName, PhoneNumber, MakerAddress, NationalCode) " +
                        $"values(\'{Values[0]}\',\'{Values[1]}\',\'{Values[2]}\',\'{Values[3]}\',\'{Values[4]}\');";
                    break;
                case "Orders":
                    query = $"insert into Orders (Product_IDs, CustomerFirstName, CustomerLastName, CustomerAddress, CustomerPhone, Status) " +
                        $"values(\'{Values[0]} \',\' {Values[1]} \',\' {Values[2]} \',\' {Values[3]} \',\' {Values[4]}\',\'در انتظار تحویل\');";
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

        internal void update(string TableName, string ID, params string[] Values)
        {
            switch (TableName)
            {
                case "Products":
                    query = $"UPDATE Products SET ProductName = \'{Values[0]}\' , Maker_ID = \'{Values[1]}\' , Price = \'{Values[2]}\' , Stuck = \'{Values[3]}\' , ProductType =  \'{Values[4]}\' WHERE Product_ID = {ID};";
                    break;
                case "Makers":
                    query = $"UPDATE Makers SET FirstName = \'{Values[0]}\', LastName = \'{Values[1]}\', PhoneNumber = \'{Values[2]}\', MakerAddress = \'{Values[3]}\', NationalCode = \'{Values[4]}\' WHERE Maker_ID = {ID};";
                    break;
                case "Orders":
                    query = $"UPDATE Orders SET Status = \'{Values[0]}\' WHERE Order_ID = {ID};";
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
                    query = $"select * from Products";
                    dataSet2.Clear();
                    myCommand2.CommandText = query;
                    myCommand2.Connection = connection;
                    adapter2.SelectCommand = myCommand2;
                    adapter2.Fill(dataSet2, "Products");
                    productsDGV.DataSource = dataSet2.Tables[0].DefaultView;
                    productsDGV.Refresh();
                    break;
                case "Makers":
                    query = $"select * from Makers";
                    dataSet1.Clear();
                    myCommand1.CommandText = query;
                    myCommand1.Connection = connection;
                    adapter1.SelectCommand = myCommand1;
                    adapter1.Fill(dataSet1, "Makers");
                    makersDGV.DataSource = dataSet1.Tables[0].DefaultView;
                    makersDGV.Refresh();
                    break;
                case "Orders":
                    query = $"select * from Orders";
                    dataSet3.Clear();
                    myCommand3.CommandText = query;
                    myCommand3.Connection = connection;
                    adapter3.SelectCommand = myCommand3;
                    adapter3.Fill(dataSet3, "Orders");
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
            dgv.BackgroundColor = Color.LightGray;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv.AllowUserToResizeColumns = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv.RowHeadersDefaultCellStyle.BackColor = Color.Black;
            dgv.CellFormatting += new
            DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
        }

        private List<string> getValueOfCurrectCell(DataGridView dgv)
        {
            List<string> Values = new List<string>();
            if (dgv.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];
                for (int i = 0; i < selectedRow.Cells.Count; i++)

                    Values.Add(Convert.ToString(selectedRow.Cells[i].Value));
            }
            else
            {
                MessageBox.Show("لیست شما اطلاعاتی ندارد", "لیست خالی است", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
            return Values;
        }

        //int selectedrowindex = dgv.SelectedCells[0].RowIndex;DataGridViewRow selectedRow = dgv.Rows[selectedrowindex];
        private void button3_Click(object sender, EventArgs e)
        {
            show("Products");
        }

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
        //delete("Products", int.Parse(getValueOfCurrectCell(productsDGV)[0])); show("Products");

        private void Productdelbtn_Click(object sender, EventArgs e)
        {
            delete("Products", int.Parse(getValueOfCurrectCell(productsDGV)[0]));
            show("Products");
        }

        private void Makerdelbtn_Click(object sender, EventArgs e)
        {
            delete("Makers", int.Parse(getValueOfCurrectCell(makersDGV)[0]));
            show("Makers");
        }

        private void Orderdelbtn_Click(object sender, EventArgs e)
        {
            delete("Orders", int.Parse(getValueOfCurrectCell(ordersDGV)[0]));
            show("Orders");
        }

        private string[] showForm(string[] inputs, List<string> inputsText, [Optional] Action<string[]> funk)
        {
            string[] outputs = [];
            void editExit(string[] edited)
            {
                outputs = edited;
                funk(outputs);
            }

            editForm productsEdit = new editForm(inputs, editExit, inputsText);

            productsEdit.Show();

            return outputs;
        }

        private void AddBuyerNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //string[] inputs = ["نام کالا", "آیدی سازنده", "قیمت کالا", "تعداد موجودی", "نوع محصول"];
        //List<string> inputsTexts = getValueOfCurrectCell(productsDGV);
        //void funk(string[] outputs)
        //{
        //    update("Products", inputsTexts[0], outputs);
        //    show("Products");
        //}

        //showForm(inputs, inputsTexts.GetRange(1, 5), funk);
        //}
        private void productsEditBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام کالا", "آیدی سازنده", "قیمت کالا", "تعداد موجودی", "نوع محصول"];
            List<string> inputsTexts = getValueOfCurrectCell(productsDGV);
            void funk(string[] outputs)
            {
                update("Products", inputsTexts[0], outputs);
                show("Products");
            }

            showForm(inputs, inputsTexts.GetRange(1, 5), funk);
        }

        private void addProductsBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام کالا", "آیدی سازنده", "قیمت کالا", "تعداد موجودی", "نوع محصول"];

            void funk(string[] outputs)
            {
                add("Products", outputs);
                show("Products");
            }

            showForm(inputs, [], funk);
        }

        private void makersEditBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام", "نام خانوادگی", "تلفن تماس", "آدرس", "کد ملی"];
            List<string> inputsTexts = getValueOfCurrectCell(makersDGV);
            void funk(string[] outputs)
            {
                update("Makers", inputsTexts[0], outputs);
                show("Makers");
            }

            showForm(inputs, inputsTexts.GetRange(1, 5), funk);
        }

        private void MakersAddBTN_Click(object sender, EventArgs e)
        {
            string[] inputs = ["نام", "نام خانوادگی", "تلفن تماس", "آدرس", "کد ملی"];
            void funk(string[] outputs)
            {
                add("Makers", outputs);
                show("Makers");
            }

            showForm(inputs, [], funk);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void TahvilIsOk_Click(object sender, EventArgs e)
        {
            update("Orders", getValueOfCurrectCell(ordersDGV)[0], ["تحویل داده شد"]);
            show("Orders");
        }
    }
}