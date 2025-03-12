using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectLibraryManagementSystem
{
    public partial class FrmBookBorrowHistories : Form
    {
        public FrmBookBorrowHistories()
        {
            InitializeComponent();
        }
        //++++++++++++++++++++++++++++++++ Method And Variable +++++++++++++++++++++++++++++++++++++++++++++++++
        
        


        //+++++++++++++++++++++++++++++++ End of Method And Variable +++++++++++++++++++++++++++++++++++++++++++

        //FormLoad
        private void FrmBookBorrowHistories_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }

        //+++++++++++++++++++++++++++++++++++++++ BUTTON FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++


        // btSearch_Click =======================================
        private void btSearch_Click(object sender, EventArgs e)
        {

        }
        // btCancel_Click =======================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            cbdtpBorrow.Checked = false;
            cbUserId.Checked = false;

            tbUserId.Clear();
            tbUserId.Enabled = false;

            dtpBorrow.Value = DateTime.Now;
            dtpBorrow.Enabled = false;

            lsBookBorrow.Clear();
        } 
        // btMainMenu_Click ======================================
        private void btMainMenu_Click(object sender, EventArgs e)
        {

        }


        //++++++++++++++++++++++++++++++++++++++++ CHECKBOX +++++++++++++++++++++++++++++++++++++++++++++++++++++

        //cbUserId_Click======================================
        private void cbUserId_Click(object sender, EventArgs e)
        {
            if (cbUserId.Checked) { 
                tbUserId.Enabled = true;
            }
            else
            {
                tbUserId.Clear();
                tbUserId.Enabled = false;
            }
        }
        //cbdtpBorrow_Click======================================
        private void cbdtpBorrow_Click(object sender, EventArgs e)
        {
            if (cbdtpBorrow.Checked)
            {
                dtpBorrow.Enabled = true;
            }
            else
            {
                dtpBorrow.Enabled = false;
                dtpBorrow.Value = DateTime.Now;
            }
        }

        //+++++++++++++++++++++++++++++++++++++++ KEY PRESS +++++++++++++++++++++++++++++++++++++++++++++++++++++

        //tbUserId_KeyPress===============================================
        private void tbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Block the keypress
            }
        }

        
    }
}
