using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }
        //++++++++++++++++++++++++++++++++ Method And Variable +++++++++++++++++++++++++++++++++++++++++++++++++

        //Connection DB string============================
        private static string connectionString = "Server=tarasato.thddns.net,1433;Database=library_management_db;User Id=LMS;Password=Sql1433;";  

        //Create variable collect Movie and Director Image in data type ( byte[] ) for store in DB type image
        byte[] bookImage;

        //Method Show Warning MSG=========================
        public static void showWarningMSG(string msg)
        {
            MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Method Get all from book_tb ====================
        private void LoadData()
        {
            lsBookList.Items.Clear(); // ล้างรายการก่อนโหลดข้อมูลใหม่

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book_tb";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString()); // ISBN
                        item.SubItems.Add(reader["bookName"].ToString()); // ชื่อหนังสือ
                        item.SubItems.Add(reader["bookTypeId"].ToString()); // ประเภทหนังสือ
                        item.SubItems.Add(reader["bookQuantity"].ToString()); // จำนวนทั้งหมด
                        item.SubItems.Add(reader["bookAvailable"].ToString()); // จำนวนคงเหลือ

                        item.Tag = reader["iSbn"].ToString(); // เก็บ iSbn ไว้ใน Tag
                        lsBookList.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }
        //Method Search by ISBN=========================== 
        private void SearchByISBN(string iSbn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // คำสั่ง SQL ดึงข้อมูลเฉพาะคอลัมน์ที่ต้องการ
                    string query = "SELECT * FROM book_tb WHERE iSbn = @iSbn";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@iSbn", iSbn);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // สร้าง ListViewItem และเพิ่มข้อมูลแต่ละคอลัมน์
                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString()); // ISBN
                        item.SubItems.Add(reader["bookName"].ToString()); // ชื่อหนังสือ
                        item.SubItems.Add(reader["bookTypeId"].ToString()); // ประเภทหนังสือ
                        item.SubItems.Add(reader["bookQuantity"].ToString()); // จำนวนทั้งหมด
                        item.SubItems.Add(reader["bookAvailable"].ToString()); // จำนวนคงเหลือ

                        item.Tag = reader["iSbn"].ToString(); // เก็บ iSbn ไว้ใน Tag
                        lsBookList.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบตัวเลขISBNของหนังสือที่ค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
            }
        }
        //Method Search by book name======================
        private void SearchByBookName(string bookName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM book_tb WHERE bookName = @bookName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookName", "%" + bookName + "%");

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // สร้าง ListViewItem และเพิ่มข้อมูลแต่ละคอลัมน์
                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString()); // ISBN
                        item.SubItems.Add(reader["bookName"].ToString()); // ชื่อหนังสือ
                        item.SubItems.Add(reader["bookTypeId"].ToString()); // ประเภทหนังสือ
                        item.SubItems.Add(reader["bookQuantity"].ToString()); // จำนวนทั้งหมด
                        item.SubItems.Add(reader["bookAvailable"].ToString()); // จำนวนคงเหลือ

                        item.Tag = reader["iSbn"].ToString(); // เก็บ iSbn ไว้ใน Tag
                        lsBookList.Items.Add(item);
                    }
                    else
                    {
                        MessageBox.Show("ไม่พบรายชื่อของหนังสือที่ค้นหา", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                }
                
            }
        }

        //Method Search by book type======================
        private void SearchByBookType(int selectedIndex)
        {
            // ตรวจสอบว่าค่าที่เลือกอยู่ในช่วงที่ถูกต้อง
            if (selectedIndex < 0 || selectedIndex >= 12)
            {
                MessageBox.Show("กรุณาเลือกประเภทหนังสือที่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // คำสั่ง SQL ค้นหาหนังสือตาม bookTypeId
                    string query = "SELECT * FROM book_tb WHERE bookTypeId = @bookTypeId";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@bookTypeId", selectedIndex + 1); // แปลง index เป็น bookTypeId

                    SqlDataReader reader = command.ExecuteReader();
                    lsBookList.Items.Clear(); // ล้างข้อมูลก่อนเพิ่มรายการใหม่

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["iSbn"].ToString()); // ISBN
                        item.SubItems.Add(reader["bookName"].ToString()); // ชื่อหนังสือ
                        item.SubItems.Add((selectedIndex + 1).ToString()); // ประเภทหนังสือ (bookTypeId)
                        item.SubItems.Add(reader["bookQuantity"].ToString()); // จำนวนทั้งหมด
                        item.SubItems.Add(reader["bookAvailable"].ToString()); // จำนวนคงเหลือ

                        lsBookList.Items.Add(item);
                    }

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ไม่พบหนังสือในหมวดหมู่ที่เลือก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        //+++++++++++++++++++++++++++++++ End of Method And Variable +++++++++++++++++++++++++++++++++++++++++++

        //FormLoad
        private void FrmBookList_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
            //Connection DB chenck
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("เชื่อมต่อสำเร็จ!", "SQL Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เชื่อมต่อไม่สำเร็จ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ ListView FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        private void lsBookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsBookList.SelectedItems.Count > 0)
            {

                string iSbn = lsBookList.SelectedItems[0].Tag.ToString(); // ดึง movieId จาก Tag

                // ดึงข้อมูลภาพยนตร์จากฐานข้อมูลและแสดงในฟอร์ม
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT bookImage FROM book_tb WHERE iSbn = @iSbn";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@iSbn", iSbn);
                        DataTable dt = new DataTable();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {

                            // ดึงรูปภาพจากฐานข้อมูลและแสดงใน PictureBox
                            byte[] imageBytes = reader["bookImage"] as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pcbBookCover.Image = Image.FromStream(ms);  // ใส่ PictureBox ที่คุณใช้แสดงรูปภาพ
                                    bookImage = imageBytes;
                                }
                            }




                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                    }
                }
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ BUTTON FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        //btSearch_Click======================================
        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = tbSearch.Text.Trim();
            //Validate UI (only radio ISBN and Book name )
            if (rdISBN.Checked || rdBookName.Checked)
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("กรุณาป้อนคำค้นหาที่เลือกไว้ด้วย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            lsBookList.Items.Clear(); // ล้างรายการใน ListView ก่อนแสดงผลลัพธ์ใหม่
            if (rdISBN.Checked)// SearchByISBN
            {
                SearchByISBN(searchText);
            }
            else if (rdBookName.Checked)// SearchByBookName
            {
                SearchByBookName(searchText);
            }
            else if (rdBookType.Checked)// SearchByBookType
            {
                int selectedIndex = cbbBookType.SelectedIndex;

                if (selectedIndex == -1)
                {
                    MessageBox.Show("กรุณาเลือกประเภทหนังสือจากรายการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SearchByBookType(selectedIndex);
            }
        }
        //btCancel_Click======================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            rdISBN.Checked = true;
            tbSearch.Clear();
            lsBookList.Clear();
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
            pcbBookCover.Image = null;
            LoadData();
        }
        //btMainMenu_Click====================================== DEV here plzz!!!!!!!!!!!!
        private void btMainMenu_Click(object sender, EventArgs e)
        {

        }


        //+++++++++++++++++++++++++++++++++++++++ RADIO FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++

        //rdISBN_Click=======================================
        private void rdISBN_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = true;
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
        }
        //rdBookName_Click=======================================
        private void rdBookName_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = true;
            cbbBookType.Enabled = false;
            cbbBookType.SelectedIndex = 0;
        }
        //rdBookType_Click=======================================
        private void rdBookType_Click(object sender, EventArgs e)
        {
            lsBookList.Items.Clear();
            tbSearch.Clear();
            tbSearch.Enabled = false;
            cbbBookType.Enabled = true;
        }


        //+++++++++++++++++++++++++++++++++++++++ KEYPRESS FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdISBN.Checked)
            {
                // ตรวจสอบว่ากดตัวเลข (0-9) หรือปุ่ม Backspace ได้เท่านั้น
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; // ป้องกันไม่ให้พิมพ์ตัวอักษรอื่น
                }
            }
        }

       
    }
}
