namespace FolderMaker
{
    partial class FolderNames
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_MainFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_SubFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_ChangeFolderName = new System.Windows.Forms.Button();
            this.BTN_Finish = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_MainFolderName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TB_MainFolderName
            // 
            this.TB_MainFolderName.Location = new System.Drawing.Point(114, 19);
            this.TB_MainFolderName.Name = "TB_MainFolderName";
            this.TB_MainFolderName.Size = new System.Drawing.Size(215, 20);
            this.TB_MainFolderName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Folder Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_SubFolderName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 55);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // TB_SubFolderName
            // 
            this.TB_SubFolderName.Location = new System.Drawing.Point(114, 19);
            this.TB_SubFolderName.Name = "TB_SubFolderName";
            this.TB_SubFolderName.Size = new System.Drawing.Size(215, 20);
            this.TB_SubFolderName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sub Folder Name";
            // 
            // BTN_ChangeFolderName
            // 
            this.BTN_ChangeFolderName.Location = new System.Drawing.Point(29, 14);
            this.BTN_ChangeFolderName.Name = "BTN_ChangeFolderName";
            this.BTN_ChangeFolderName.Size = new System.Drawing.Size(75, 23);
            this.BTN_ChangeFolderName.TabIndex = 2;
            this.BTN_ChangeFolderName.Text = "Change";
            this.BTN_ChangeFolderName.UseVisualStyleBackColor = true;
            this.BTN_ChangeFolderName.Click += new System.EventHandler(this.BTN_ChangeFolderName_Click);
            // 
            // BTN_Finish
            // 
            this.BTN_Finish.Location = new System.Drawing.Point(125, 14);
            this.BTN_Finish.Name = "BTN_Finish";
            this.BTN_Finish.Size = new System.Drawing.Size(75, 23);
            this.BTN_Finish.TabIndex = 3;
            this.BTN_Finish.Text = "Finish";
            this.BTN_Finish.UseVisualStyleBackColor = true;
            this.BTN_Finish.Click += new System.EventHandler(this.BTN_Finish_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Finish);
            this.groupBox3.Controls.Add(this.BTN_ChangeFolderName);
            this.groupBox3.Location = new System.Drawing.Point(74, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // FolderNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 293);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FolderNames";
            this.Load += new System.EventHandler(this.FolderNames_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_MainFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_SubFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_ChangeFolderName;
        private System.Windows.Forms.Button BTN_Finish;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}