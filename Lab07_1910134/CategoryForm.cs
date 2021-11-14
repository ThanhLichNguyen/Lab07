using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_1910134
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=ADMIN;Initial Catalog=RestaurantManagement;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "EXECUTE InsertCategory @id OUTPUT, @name, @type";

                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);

                cmd.Parameters["@id"].Direction = ParameterDirection.Output;

                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@type"].Value = txtType.Text;

                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();

                if (numRowAffected > 0)
                {
                    string categoryId = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm nhóm món ăn thành công, Mã nhóm món ăn = " + categoryId, "Message");
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Lỗi thêm món ăn");
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
