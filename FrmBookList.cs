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
    public partial class FrmBookList : Form
    {
        public FrmBookList()
        {
            InitializeComponent();
        }
        //++++++++++++++++++++++++++++++++ Method And Variable +++++++++++++++++++++++++++++++++++++++++++++++++




        //+++++++++++++++++++++++++++++++ End of Method And Variable +++++++++++++++++++++++++++++++++++++++++++

        //FormLoad
        private void FrmBookList_Load(object sender, EventArgs e)
        {
            btCancel.PerformClick();
        }



        //+++++++++++++++++++++++++++++++++++++++ BUTTON FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++
        //btSearch_Click======================================
        private void btSearch_Click(object sender, EventArgs e)
        {

        }
        //btCancel_Click======================================
        private void btCancel_Click(object sender, EventArgs e)
        {
            rdISBN.Checked = true;
            tbSearch.Clear();
            lsBookList.Clear();
        }
        //btMainMenu_Click======================================
        private void btMainMenu_Click(object sender, EventArgs e)
        {

        }

        //++++++++++++++++++++++++++++++++++++++++ RADIO FUNC +++++++++++++++++++++++++++++++++++++++++++++++++++


    }
}
