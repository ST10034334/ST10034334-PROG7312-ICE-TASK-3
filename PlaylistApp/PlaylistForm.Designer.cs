namespace PlaylistApp
{
    partial class frmPlaylist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picBackground = new PictureBox();
            picShuffle = new PictureBox();
            picRemove = new PictureBox();
            lblPlaylistTitle = new Label();
            picAdd = new PictureBox();
            picTrack = new PictureBox();
            picPrevious = new PictureBox();
            picNext = new PictureBox();
            richTrackOutput = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)picBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShuffle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPrevious).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNext).BeginInit();
            SuspendLayout();
            // 
            // picBackground
            // 
            picBackground.Location = new Point(-15, 12);
            picBackground.Name = "picBackground";
            picBackground.Size = new Size(1017, 453);
            picBackground.TabIndex = 0;
            picBackground.TabStop = false;
            // 
            // picShuffle
            // 
            picShuffle.BackColor = SystemColors.ActiveCaptionText;
            picShuffle.Location = new Point(596, 356);
            picShuffle.Name = "picShuffle";
            picShuffle.Size = new Size(78, 61);
            picShuffle.TabIndex = 13;
            picShuffle.TabStop = false;
            // 
            // picRemove
            // 
            picRemove.BackColor = SystemColors.ActiveCaptionText;
            picRemove.Location = new Point(339, 365);
            picRemove.Name = "picRemove";
            picRemove.Size = new Size(66, 48);
            picRemove.TabIndex = 12;
            picRemove.TabStop = false;
            picRemove.Click += picRemove_Click;
            // 
            // lblPlaylistTitle
            // 
            lblPlaylistTitle.AutoSize = true;
            lblPlaylistTitle.BackColor = SystemColors.ActiveCaptionText;
            lblPlaylistTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlaylistTitle.ForeColor = SystemColors.Control;
            lblPlaylistTitle.Location = new Point(373, 22);
            lblPlaylistTitle.Name = "lblPlaylistTitle";
            lblPlaylistTitle.Size = new Size(241, 48);
            lblPlaylistTitle.TabIndex = 11;
            lblPlaylistTitle.Text = "MY PLAYLIST";
            // 
            // picAdd
            // 
            picAdd.BackColor = SystemColors.ActiveCaptionText;
            picAdd.Location = new Point(458, 356);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(83, 69);
            picAdd.TabIndex = 10;
            picAdd.TabStop = false;
            picAdd.Click += picAdd_Click;
            // 
            // picTrack
            // 
            picTrack.BackColor = SystemColors.ActiveCaptionText;
            picTrack.Location = new Point(191, 73);
            picTrack.Name = "picTrack";
            picTrack.Size = new Size(634, 264);
            picTrack.TabIndex = 7;
            picTrack.TabStop = false;
            // 
            // picPrevious
            // 
            picPrevious.BackColor = Color.Black;
            picPrevious.Location = new Point(106, 136);
            picPrevious.Name = "picPrevious";
            picPrevious.Size = new Size(79, 145);
            picPrevious.TabIndex = 14;
            picPrevious.TabStop = false;
            picPrevious.Click += picPrevious_Click;
            // 
            // picNext
            // 
            picNext.BackColor = SystemColors.ActiveCaptionText;
            picNext.Location = new Point(831, 136);
            picNext.Name = "picNext";
            picNext.Size = new Size(79, 145);
            picNext.TabIndex = 15;
            picNext.TabStop = false;
            picNext.Click += picNext_Click;
            // 
            // richTrackOutput
            // 
            richTrackOutput.BackColor = SystemColors.InactiveCaptionText;
            richTrackOutput.BorderStyle = BorderStyle.None;
            richTrackOutput.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTrackOutput.ForeColor = SystemColors.InactiveBorder;
            richTrackOutput.Location = new Point(195, 258);
            richTrackOutput.Name = "richTrackOutput";
            richTrackOutput.ReadOnly = true;
            richTrackOutput.Size = new Size(181, 74);
            richTrackOutput.TabIndex = 16;
            richTrackOutput.Text = "";
            // 
            // frmPlaylist
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(richTrackOutput);
            Controls.Add(picNext);
            Controls.Add(picPrevious);
            Controls.Add(picShuffle);
            Controls.Add(picRemove);
            Controls.Add(lblPlaylistTitle);
            Controls.Add(picAdd);
            Controls.Add(picTrack);
            Controls.Add(picBackground);
            Name = "frmPlaylist";
            Text = "My Playlist";
            ((System.ComponentModel.ISupportInitialize)picBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShuffle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPrevious).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBackground;
        private PictureBox picShuffle;
        private PictureBox picRemove;
        private Label lblPlaylistTitle;
        private PictureBox picAdd;
        private PictureBox picTrack;
        private PictureBox picPrevious;
        private PictureBox picNext;
        private RichTextBox richTrackOutput;
    }
}
