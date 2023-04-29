namespace Frontend
{
    partial class MainViewForm
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
            this.tbc_ModelView = new System.Windows.Forms.TabControl();
            this.tbp_Anime = new System.Windows.Forms.TabPage();
            this.dgv_Anime = new System.Windows.Forms.DataGridView();
            this.tbp_Manga = new System.Windows.Forms.TabPage();
            this.dgv_Manga = new System.Windows.Forms.DataGridView();
            this.btn_New = new System.Windows.Forms.Button();
            this.tbc_ModelView.SuspendLayout();
            this.tbp_Anime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anime)).BeginInit();
            this.tbp_Manga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manga)).BeginInit();
            this.SuspendLayout();
            // 
            // tbc_ModelView
            // 
            this.tbc_ModelView.Controls.Add(this.tbp_Anime);
            this.tbc_ModelView.Controls.Add(this.tbp_Manga);
            this.tbc_ModelView.Location = new System.Drawing.Point(12, 164);
            this.tbc_ModelView.Name = "tbc_ModelView";
            this.tbc_ModelView.SelectedIndex = 0;
            this.tbc_ModelView.Size = new System.Drawing.Size(1360, 585);
            this.tbc_ModelView.TabIndex = 0;
            // 
            // tbp_Anime
            // 
            this.tbp_Anime.Controls.Add(this.dgv_Anime);
            this.tbp_Anime.Location = new System.Drawing.Point(4, 22);
            this.tbp_Anime.Name = "tbp_Anime";
            this.tbp_Anime.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Anime.Size = new System.Drawing.Size(1352, 559);
            this.tbp_Anime.TabIndex = 0;
            this.tbp_Anime.Text = "Anime";
            this.tbp_Anime.UseVisualStyleBackColor = true;
            // 
            // dgv_Anime
            // 
            this.dgv_Anime.AllowUserToAddRows = false;
            this.dgv_Anime.AllowUserToDeleteRows = false;
            this.dgv_Anime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Anime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Anime.Location = new System.Drawing.Point(3, 3);
            this.dgv_Anime.Name = "dgv_Anime";
            this.dgv_Anime.ReadOnly = true;
            this.dgv_Anime.Size = new System.Drawing.Size(1346, 553);
            this.dgv_Anime.TabIndex = 0;
            // 
            // tbp_Manga
            // 
            this.tbp_Manga.Controls.Add(this.dgv_Manga);
            this.tbp_Manga.Location = new System.Drawing.Point(4, 22);
            this.tbp_Manga.Name = "tbp_Manga";
            this.tbp_Manga.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Manga.Size = new System.Drawing.Size(1352, 559);
            this.tbp_Manga.TabIndex = 1;
            this.tbp_Manga.Text = "Manga";
            this.tbp_Manga.UseVisualStyleBackColor = true;
            // 
            // dgv_Manga
            // 
            this.dgv_Manga.AllowUserToAddRows = false;
            this.dgv_Manga.AllowUserToDeleteRows = false;
            this.dgv_Manga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Manga.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Manga.Location = new System.Drawing.Point(3, 3);
            this.dgv_Manga.Name = "dgv_Manga";
            this.dgv_Manga.ReadOnly = true;
            this.dgv_Manga.Size = new System.Drawing.Size(1346, 553);
            this.dgv_Manga.TabIndex = 0;
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(19, 28);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(169, 93);
            this.btn_New.TabIndex = 1;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            // 
            // MainViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.tbc_ModelView);
            this.Name = "MainViewForm";
            this.Text = "Archive Sorting Program";
            this.tbc_ModelView.ResumeLayout(false);
            this.tbp_Anime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Anime)).EndInit();
            this.tbp_Manga.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Manga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_ModelView;
        private System.Windows.Forms.TabPage tbp_Anime;
        private System.Windows.Forms.DataGridView dgv_Anime;
        private System.Windows.Forms.TabPage tbp_Manga;
        private System.Windows.Forms.DataGridView dgv_Manga;
        private System.Windows.Forms.Button btn_New;
    }
}

