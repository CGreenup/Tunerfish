using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tunerfish
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void audio_analysis_btn_Click(object sender, EventArgs e)
        {
            AudioAnalysisForm form = new AudioAnalysisForm(this);
            this.Hide();
            form.Show();
        }

        private void history_btn_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(this);
            this.Hide();
            historyForm.Show();
        }

        private void tuner_btn_Click(object sender, EventArgs e)
        {
            TunerForm tunerForm = new TunerForm(this);
            this.Hide();
            tunerForm.Show();
        }

        private void note_player_btn_Click(object sender, EventArgs e)
        {
            NotePlayerForm notePlayerForm = new NotePlayerForm(this);
            this.Hide();
            notePlayerForm.Show();
        }

        private void metronome_btn_Click(object sender, EventArgs e)
        {
            MetronomeForm1 metronomeForm = new MetronomeForm1(this);
            this.Hide();
            metronomeForm.Show();
        }
    }
}
