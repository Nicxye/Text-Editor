namespace Text_Editor
{
    partial class frmCompareMenu
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
            this.rtbOldFile = new System.Windows.Forms.RichTextBox();
            this.rtbNewFile = new System.Windows.Forms.RichTextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblOldFile = new System.Windows.Forms.Label();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.btnLoadOld = new System.Windows.Forms.Button();
            this.btnLoadNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOldFile
            // 
            this.rtbOldFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbOldFile.Location = new System.Drawing.Point(33, 53);
            this.rtbOldFile.MaximumSize = new System.Drawing.Size(1000, 1201);
            this.rtbOldFile.MinimumSize = new System.Drawing.Size(639, 726);
            this.rtbOldFile.Name = "rtbOldFile";
            this.rtbOldFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbOldFile.Size = new System.Drawing.Size(639, 726);
            this.rtbOldFile.TabIndex = 0;
            this.rtbOldFile.Text = "";
            // 
            // rtbNewFile
            // 
            this.rtbNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNewFile.Location = new System.Drawing.Point(851, 65);
            this.rtbNewFile.MaximumSize = new System.Drawing.Size(1000, 1201);
            this.rtbNewFile.MinimumSize = new System.Drawing.Size(639, 726);
            this.rtbNewFile.Name = "rtbNewFile";
            this.rtbNewFile.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbNewFile.Size = new System.Drawing.Size(639, 726);
            this.rtbNewFile.TabIndex = 1;
            this.rtbNewFile.Text = "";
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(706, 340);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(84, 30);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblOldFile
            // 
            this.lblOldFile.AutoSize = true;
            this.lblOldFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldFile.Location = new System.Drawing.Point(28, 22);
            this.lblOldFile.Name = "lblOldFile";
            this.lblOldFile.Size = new System.Drawing.Size(129, 25);
            this.lblOldFile.TabIndex = 3;
            this.lblOldFile.Text = "Load old file";
            // 
            // lblNewFile
            // 
            this.lblNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFile.Location = new System.Drawing.Point(846, 20);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(139, 25);
            this.lblNewFile.TabIndex = 4;
            this.lblNewFile.Text = "Load new file";
            // 
            // btnLoadOld
            // 
            this.btnLoadOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadOld.Location = new System.Drawing.Point(163, 24);
            this.btnLoadOld.Name = "btnLoadOld";
            this.btnLoadOld.Size = new System.Drawing.Size(75, 23);
            this.btnLoadOld.TabIndex = 5;
            this.btnLoadOld.Text = "Load";
            this.btnLoadOld.UseVisualStyleBackColor = true;
            this.btnLoadOld.Click += new System.EventHandler(this.btnLoadOld_Click);
            // 
            // btnLoadNew
            // 
            this.btnLoadNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadNew.Location = new System.Drawing.Point(991, 22);
            this.btnLoadNew.Name = "btnLoadNew";
            this.btnLoadNew.Size = new System.Drawing.Size(75, 23);
            this.btnLoadNew.TabIndex = 6;
            this.btnLoadNew.Text = "Load";
            this.btnLoadNew.UseVisualStyleBackColor = true;
            this.btnLoadNew.Click += new System.EventHandler(this.btnLoadNew_Click);
            // 
            // frmCompareMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 816);
            this.Controls.Add(this.btnLoadNew);
            this.Controls.Add(this.btnLoadOld);
            this.Controls.Add(this.lblNewFile);
            this.Controls.Add(this.lblOldFile);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.rtbNewFile);
            this.Controls.Add(this.rtbOldFile);
            this.MinimumSize = new System.Drawing.Size(1555, 855);
            this.Name = "frmCompareMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compare files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOldFile;
        private System.Windows.Forms.RichTextBox rtbNewFile;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblOldFile;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.Button btnLoadOld;
        private System.Windows.Forms.Button btnLoadNew;
    }
}