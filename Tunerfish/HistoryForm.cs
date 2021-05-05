using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using TunerFish;

namespace Tunerfish
{
    public partial class HistoryForm : Form
    {
        String fileAddress = Path.Combine(Directory.GetCurrentDirectory(), "HistoryData.json");

        Form parentForm;

        public HistoryForm(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            //Create Data Table
            DataTable HistoryTable = new DataTable();

            //Deserialize Data
            List<Event> Events = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(fileAddress));

            //Add Columns
            HistoryTable.Columns.Add("Date");
            HistoryTable.Columns.Add("Note");
            HistoryTable.Columns.Add("Cents Off");

            //Add Value
            if (new FileInfo(fileAddress).Length == 0)
            {
                dataGridView1.DataSource = null;
            }
            else
            {
                foreach (var oItem in Events)
                {
                    HistoryTable.Rows.Add(new object[] { oItem.date, oItem.note, oItem.centOff });
                }
            }

            //Load into DataGridView
            dataGridView1.DataSource = HistoryTable;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Display Row of Cell and warning message
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0}:{1}", "You want to delete Row ", e.RowIndex);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Event Deletion");

            //Deserialize data
            List<Event> Events = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(fileAddress));
            Events.RemoveAt(e.RowIndex);

            //Delete All text in file
            File.WriteAllText(fileAddress, string.Empty);

            //Serialize the new data
            string json = JsonConvert.SerializeObject(Events, Formatting.Indented);
            File.WriteAllText(fileAddress, json);

            //Load Form
            HistoryForm_Load(sender, e);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        //This code is now just here so it won't cause issue with deisgner. Please ignore the ClearButton_Click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileAddress, string.Empty);
            HistoryForm_Load(sender, e);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
        //The above code is useless

        private void Clear_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileAddress, string.Empty);
            HistoryForm_Load(sender, e);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }
}
