namespace FolderMaker
{
    partial class FolderMaker
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
            this.TB_FileDestination = new System.Windows.Forms.TextBox();
            this.LB_FileDestination = new System.Windows.Forms.Label();
            this.BTN_FindLocation = new System.Windows.Forms.Button();
            this.LB_NumberOfFolders = new System.Windows.Forms.Label();
            this.TB_FolderAmount = new System.Windows.Forms.TextBox();
            this.CB_SubFolders = new System.Windows.Forms.CheckBox();
            this.GB_SubFolders = new System.Windows.Forms.GroupBox();
            this.TB_SubFolderName = new System.Windows.Forms.TextBox();
            this.LB_SubFolderName = new System.Windows.Forms.Label();
            this.TB_FolderName = new System.Windows.Forms.TextBox();
            this.LB_FolderName = new System.Windows.Forms.Label();
            this.BTN_CreateFolder = new System.Windows.Forms.Button();
            this.GB_SubFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_FileDestination
            // 
            this.TB_FileDestination.Location = new System.Drawing.Point(111, 79);
            this.TB_FileDestination.Name = "TB_FileDestination";
            this.TB_FileDestination.Size = new System.Drawing.Size(416, 20);
            this.TB_FileDestination.TabIndex = 0;
            // 
            // LB_FileDestination
            // 
            this.LB_FileDestination.AutoSize = true;
            this.LB_FileDestination.Location = new System.Drawing.Point(12, 82);
            this.LB_FileDestination.Name = "LB_FileDestination";
            this.LB_FileDestination.Size = new System.Drawing.Size(79, 13);
            this.LB_FileDestination.TabIndex = 1;
            this.LB_FileDestination.Text = "File Destination";
            // 
            // BTN_FindLocation
            // 
            this.BTN_FindLocation.Location = new System.Drawing.Point(533, 77);
            this.BTN_FindLocation.Name = "BTN_FindLocation";
            this.BTN_FindLocation.Size = new System.Drawing.Size(28, 23);
            this.BTN_FindLocation.TabIndex = 2;
            this.BTN_FindLocation.Text = "...";
            this.BTN_FindLocation.UseVisualStyleBackColor = true;
            this.BTN_FindLocation.Click += new System.EventHandler(this.BTN_FindLocation_Click);
            // 
            // LB_NumberOfFolders
            // 
            this.LB_NumberOfFolders.AutoSize = true;
            this.LB_NumberOfFolders.Location = new System.Drawing.Point(12, 118);
            this.LB_NumberOfFolders.Name = "LB_NumberOfFolders";
            this.LB_NumberOfFolders.Size = new System.Drawing.Size(75, 13);
            this.LB_NumberOfFolders.TabIndex = 3;
            this.LB_NumberOfFolders.Text = "Folder Amount";
            // 
            // TB_FolderAmount
            // 
            this.TB_FolderAmount.Location = new System.Drawing.Point(111, 115);
            this.TB_FolderAmount.Name = "TB_FolderAmount";
            this.TB_FolderAmount.Size = new System.Drawing.Size(100, 20);
            this.TB_FolderAmount.TabIndex = 4;
            // 
            // CB_SubFolders
            // 
            this.CB_SubFolders.AutoSize = true;
            this.CB_SubFolders.Location = new System.Drawing.Point(15, 192);
            this.CB_SubFolders.Name = "CB_SubFolders";
            this.CB_SubFolders.Size = new System.Drawing.Size(82, 17);
            this.CB_SubFolders.TabIndex = 5;
            this.CB_SubFolders.Text = "Sub-Folders";
            this.CB_SubFolders.UseVisualStyleBackColor = true;
            this.CB_SubFolders.CheckedChanged += new System.EventHandler(this.CB_SubFolders_CheckedChanged);
            // 
            // GB_SubFolders
            // 
            this.GB_SubFolders.Controls.Add(this.TB_SubFolderName);
            this.GB_SubFolders.Controls.Add(this.LB_SubFolderName);
            this.GB_SubFolders.Enabled = false;
            this.GB_SubFolders.Location = new System.Drawing.Point(17, 215);
            this.GB_SubFolders.Name = "GB_SubFolders";
            this.GB_SubFolders.Size = new System.Drawing.Size(546, 127);
            this.GB_SubFolders.TabIndex = 6;
            this.GB_SubFolders.TabStop = false;
            // 
            // TB_SubFolderName
            // 
            this.TB_SubFolderName.Location = new System.Drawing.Point(104, 19);
            this.TB_SubFolderName.Name = "TB_SubFolderName";
            this.TB_SubFolderName.Size = new System.Drawing.Size(169, 20);
            this.TB_SubFolderName.TabIndex = 10;
            // 
            // LB_SubFolderName
            // 
            this.LB_SubFolderName.AutoSize = true;
            this.LB_SubFolderName.Location = new System.Drawing.Point(5, 22);
            this.LB_SubFolderName.Name = "LB_SubFolderName";
            this.LB_SubFolderName.Size = new System.Drawing.Size(89, 13);
            this.LB_SubFolderName.TabIndex = 9;
            this.LB_SubFolderName.Text = "Sub-Folder Name";
            // 
            // TB_FolderName
            // 
            this.TB_FolderName.Location = new System.Drawing.Point(111, 153);
            this.TB_FolderName.Name = "TB_FolderName";
            this.TB_FolderName.Size = new System.Drawing.Size(169, 20);
            this.TB_FolderName.TabIndex = 8;
            // 
            // LB_FolderName
            // 
            this.LB_FolderName.AutoSize = true;
            this.LB_FolderName.Location = new System.Drawing.Point(12, 156);
            this.LB_FolderName.Name = "LB_FolderName";
            this.LB_FolderName.Size = new System.Drawing.Size(67, 13);
            this.LB_FolderName.TabIndex = 7;
            this.LB_FolderName.Text = "Folder Name";
            // 
            // BTN_CreateFolder
            // 
            this.BTN_CreateFolder.Location = new System.Drawing.Point(446, 358);
            this.BTN_CreateFolder.Name = "BTN_CreateFolder";
            this.BTN_CreateFolder.Size = new System.Drawing.Size(115, 43);
            this.BTN_CreateFolder.TabIndex = 9;
            this.BTN_CreateFolder.Text = "Create Folder";
            this.BTN_CreateFolder.UseVisualStyleBackColor = true;
            this.BTN_CreateFolder.Click += new System.EventHandler(this.BTN_CreateFolder_Click);
            // 
            // FolderMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 426);
            this.Controls.Add(this.BTN_CreateFolder);
            this.Controls.Add(this.TB_FolderName);
            this.Controls.Add(this.LB_FolderName);
            this.Controls.Add(this.GB_SubFolders);
            this.Controls.Add(this.CB_SubFolders);
            this.Controls.Add(this.TB_FolderAmount);
            this.Controls.Add(this.LB_NumberOfFolders);
            this.Controls.Add(this.BTN_FindLocation);
            this.Controls.Add(this.LB_FileDestination);
            this.Controls.Add(this.TB_FileDestination);
            this.Name = "FolderMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Maker";
            this.Load += new System.EventHandler(this.FolderMaker_Load);
            this.GB_SubFolders.ResumeLayout(false);
            this.GB_SubFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_FileDestination;
        private System.Windows.Forms.Label LB_FileDestination;
        private System.Windows.Forms.Button BTN_FindLocation;
        private System.Windows.Forms.Label LB_NumberOfFolders;
        private System.Windows.Forms.TextBox TB_FolderAmount;
        private System.Windows.Forms.CheckBox CB_SubFolders;
        private System.Windows.Forms.GroupBox GB_SubFolders;
        private System.Windows.Forms.TextBox TB_FolderName;
        private System.Windows.Forms.Label LB_FolderName;
        private System.Windows.Forms.TextBox TB_SubFolderName;
        private System.Windows.Forms.Label LB_SubFolderName;
        private System.Windows.Forms.Button BTN_CreateFolder;
    }
}

