using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Tunerfish
{
    public partial class HistoryForm : Form
    {
        String fileAddress = Path.Combine(Directory.GetCurrentDirectory(), "Test1.json");
        public HistoryForm()
        {
            InitializeComponent();
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
                int i = 0;
                foreach (var oItem in Events)
                {
                    HistoryTable.Rows.Add(new object[] { oItem.date, oItem.note, oItem.centOff });
                }
            }

            //Load into DataGridView
            dataGridView1.DataSource = HistoryTable;
        }
    }
}
