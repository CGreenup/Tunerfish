namespace Tunerfish
{
    partial class SelectionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metronome_btn = new System.Windows.Forms.Button();
            this.note_player_btn = new System.Windows.Forms.Button();
            this.tuner_btn = new System.Windows.Forms.Button();
            this.audio_analysis_btn = new System.Windows.Forms.Button();
            this.history_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metronome_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.note_player_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tuner_btn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.audio_analysis_btn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.history_btn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metronome_btn
            // 
            this.metronome_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metronome_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.metronome_btn.Location = new System.Drawing.Point(3, 3);
            this.metronome_btn.Name = "metronome_btn";
            this.metronome_btn.Size = new System.Drawing.Size(185, 162);
            this.metronome_btn.TabIndex = 0;
            this.metronome_btn.Text = "Metronome";
            this.metronome_btn.UseVisualStyleBackColor = true;
            this.metronome_btn.Click += new System.EventHandler(this.metronome_btn_Click);
            // 
            // note_player_btn
            // 
            this.note_player_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note_player_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.note_player_btn.Location = new System.Drawing.Point(194, 3);
            this.note_player_btn.Name = "note_player_btn";
            this.note_player_btn.Size = new System.Drawing.Size(185, 162);
            this.note_player_btn.TabIndex = 1;
            this.note_player_btn.Text = "Note Player";
            this.note_player_btn.UseVisualStyleBackColor = true;
            this.note_player_btn.Click += new System.EventHandler(this.note_player_btn_Click);
            // 
            // tuner_btn
            // 
            this.tuner_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tuner_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.tuner_btn.Location = new System.Drawing.Point(385, 3);
            this.tuner_btn.Name = "tuner_btn";
            this.tuner_btn.Size = new System.Drawing.Size(185, 162);
            this.tuner_btn.TabIndex = 2;
            this.tuner_btn.Text = "Tuner";
            this.tuner_btn.UseVisualStyleBackColor = true;
            this.tuner_btn.Click += new System.EventHandler(this.tuner_btn_Click);
            // 
            // audio_analysis_btn
            // 
            this.audio_analysis_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audio_analysis_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.audio_analysis_btn.Location = new System.Drawing.Point(576, 3);
            this.audio_analysis_btn.Name = "audio_analysis_btn";
            this.audio_analysis_btn.Size = new System.Drawing.Size(185, 162);
            this.audio_analysis_btn.TabIndex = 3;
            this.audio_analysis_btn.Text = "Audio Analysis";
            this.audio_analysis_btn.UseVisualStyleBackColor = true;
            this.audio_analysis_btn.Click += new System.EventHandler(this.audio_analysis_btn_Click);
            // 
            // history_btn
            // 
            this.history_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold);
            this.history_btn.Location = new System.Drawing.Point(767, 3);
            this.history_btn.Name = "history_btn";
            this.history_btn.Size = new System.Drawing.Size(188, 162);
            this.history_btn.TabIndex = 4;
            this.history_btn.Text = "History";
            this.history_btn.UseVisualStyleBackColor = true;
            this.history_btn.Click += new System.EventHandler(this.history_btn_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(958, 168);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(974, 207);
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button metronome_btn;
        private System.Windows.Forms.Button note_player_btn;
        private System.Windows.Forms.Button tuner_btn;
        private System.Windows.Forms.Button audio_analysis_btn;
        private System.Windows.Forms.Button history_btn;
    }
}