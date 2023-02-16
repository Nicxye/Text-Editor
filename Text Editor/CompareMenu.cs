using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Editor
{
    public partial class frmCompareMenu : Form
    {
        private List<int> coincidencesFound;
        private List<string> oldWordsList = new List<string>();
        private List<string> newWordsList = new List<string>();

        private string[] delimiters = { " ", "," };

        public frmCompareMenu()
        {
            InitializeComponent();
        }

        private void btnLoadOld_Click(object sender, EventArgs e)
        {
            LoadFile(rtbOldFile);
        }

        private void LoadFile(RichTextBox textFile)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select the old file";
            file.Filter = "Text files (.txt)|*.txt|All files (.)|*.*";
            if (file.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(file.FileName);
                textFile.Text = sr.ReadToEnd();
                sr.Close();
            }

        }

        private void btnLoadNew_Click(object sender, EventArgs e)
        {
            LoadFile(rtbNewFile);
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (rtbOldFile.Text == "")
            {
                rtbOldFile.Clear();
                rtbNewFile.Clear();

            }

            if (rtbOldFile.Text != rtbNewFile.Text)
                FindDifferences(rtbOldFile, rtbNewFile);
                //FindText(rtbOldFile, rtbNewFile.Text);
        }
        private List<int> FindAllCoincidences(RichTextBox oldText, string newText, int searchStart)
        {
            coincidencesFound = new List<int>();

            if (newText.Length <= 0)
                return coincidencesFound;

            int positionFound = oldText.Find(newText, searchStart, RichTextBoxFinds.None);
            while (positionFound >= 0)
            {
                coincidencesFound.Add(positionFound);
                positionFound = oldText.Find(newText, positionFound + newText.Length, RichTextBoxFinds.None);
            }

            return coincidencesFound;
        }

        private void HighlightAll(RichTextBox oldText, Color color, List<int> coincidencesFound, int length)
        {
            foreach (int position in coincidencesFound)
            {
                oldText.Select(position, length);
                oldText.SelectionBackColor = color;
            }
        }
        private void FindText(RichTextBox oldText, string textToSearch)
        {
            int cursorPos = oldText.SelectionStart;
            ClearHighlights(oldText);
            coincidencesFound = FindAllCoincidences(oldText, textToSearch, 0);
            HighlightAll(oldText, Color.LightCoral, coincidencesFound, textToSearch.Length); //Change color to DodgerBlue when ready.
            oldText.SelectionStart = 0;
            oldText.ScrollToCaret();
        }

        private void ClearHighlights(RichTextBox oldText)
        {
            oldText.Select(0, oldText.TextLength);
            oldText.SelectionBackColor = oldText.BackColor;
        }

        private void FindDifferences(RichTextBox oldText, RichTextBox newText)
        {
            string[] oldWords = oldText.Text.Split(delimiters, StringSplitOptions.None);
            string[] newWords = newText.Text.Split(delimiters, StringSplitOptions.None);

            try
            {
                foreach (string word in oldWords)
                {
                    oldWordsList.Add(word);
                }
                foreach (string word in newWords)
                {
                    newWordsList.Add(word);
                }

                for (int i = 0; i < oldWordsList.Count(); i++)
                {
                    if (!oldWordsList.Contains(newWordsList[i]))
                    {
                        oldText.ForeColor = Color.LightCoral;
                        oldText.Text += newWordsList[i].ToString() + " ";
                    }
                    else
                        oldText.Text += oldWordsList[i].ToString() + " ";

                }

                //for (int i = 0; i < oldWordsList.Count; i++)
                //{
                //    if (oldWordsList[i] != newWordsList[i])
                //    {
                //        oldText.

                //    }
                //}

                //List<string> firstText = oldWords.Except(newWords).ToList();
                //List<string> secondText = newWords.Except(oldWords).ToList();

                //for (int i = 0; i < oldWords.Count(); i++)
                //{
                //    //if (firstText[i] == oldWords[i])
                //    //{
                        
                //    //}
                //}


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
