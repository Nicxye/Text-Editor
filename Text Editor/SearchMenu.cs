using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class frmSearchMenu : Form
    {
        private static string searchText;
        public frmSearchMenu()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchText = txtSearch.Text;
        }

        public static string SearchText
        {
            get { return searchText; }
        }
    }
}
