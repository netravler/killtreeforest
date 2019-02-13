namespace KillTree
{
    partial class Form1
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
            this.btnKillTree = new System.Windows.Forms.Button();
            this.tbKillProcess = new System.Windows.Forms.TextBox();
            this.rtbKillTree = new System.Windows.Forms.RichTextBox();
            this.tbFindProcess = new System.Windows.Forms.TextBox();
            this.btnFindProcess = new System.Windows.Forms.Button();
            this.btnKillForest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKillTree
            // 
            this.btnKillTree.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKillTree.Location = new System.Drawing.Point(12, 38);
            this.btnKillTree.Name = "btnKillTree";
            this.btnKillTree.Size = new System.Drawing.Size(221, 23);
            this.btnKillTree.TabIndex = 0;
            this.btnKillTree.Text = "KillTree";
            this.btnKillTree.UseVisualStyleBackColor = false;
            this.btnKillTree.Click += new System.EventHandler(this.btnKillTree_Click);
            // 
            // tbKillProcess
            // 
            this.tbKillProcess.BackColor = System.Drawing.Color.LightGray;
            this.tbKillProcess.Location = new System.Drawing.Point(12, 12);
            this.tbKillProcess.Name = "tbKillProcess";
            this.tbKillProcess.Size = new System.Drawing.Size(453, 20);
            this.tbKillProcess.TabIndex = 1;
            // 
            // rtbKillTree
            // 
            this.rtbKillTree.BackColor = System.Drawing.Color.LightGray;
            this.rtbKillTree.Location = new System.Drawing.Point(12, 126);
            this.rtbKillTree.Name = "rtbKillTree";
            this.rtbKillTree.Size = new System.Drawing.Size(453, 505);
            this.rtbKillTree.TabIndex = 2;
            this.rtbKillTree.Text = "";
            this.rtbKillTree.Click += new System.EventHandler(this.rtbKillTree_Click_1);
            this.rtbKillTree.TextChanged += new System.EventHandler(this.rtbKillTree_TextChanged);
            // 
            // tbFindProcess
            // 
            this.tbFindProcess.BackColor = System.Drawing.Color.LightGray;
            this.tbFindProcess.Location = new System.Drawing.Point(12, 67);
            this.tbFindProcess.Name = "tbFindProcess";
            this.tbFindProcess.Size = new System.Drawing.Size(453, 20);
            this.tbFindProcess.TabIndex = 3;
            // 
            // btnFindProcess
            // 
            this.btnFindProcess.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFindProcess.Location = new System.Drawing.Point(12, 93);
            this.btnFindProcess.Name = "btnFindProcess";
            this.btnFindProcess.Size = new System.Drawing.Size(453, 23);
            this.btnFindProcess.TabIndex = 4;
            this.btnFindProcess.Text = "Find Process";
            this.btnFindProcess.UseVisualStyleBackColor = false;
            this.btnFindProcess.Click += new System.EventHandler(this.btnFindProcess_Click);
            // 
            // btnKillForest
            // 
            this.btnKillForest.BackColor = System.Drawing.Color.OrangeRed;
            this.btnKillForest.Location = new System.Drawing.Point(244, 38);
            this.btnKillForest.Name = "btnKillForest";
            this.btnKillForest.Size = new System.Drawing.Size(221, 23);
            this.btnKillForest.TabIndex = 5;
            this.btnKillForest.Text = "KillForest";
            this.btnKillForest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKillForest.UseVisualStyleBackColor = false;
            this.btnKillForest.Click += new System.EventHandler(this.btnKillForest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 643);
            this.Controls.Add(this.btnKillForest);
            this.Controls.Add(this.btnFindProcess);
            this.Controls.Add(this.tbFindProcess);
            this.Controls.Add(this.rtbKillTree);
            this.Controls.Add(this.tbKillProcess);
            this.Controls.Add(this.btnKillTree);
            this.Name = "Form1";
            this.Text = "Kill Process Tree - Forest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKillTree;
        private System.Windows.Forms.TextBox tbKillProcess;
        private System.Windows.Forms.RichTextBox rtbKillTree;
        private System.Windows.Forms.TextBox tbFindProcess;
        private System.Windows.Forms.Button btnFindProcess;
        private System.Windows.Forms.Button btnKillForest;
    }
}

