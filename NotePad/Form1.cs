using System.Windows.Forms;

namespace NotePad
{
    public partial class MyNotes : Form
    {
        string path = "";


        public MyNotes()
        {
            InitializeComponent();
            lbl_edited_file.Text = "You are currently editing a new file";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Text = string.Empty;
            path = "";
            lbl_edited_file.Text = "You are currently editing a new file";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Textdocument | *.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                    {
                        string textFromFile = streamReader.ReadToEnd();
                        text_area.Text = textFromFile;
                        path = openFileDialog.FileName;

                        lbl_edited_file.Text = "You are currently editing " + path + " file";
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Textdocument | *.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                        {
                            streamWriter.WriteLineAsync(text_area.Text);
                            path = saveFileDialog.FileName;

                            lbl_edited_file.Text = "You are currently editing " + path + " file";
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLineAsync(text_area.Text);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Textdocument | *.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    {
                        streamWriter.WriteLineAsync(text_area.Text);
                        path = saveFileDialog.FileName;

                        lbl_edited_file.Text = "You are currently editing " + path + " file";
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.SelectAll();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text_area.SelectedText = "";
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == true)
            {
                wordWrapToolStripMenuItem.Checked = false;
                text_area.WordWrap = false;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = true;
                text_area.WordWrap = true;
            }
        }

        private void text_area_TextChanged(object sender, EventArgs e)
        {

        }
    }
}