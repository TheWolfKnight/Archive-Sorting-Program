namespace Frontend.Views
{
    partial class AnimeView
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
            this.pcb_ImageDisplay = new System.Windows.Forms.PictureBox();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.txb_Title = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Tags = new System.Windows.Forms.Label();
            this.txb_Tags = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txb_EpisodeCount = new System.Windows.Forms.TextBox();
            this.txb_EpisodeSeen = new System.Windows.Forms.TextBox();
            this.txb_SeasonSeen = new System.Windows.Forms.TextBox();
            this.txb_SeasonCount = new System.Windows.Forms.TextBox();
            this.lbl_Episode = new System.Windows.Forms.Label();
            this.lbl_Season = new System.Windows.Forms.Label();
            this.lbl_SeasonAmoun = new System.Windows.Forms.Label();
            this.lbl_SeasonSeen = new System.Windows.Forms.Label();
            this.lbl_EpisodeSeen = new System.Windows.Forms.Label();
            this.lbl_EpisodeCount = new System.Windows.Forms.Label();
            this.cmb_WatchStatus = new System.Windows.Forms.ComboBox();
            this.cmb_ReleaseStatus = new System.Windows.Forms.ComboBox();
            this.lbl_WatchStatus = new System.Windows.Forms.Label();
            this.lbl_ReleaseStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ImageDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_ImageDisplay
            // 
            this.pcb_ImageDisplay.Location = new System.Drawing.Point(13, 13);
            this.pcb_ImageDisplay.Name = "pcb_ImageDisplay";
            this.pcb_ImageDisplay.Size = new System.Drawing.Size(140, 170);
            this.pcb_ImageDisplay.TabIndex = 0;
            this.pcb_ImageDisplay.TabStop = false;
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(13, 263);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(369, 243);
            this.rtb_Description.TabIndex = 1;
            this.rtb_Description.Text = "";
            // 
            // txb_Title
            // 
            this.txb_Title.Location = new System.Drawing.Point(13, 214);
            this.txb_Title.Name = "txb_Title";
            this.txb_Title.Size = new System.Drawing.Size(369, 20);
            this.txb_Title.TabIndex = 2;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(10, 198);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(27, 13);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Title";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(10, 247);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 4;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_Tags
            // 
            this.lbl_Tags.AutoSize = true;
            this.lbl_Tags.Location = new System.Drawing.Point(10, 518);
            this.lbl_Tags.Name = "lbl_Tags";
            this.lbl_Tags.Size = new System.Drawing.Size(31, 13);
            this.lbl_Tags.TabIndex = 6;
            this.lbl_Tags.Text = "Tags";
            // 
            // txb_Tags
            // 
            this.txb_Tags.Location = new System.Drawing.Point(13, 534);
            this.txb_Tags.Name = "txb_Tags";
            this.txb_Tags.Size = new System.Drawing.Size(369, 20);
            this.txb_Tags.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 581);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(100, 59);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_SaveClicked);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(282, 581);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 59);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_DeleteClicked);
            // 
            // txb_EpisodeCount
            // 
            this.txb_EpisodeCount.Location = new System.Drawing.Point(192, 38);
            this.txb_EpisodeCount.Name = "txb_EpisodeCount";
            this.txb_EpisodeCount.Size = new System.Drawing.Size(61, 20);
            this.txb_EpisodeCount.TabIndex = 9;
            this.txb_EpisodeCount.TextChanged += new System.EventHandler(this.txb_ProgressInputValidator);
            // 
            // txb_EpisodeSeen
            // 
            this.txb_EpisodeSeen.Location = new System.Drawing.Point(309, 38);
            this.txb_EpisodeSeen.Name = "txb_EpisodeSeen";
            this.txb_EpisodeSeen.Size = new System.Drawing.Size(61, 20);
            this.txb_EpisodeSeen.TabIndex = 10;
            this.txb_EpisodeSeen.TextChanged += new System.EventHandler(this.txb_ProgressInputValidator);
            // 
            // txb_SeasonSeen
            // 
            this.txb_SeasonSeen.Location = new System.Drawing.Point(309, 78);
            this.txb_SeasonSeen.Name = "txb_SeasonSeen";
            this.txb_SeasonSeen.Size = new System.Drawing.Size(61, 20);
            this.txb_SeasonSeen.TabIndex = 12;
            this.txb_SeasonSeen.TextChanged += new System.EventHandler(this.txb_ProgressInputValidator);
            // 
            // txb_SeasonCount
            // 
            this.txb_SeasonCount.Location = new System.Drawing.Point(192, 78);
            this.txb_SeasonCount.Name = "txb_SeasonCount";
            this.txb_SeasonCount.Size = new System.Drawing.Size(61, 20);
            this.txb_SeasonCount.TabIndex = 11;
            this.txb_SeasonCount.TextChanged += new System.EventHandler(this.txb_ProgressInputValidator);
            // 
            // lbl_Episode
            // 
            this.lbl_Episode.AutoSize = true;
            this.lbl_Episode.Location = new System.Drawing.Point(189, 22);
            this.lbl_Episode.Name = "lbl_Episode";
            this.lbl_Episode.Size = new System.Drawing.Size(45, 13);
            this.lbl_Episode.TabIndex = 13;
            this.lbl_Episode.Text = "Episode";
            // 
            // lbl_Season
            // 
            this.lbl_Season.AutoSize = true;
            this.lbl_Season.Location = new System.Drawing.Point(189, 62);
            this.lbl_Season.Name = "lbl_Season";
            this.lbl_Season.Size = new System.Drawing.Size(43, 13);
            this.lbl_Season.TabIndex = 14;
            this.lbl_Season.Text = "Season";
            // 
            // lbl_SeasonAmoun
            // 
            this.lbl_SeasonAmoun.AutoSize = true;
            this.lbl_SeasonAmoun.Location = new System.Drawing.Point(159, 81);
            this.lbl_SeasonAmoun.Name = "lbl_SeasonAmoun";
            this.lbl_SeasonAmoun.Size = new System.Drawing.Size(35, 13);
            this.lbl_SeasonAmoun.TabIndex = 15;
            this.lbl_SeasonAmoun.Text = "Count";
            // 
            // lbl_SeasonSeen
            // 
            this.lbl_SeasonSeen.AutoSize = true;
            this.lbl_SeasonSeen.Location = new System.Drawing.Point(271, 81);
            this.lbl_SeasonSeen.Name = "lbl_SeasonSeen";
            this.lbl_SeasonSeen.Size = new System.Drawing.Size(32, 13);
            this.lbl_SeasonSeen.TabIndex = 16;
            this.lbl_SeasonSeen.Text = "Seen";
            // 
            // lbl_EpisodeSeen
            // 
            this.lbl_EpisodeSeen.AutoSize = true;
            this.lbl_EpisodeSeen.Location = new System.Drawing.Point(271, 41);
            this.lbl_EpisodeSeen.Name = "lbl_EpisodeSeen";
            this.lbl_EpisodeSeen.Size = new System.Drawing.Size(32, 13);
            this.lbl_EpisodeSeen.TabIndex = 18;
            this.lbl_EpisodeSeen.Text = "Seen";
            // 
            // lbl_EpisodeCount
            // 
            this.lbl_EpisodeCount.AutoSize = true;
            this.lbl_EpisodeCount.Location = new System.Drawing.Point(159, 41);
            this.lbl_EpisodeCount.Name = "lbl_EpisodeCount";
            this.lbl_EpisodeCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_EpisodeCount.TabIndex = 17;
            this.lbl_EpisodeCount.Text = "Count";
            // 
            // cmb_WatchStatus
            // 
            this.cmb_WatchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_WatchStatus.FormattingEnabled = true;
            this.cmb_WatchStatus.Location = new System.Drawing.Point(192, 131);
            this.cmb_WatchStatus.Name = "cmb_WatchStatus";
            this.cmb_WatchStatus.Size = new System.Drawing.Size(121, 21);
            this.cmb_WatchStatus.TabIndex = 19;
            // 
            // cmb_ReleaseStatus
            // 
            this.cmb_ReleaseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ReleaseStatus.FormattingEnabled = true;
            this.cmb_ReleaseStatus.Location = new System.Drawing.Point(192, 170);
            this.cmb_ReleaseStatus.Name = "cmb_ReleaseStatus";
            this.cmb_ReleaseStatus.Size = new System.Drawing.Size(121, 21);
            this.cmb_ReleaseStatus.TabIndex = 20;
            // 
            // lbl_WatchStatus
            // 
            this.lbl_WatchStatus.AutoSize = true;
            this.lbl_WatchStatus.Location = new System.Drawing.Point(191, 115);
            this.lbl_WatchStatus.Name = "lbl_WatchStatus";
            this.lbl_WatchStatus.Size = new System.Drawing.Size(72, 13);
            this.lbl_WatchStatus.TabIndex = 21;
            this.lbl_WatchStatus.Text = "Watch Status";
            // 
            // lbl_ReleaseStatus
            // 
            this.lbl_ReleaseStatus.AutoSize = true;
            this.lbl_ReleaseStatus.Location = new System.Drawing.Point(191, 155);
            this.lbl_ReleaseStatus.Name = "lbl_ReleaseStatus";
            this.lbl_ReleaseStatus.Size = new System.Drawing.Size(79, 13);
            this.lbl_ReleaseStatus.TabIndex = 22;
            this.lbl_ReleaseStatus.Text = "Release Status";
            // 
            // AnimeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 652);
            this.Controls.Add(this.lbl_ReleaseStatus);
            this.Controls.Add(this.lbl_WatchStatus);
            this.Controls.Add(this.cmb_ReleaseStatus);
            this.Controls.Add(this.cmb_WatchStatus);
            this.Controls.Add(this.lbl_EpisodeSeen);
            this.Controls.Add(this.lbl_EpisodeCount);
            this.Controls.Add(this.lbl_SeasonSeen);
            this.Controls.Add(this.lbl_SeasonAmoun);
            this.Controls.Add(this.lbl_Season);
            this.Controls.Add(this.lbl_Episode);
            this.Controls.Add(this.txb_SeasonSeen);
            this.Controls.Add(this.txb_SeasonCount);
            this.Controls.Add(this.txb_EpisodeSeen);
            this.Controls.Add(this.txb_EpisodeCount);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Tags);
            this.Controls.Add(this.txb_Tags);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txb_Title);
            this.Controls.Add(this.rtb_Description);
            this.Controls.Add(this.pcb_ImageDisplay);
            this.Name = "AnimeView";
            this.Text = "AnimeView";
            this.Load += new System.EventHandler(this.AnimeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_ImageDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_ImageDisplay;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.TextBox txb_Title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Tags;
        private System.Windows.Forms.TextBox txb_Tags;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txb_EpisodeCount;
        private System.Windows.Forms.TextBox txb_EpisodeSeen;
        private System.Windows.Forms.TextBox txb_SeasonSeen;
        private System.Windows.Forms.TextBox txb_SeasonCount;
        private System.Windows.Forms.Label lbl_Episode;
        private System.Windows.Forms.Label lbl_Season;
        private System.Windows.Forms.Label lbl_SeasonAmoun;
        private System.Windows.Forms.Label lbl_SeasonSeen;
        private System.Windows.Forms.Label lbl_EpisodeSeen;
        private System.Windows.Forms.Label lbl_EpisodeCount;
        private System.Windows.Forms.ComboBox cmb_WatchStatus;
        private System.Windows.Forms.ComboBox cmb_ReleaseStatus;
        private System.Windows.Forms.Label lbl_WatchStatus;
        private System.Windows.Forms.Label lbl_ReleaseStatus;
    }
}