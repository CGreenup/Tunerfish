using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Tunerfish
{
    public partial class NotePlayerForm : Form
    {
        Form parentForm;

        //Initialize file Address for each note depending on the oactave
        static String FPath = Path.Combine(Directory.GetCurrentDirectory(), "F1.wav");
        static String GPath = Path.Combine(Directory.GetCurrentDirectory(), "G1.wav");
        static String APath = Path.Combine(Directory.GetCurrentDirectory(), "A1.wav");
        static String BPath = Path.Combine(Directory.GetCurrentDirectory(), "B1.wav");
        static String CPath = Path.Combine(Directory.GetCurrentDirectory(), "C1.wav");
        static String DPath = Path.Combine(Directory.GetCurrentDirectory(), "D1.wav");
        static String EPath = Path.Combine(Directory.GetCurrentDirectory(), "E1.wav");
        static String FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp1.wav");
        static String GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp1.wav");
        static String ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp1.wav");
        static String CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp1.wav");
        static String DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp1.wav");



        //Create sound player for each note
        SoundPlayer FPlayer = new SoundPlayer(FPath);
        SoundPlayer GPlayer = new SoundPlayer(GPath);
        SoundPlayer APlayer = new SoundPlayer(APath);
        SoundPlayer BPlayer = new SoundPlayer(BPath);
        SoundPlayer CPlayer = new SoundPlayer(CPath);
        SoundPlayer DPlayer = new SoundPlayer(DPath);
        SoundPlayer EPlayer = new SoundPlayer(EPath);
        SoundPlayer FSharpPlayer = new SoundPlayer(FSharpPath);
        SoundPlayer GSharpPlayer = new SoundPlayer(GSharpPath);
        SoundPlayer ASharpPlayer = new SoundPlayer(ASharpPath);
        SoundPlayer CSharpPlayer = new SoundPlayer(CSharpPath);
        SoundPlayer DSharpPlayer = new SoundPlayer(DSharpPath);
        public NotePlayerForm(Form parent)
        { 
            InitializeComponent();
            //Initialize Parent Form
            parentForm = parent;

            //Initialize Buttons Color
            FSharp.BackColor = Color.Black;
            GSharp.BackColor = Color.Black;
            ASharp.BackColor = Color.Black;
            CSharp.BackColor = Color.Black;
            DSharp.BackColor = Color.Black;

            F.BackColor = Color.White;
            G.BackColor = Color.White;
            A.BackColor = Color.White;
            B.BackColor = Color.White;
            C.BackColor = Color.White;
            D.BackColor = Color.White;
            E.BackColor = Color.White;

            OneCheck.BackColor = Color.White;
            TwoCheck.BackColor = Color.White;
            ThreeCheck.BackColor = Color.White;
            FourCheck.BackColor = Color.White;
            FiveCheck.BackColor = Color.White;
            SixCheck.BackColor = Color.White;

            SustainedCheck.BackColor = Color.White;
            Stop.BackColor = Color.White;

            this.FormClosed += new FormClosedEventHandler(TunerForm_FormClosed);
        }

        private void TunerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void NotePlayerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void F_Click(object sender, EventArgs e)
        {
            if(SustainedCheck.Checked == true)
            {
                FPlayer.PlayLooping();
                
            }
            else
            {
                FPlayer.Play();
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            FPlayer.Stop();
            GPlayer.Stop();
            APlayer.Stop();
            BPlayer.Stop();
            CPlayer.Stop();
            DPlayer.Stop();
            EPlayer.Stop();
            FSharpPlayer.Stop();
            GSharpPlayer.Stop();
            ASharpPlayer.Stop();
            CSharpPlayer.Stop();
            DSharpPlayer.Stop();
            SustainedCheck.Checked = false;
        }

        private void G_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                GPlayer.PlayLooping();

            }
            else
            {
                GPlayer.Play();
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                APlayer.PlayLooping();

            }
            else
            {
                APlayer.Play();
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                BPlayer.PlayLooping();

            }
            else
            {
                BPlayer.Play();
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                CPlayer.PlayLooping();

            }
            else
            {
                CPlayer.Play();
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                DPlayer.PlayLooping();

            }
            else
            {
                DPlayer.Play();
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                EPlayer.PlayLooping();

            }
            else
            {
                EPlayer.Play();
            }
        }

        private void FSharp_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                FSharpPlayer.PlayLooping();

            }
            else
            {
                FSharpPlayer.Play();
            }
        }

        private void GSharp_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                GSharpPlayer.PlayLooping();

            }
            else
            {
                GSharpPlayer.Play();
            }
        }

        private void ASharp_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                ASharpPlayer.PlayLooping();

            }
            else
            {
                ASharpPlayer.Play();
            }
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                CSharpPlayer.PlayLooping();

            }
            else
            {
                CSharpPlayer.Play();
            }
        }

        private void DSharp_Click(object sender, EventArgs e)
        {
            if (SustainedCheck.Checked == true)
            {
                DSharpPlayer.PlayLooping();

            }
            else
            {
                DSharpPlayer.Play();
            }
        }

        private void OneCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwoCheck.Checked = false;
            ThreeCheck.Checked = false;
            FourCheck.Checked = false;
            FiveCheck.Checked = false;
            SixCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F1.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G1.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A1.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B1.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C1.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D1.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E1.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp1.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp1.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp1.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp1.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp1.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }

        private void TwoCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            OneCheck.Checked = false;
            ThreeCheck.Checked = false;
            FourCheck.Checked = false;
            FiveCheck.Checked = false;
            SixCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F2.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G2.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A2.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B2.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C2.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D2.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E2.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp2.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp2.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp2.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp2.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp2.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }

        private void ThreeCheck_CheckedChanged(object sender, EventArgs e)
        {
            ThreeCheck.Checked = true;
            TwoCheck.Checked = false;
            OneCheck.Checked = false;
            FourCheck.Checked = false;
            FiveCheck.Checked = false;
            SixCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F3.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G3.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A3.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B3.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C3.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D3.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E3.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp3.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp3.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp3.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp3.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp3.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }

        private void FourCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwoCheck.Checked = false;
            ThreeCheck.Checked = false;
            OneCheck.Checked = false;
            FiveCheck.Checked = false;
            SixCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F4.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G4.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A4.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B4.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C4.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D4.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E4.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp4.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp4.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp4.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp4.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp4.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }

        private void FiveCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwoCheck.Checked = false;
            ThreeCheck.Checked = false;
            FourCheck.Checked = false;
            OneCheck.Checked = false;
            SixCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F5.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G5.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A5.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B5.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C5.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D5.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E5.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp5.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp5.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp5.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp5.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp5.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }

        private void SixCheck_CheckedChanged(object sender, EventArgs e)
        {
            TwoCheck.Checked = false;
            ThreeCheck.Checked = false;
            FourCheck.Checked = false;
            FiveCheck.Checked = false;
            OneCheck.Checked = false;

            FPath = Path.Combine(Directory.GetCurrentDirectory(), "F6.wav");
            GPath = Path.Combine(Directory.GetCurrentDirectory(), "G6.wav");
            APath = Path.Combine(Directory.GetCurrentDirectory(), "A6.wav");
            BPath = Path.Combine(Directory.GetCurrentDirectory(), "B6.wav");
            CPath = Path.Combine(Directory.GetCurrentDirectory(), "C6.wav");
            DPath = Path.Combine(Directory.GetCurrentDirectory(), "D6.wav");
            EPath = Path.Combine(Directory.GetCurrentDirectory(), "E6.wav");
            FSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "FSharp6.wav");
            GSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "GSharp6.wav");
            ASharpPath = Path.Combine(Directory.GetCurrentDirectory(), "ASharp6.wav");
            CSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "CSharp6.wav");
            DSharpPath = Path.Combine(Directory.GetCurrentDirectory(), "DSharp6.wav");

            FPlayer.SoundLocation = FPath;
            GPlayer.SoundLocation = GPath;
            APlayer.SoundLocation = APath;
            BPlayer.SoundLocation = BPath;
            CPlayer.SoundLocation = CPath;
            DPlayer.SoundLocation = DPath;
            EPlayer.SoundLocation = EPath;
            FSharpPlayer.SoundLocation = FSharpPath;
            GSharpPlayer.SoundLocation = GSharpPath;
            ASharpPlayer.SoundLocation = ASharpPath;
            CSharpPlayer.SoundLocation = CSharpPath;
            DSharpPlayer.SoundLocation = DSharpPath;
        }
    }
}
