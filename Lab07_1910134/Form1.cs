using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab07_1910134.DTO;


namespace Lab07_1910134
{
    public partial class Form1 : Form


    {

        private DataTable foodTable;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadTable();
            this.LoadCategory();
            this.LoadCategory1();
            this.LoadAccound();
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);
        }


        private void LoadCategory()
        {
            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);

            conn.Close();
            conn.Dispose();

            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";

        }

        private void LoadCategory1()
        {
            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name FROM Category";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);

            conn.Close();
            conn.Dispose();

            cbbCategory1.DataSource = dt;
            cbbCategory1.DisplayMember = "Name";
            cbbCategory1.ValueMember = "ID";
        }

        void LoadTable()
        {
            List<Table> tableList = new List<Table>();

            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID, Name, Status, Capacity FROM LstTable";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);

            conn.Close();
            conn.Dispose();

            foreach (DataRow item in dt.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 90, Height = 90 };
                string tt = item.Status == 0 ? "Trống" : "Đang phục vụ";
                btn.Text = item.Name + Environment.NewLine + tt;
                btn.Click += Btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case 0:
                        btn.BackColor = Color.LightSteelBlue;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        break;
                    default:
                        btn.BackColor = Color.Thistle;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderSize = 0;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {

            lvBills.Items.Clear();
            List<Menu> listBillInfo = GetListMenuByTable(id);

            int amount = 0;

            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Amount.ToString());
                amount += item.Amount;

                lvBills.Items.Add(lsvItem);
            }

            txtAmount.Text = amount.ToString() + " vnđ";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();


            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT f.Name, bd.Quantity, f.Price,f.Price * bd.Quantity AS Amount FROM dbo.BillDetails AS bd, dbo.Bills AS b, dbo.Food AS f WHERE bd.InvoiceID = b.id AND bd.FoodID = f.id AND b.Status = 1 AND b.TableID = " + id;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);

            conn.Close();
            conn.Dispose();


            foreach (DataRow item in dt.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == 1) return;

            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from Food where FoodCategoryID = @categoryID ";
            cmd.Parameters.Add("@categoryId", SqlDbType.Int);


            if (cbbCategory.SelectedValue is DataRowView)
            {

                DataRowView rowView = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            conn.Open();
            adapter.Fill(dt);

            conn.Close();
            conn.Dispose();

            cbbFood.DataSource = dt;
            cbbFood.DisplayMember = "Name";

            
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
             
        }

        private void cbbCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory1.SelectedIndex == 1) return;

            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";

            cmd.Parameters.Add("@categoryId", SqlDbType.Int);

            if (cbbCategory1.SelectedValue is DataRowView)
            {
                DataRowView rowView = cbbCategory1.SelectedValue as DataRowView;
                cmd.Parameters["@categoryId"].Value = rowView["ID"];
            }
            else
            {
                cmd.Parameters["@categoryId"].Value = cbbCategory1.SelectedValue;
            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable = new DataTable();

            conn.Open();

            adapter.Fill(foodTable);

            conn.Close();
            conn.Dispose();

            dgvFoodList.DataSource = foodTable;
            lblQuantity.Text = foodTable.Rows.Count.ToString();
            lblCatName.Text = cbbCategory1.Text;
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;

            string filterExperession = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

            DataView foodView = new DataView(foodTable, filterExperession, sortExpression, rowStateFilter);
            dgvFoodList.DataSource = foodView;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                cmd.Parameters.Add("@foodId", SqlDbType.Int);
                cmd.Parameters["@foodId"].Value = rowView["ID"];

                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

                conn.Open();

                cmd.ExecuteNonQuery();

                string result = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show("Tổng số lượng món " + rowView["Name"] + " đã bán là: " + result + " " + rowView["Unit"]);

                conn.Close();
            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm foodForm = new FoodInfoForm();
            foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

            foodForm.Show(this);
        }

        private void foodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory1.SelectedIndex;
            cbbCategory1.SelectedIndex = 1;
            cbbCategory1.SelectedIndex = index;
        }

        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                FoodInfoForm foodForm = new FoodInfoForm();
                foodForm.FormClosed += new FormClosedEventHandler(foodForm_FormClosed);

                foodForm.Show(this);
                foodForm.DisplayFoodInfo(rowView);
            }
        }

        public void LoadAccound()
        {
            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM Account";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Account");

            adapter.Fill(dt);

            dgvAccount.DataSource = dt;

            conn.Close();
            conn.Dispose();
            adapter.Dispose();
        }


        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertAccount @AccountName, @Password, @FullName, @Email, @Tell, @DateCreated";

                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@DateCreated", SqlDbType.DateTime);

                cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
                cmd.Parameters["@Password"].Value = "12345";
                cmd.Parameters["@FullName"].Value = txtFullName.Text;
                cmd.Parameters["@Email"].Value = txtEmail.Text;
                cmd.Parameters["@Tell"].Value = mtbTell.Text;
                cmd.Parameters["@DateCreated"].Value = dtpDateCreated.Value;

                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {

                    MessageBox.Show("Tạo tài khoản thành công", "Message");
                    this.LoadAccound();

                }
                else
                {
                    MessageBox.Show("Lỗi tạo tài khoản");
                }

                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE UpdateAccount @AccountName, @Password, @FullName, @Email, @Tell, @DateCreated";

                cmd.Parameters.Add("@AccountName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@DateCreated", SqlDbType.DateTime);


                cmd.Parameters["@AccountName"].Value = txtAccountName.Text;
                cmd.Parameters["@Password"].Value = txtPassword.Text;
                cmd.Parameters["@FullName"].Value = txtFullName.Text;
                cmd.Parameters["@Email"].Value = txtEmail.Text;
                cmd.Parameters["@Tell"].Value = mtbTell.Text;
                cmd.Parameters["@DateCreated"].Value = dtpDateCreated.Value;


                conn.Open();

                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công", "Message");

                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Lỗi cập nhật tài khoản");
                }

                conn.Close();
                conn.Dispose();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "SQL Error");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void dgvAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAccountName.Text = dgvAccount[0, e.RowIndex].Value.ToString();
            txtPassword.Text = dgvAccount[1, e.RowIndex].Value.ToString();
            txtFullName.Text = dgvAccount[2, e.RowIndex].Value.ToString();
            txtEmail.Text = dgvAccount[3, e.RowIndex].Value.ToString();
            mtbTell.Text = dgvAccount[4, e.RowIndex].Value.ToString();

            DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];
            if (row.Cells[5].Value == DBNull.Value)
            {
                dtpDateCreated.Value = DateTime.Now;
            }
            else
            {
                dtpDateCreated.Value = (DateTime)dgvAccount[5, e.RowIndex].Value;
            }
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime fromDate, DateTime toDate)
        {
            string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "execute USP_GetListBillByDate @fromDate, @toDate";
            cmd.Parameters.Add("@fromDate", SqlDbType.DateTime);
            cmd.Parameters.Add("@toDate", SqlDbType.DateTime);

            cmd.Parameters["@fromDate"].Value = fromDate;
            cmd.Parameters["@toDate"].Value = toDate;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            conn.Open();

            adapter.Fill(dt);

            dgvBill.DataSource = dt;

            conn.Close();
            conn.Dispose();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        private void tsmRemoveFood_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();



            sqlCommand.CommandText = "DELETE FROM Food " + "WHERE ID = " + dgvFoodList.CurrentRow.Cells["ID"].Value.ToString();
            sqlConnection.Open();

            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            if (numOfRowsEffected == 1)
            {
                foreach (DataGridViewRow item in this.dgvFoodList.SelectedRows)
                {

                    dgvFoodList.Rows.RemoveAt(this.dgvFoodList.SelectedRows[0].Index);

                    MessageBox.Show("Xóa nhóm món ăn thành công");
                }


            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
            }
        }
    }
    
    
}

