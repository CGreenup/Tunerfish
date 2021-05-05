using System;

namespace Tunerfish
{
    partial class AudioAnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pitchText = new System.Windows.Forms.TextBox();
            this.noteText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.HzText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 123);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 123);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 123);
            this.splitContainer1.SplitterDistance = 484;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.metronomeBtn);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.noteplayerBtn);
            this.splitContainer4.Size = new System.Drawing.Size(484, 123);
            this.splitContainer4.SplitterDistance = 240;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // metronomeBtn
            // 
            this.metronomeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metronomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.metronomeBtn.Location = new System.Drawing.Point(0, 0);
            this.metronomeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metronomeBtn.Name = "metronomeBtn";
            this.metronomeBtn.Size = new System.Drawing.Size(240, 123);
            this.metronomeBtn.TabIndex = 0;
            this.metronomeBtn.Text = "Metronome";
            this.metronomeBtn.UseVisualStyleBackColor = true;
            // 
            // noteplayerBtn
            // 
            this.noteplayerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteplayerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.noteplayerBtn.Location = new System.Drawing.Point(0, 0);
            this.noteplayerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteplayerBtn.Name = "noteplayerBtn";
            this.noteplayerBtn.Size = new System.Drawing.Size(239, 123);
            this.noteplayerBtn.TabIndex = 0;
            this.noteplayerBtn.Text = "Note Player";
            this.noteplayerBtn.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tunerBtn);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(730, 123);
            this.splitContainer2.SplitterDistance = 242;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // tunerBtn
            // 
            this.tunerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tunerBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.tunerBtn.Location = new System.Drawing.Point(0, 0);
            this.tunerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tunerBtn.Name = "tunerBtn";
            this.tunerBtn.Size = new System.Drawing.Size(242, 123);
            this.tunerBtn.TabIndex = 0;
            this.tunerBtn.Text = "Tuner";
            this.tunerBtn.UseVisualStyleBackColor = true;
            this.tunerBtn.Click += new System.EventHandler(this.tunerBtn_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.analysisBtn);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.historyBtn);
            this.splitContainer3.Size = new System.Drawing.Size(483, 123);
            this.splitContainer3.SplitterDistance = 243;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // analysisBtn
            // 
            this.analysisBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analysisBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.analysisBtn.Location = new System.Drawing.Point(0, 0);
            this.analysisBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.analysisBtn.Name = "analysisBtn";
            this.analysisBtn.Size = new System.Drawing.Size(243, 123);
            this.analysisBtn.TabIndex = 0;
            this.analysisBtn.Text = "Audio Analysis";
            this.analysisBtn.UseVisualStyleBackColor = true;
            // 
            // historyBtn
            // 
            this.historyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.historyBtn.Location = new System.Drawing.Point(0, 0);
            this.historyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(235, 123);
            this.historyBtn.TabIndex = 0;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> 03776ef4ee4fc5407d2fab1e4210e5056ebaf504
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pitchText
            // 
            this.pitchText.Location = new System.Drawing.Point(1037, 139);
            this.pitchText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pitchText.Name = "pitchText";
            this.pitchText.Size = new System.Drawing.Size(132, 22);
            this.pitchText.TabIndex = 2;
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(1037, 244);
            this.noteText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(132, 22);
            this.noteText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1079, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1083, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pitch";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
<<<<<<< HEAD
            this.chart1.Size = new System.Drawing.Size(1219, 499);
=======
            this.chart1.Size = new System.Drawing.Size(914, 505);
>>>>>>> 03776ef4ee4fc5407d2fab1e4210e5056ebaf504
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1063, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Off By (Hz)";
            // 
            // HzText
            // 
            this.HzText.Location = new System.Drawing.Point(1037, 347);
            this.HzText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HzText.Name = "HzText";
            this.HzText.Size = new System.Drawing.Size(132, 22);
            this.HzText.TabIndex = 6;
            // 
            // AudioAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(50)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1219, 622);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HzText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteText);
            this.Controls.Add(this.pitchText);
            this.Controls.Add(this.chart1);
<<<<<<< HEAD
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
>>>>>>> 03776ef4ee4fc5407d2fab1e4210e5056ebaf504
            this.Name = "AudioAnalysisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox pitchText;
        private System.Windows.Forms.TextBox noteText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HzText;
    }
}

