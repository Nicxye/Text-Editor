using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class frmMainMenu : Form
    {
        private string searchText = frmSearchMenu.SearchText;
        public frmMainMenu()
        {
            InitializeComponent();
            DisableMenuItems();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.Text.Length > 0)
            {
                DialogResult confirm = MessageBox.Show("This action will open a new file and permanently clear this one. Are you sure you have saved and want to proceed?", "Opening a new file", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                    rtbText.Clear();

            }
        }

        private void newwindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainMenu newWindow = new frmMainMenu();
            newWindow.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select your file";
            ofd.Filter = "Text files (.txt)|*.txt|All files (.)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                rtbText.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select your file";
            sfd.Filter = "Text files (.txt)|*.txt|Rich text file (rtf)|*rtf|Word document|.docx";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(rtbText.Text);
                Close();
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Select your file";
            sfd.Filter = "All files (.)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(rtbText.Text);
                Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Paste();
        }

        private void selectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.SelectAll();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                rtbText.ForeColor = colorDialog.Color;
        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
                rtbText.SelectionFont = fontDialog.Font;
        }

        private void DisableMenuItems()
        {
            if (!rtbText.Modified)
                undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
            cutToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
            searchToolStripMenuItem.Enabled = false;
        }
        private void EnableMenuItems()
        {
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = true;
            cutToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = true;
            searchToolStripMenuItem.Enabled = true;
        }

        private void rtxtText_TextChanged(object sender, EventArgs e)
        {
            if (rtbText.Text.Length == 0)
                DisableMenuItems();
            else
                EnableMenuItems();
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchMenu searchMenu = new frmSearchMenu();
            searchMenu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] wordSearch = textBox1.Text.Split(',');
            foreach (string word in wordSearch)
            {   
                //Test.
            }
            FindText();
        }

        private void FindText()
        {
            throw new NotImplementedException();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
