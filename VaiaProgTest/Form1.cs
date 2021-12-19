namespace VaiaProgTest
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }


        private void loadBtn_Click(object sender, EventArgs e)
        {
            string selectedFile = "";
            int testIfInt;

            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.dataEntriesGrid.Rows.Clear();
                selectedFile = ofd.FileName;
            }

            if (selectedFile.Length > 4 && selectedFile.Substring(selectedFile.Length - 4) == ".csv")
            {
                loadErrorLabel.Text = "";
                try
                {
                    using (StreamReader sr = new StreamReader(selectedFile))
                    {
                        string line = sr.ReadLine();
                        while (line != null)
                        {
                            var dataCol = line.Split(',');
                            if (int.TryParse(dataCol[1], out testIfInt))
                            {
                                this.dataEntriesGrid.Rows.Add(dataCol[0], dataCol[1], dataCol[2]);
                            }
                            else
                            {
                                this.dataEntriesGrid.Rows.Clear();
                                loadErrorLabel.Text = "*Readings must be integers*";
                                break;
                            }
                            line = sr.ReadLine();
                        }
                    }
                    if (this.dataEntriesGrid.Rows.Count > 0) {
                        updateAverage();
                        loadErrorLabel.Text = "";
                    }
                }
                catch {}
            }
            else
            {
                loadErrorLabel.Text = "*A .csv file must be chosen*";
            }

        }

            private void dataEntriesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updateAverage();

            DateTime today = DateTime.Now;
            if (e.RowIndex >= 0)
            {
                this.dataEntriesGrid.Rows[e.RowIndex].Cells[2].Value = today.ToString();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "csv files (*csv)|*.csv|All files (*.*)|*.*";
            sfd.RestoreDirectory = true;


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {

                    foreach (DataGridViewRow row in dataEntriesGrid.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.ColumnIndex < 2)
                            {
                                sw.Write(cell.Value.ToString() + ",");
                            }
                            else
                            {
                                sw.WriteLine(cell.Value.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int integerValue;

            if (!string.IsNullOrEmpty(dataValue.Text))
            {
                if (!int.TryParse(dataValue.Text, out integerValue))
                {
                    addErrorLabel.Text = "*Text box must contain an integer*";
                }
                else
                {
                    addErrorLabel.Text = "";

                    DateTime today = DateTime.Now;
                    this.dataEntriesGrid.Rows.Add(dataEntriesGrid.Rows.Count.ToString(), integerValue,today);

                    updateAverage();

                    dataValue.Text = "";
                }

            }
            else
            {
                addErrorLabel.Text = "*Add integer to text box*";
            }
        }

        private void updateAverage()
        {
            int dataTotal = 0;
            int cellValue;
            bool allInt = true;

            for (int i = 0; i < dataEntriesGrid.Rows.Count; i++)
            {   if (int.TryParse(dataEntriesGrid.Rows[i].Cells[1].Value.ToString(), out cellValue)) {
                    dataTotal += cellValue;
                }
                else
                {
                    allInt = false;
                }
            }

            if (allInt)
            {
                averageVariable.Text = ((double)dataTotal / dataEntriesGrid.Rows.Count).ToString("F");
            }
            else
            {
                averageVariable.Text = "Invalid Data";
            }
        }


    }
}