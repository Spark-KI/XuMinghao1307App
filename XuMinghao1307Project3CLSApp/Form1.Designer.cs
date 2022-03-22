namespace XuMinghao1307Project3CLSApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtProcessedFile = new System.Windows.Forms.TextBox();
            this.optGenerateLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.listEvents = new System.Windows.Forms.ListBox();
            this.groupEventLog = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewsSummary = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupEventLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(25, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.optGenerateLog);
            this.tabSource.Controls.Add(this.txtProcessedFile);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.label1);
            this.tabSource.ImageIndex = 0;
            this.tabSource.Location = new System.Drawing.Point(4, 28);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(545, 355);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "Source option";
            this.tabSource.UseVisualStyleBackColor = true;
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewsSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.groupEventLog);
            this.tabDest.Controls.Add(this.txtDest);
            this.tabDest.Controls.Add(this.label3);
            this.tabDest.ImageIndex = 1;
            this.tabDest.Location = new System.Drawing.Point(4, 28);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(545, 355);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "Destination Options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons-390 (2).jpg");
            this.imageList1.Images.SetKeyName(1, "icons-390.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Processing.Move source file to:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(201, 41);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(169, 28);
            this.txtSource.TabIndex = 2;
            // 
            // txtProcessedFile
            // 
            this.txtProcessedFile.Location = new System.Drawing.Point(32, 159);
            this.txtProcessedFile.Name = "txtProcessedFile";
            this.txtProcessedFile.Size = new System.Drawing.Size(338, 28);
            this.txtProcessedFile.TabIndex = 3;
            // 
            // optGenerateLog
            // 
            this.optGenerateLog.AutoSize = true;
            this.optGenerateLog.Location = new System.Drawing.Point(32, 245);
            this.optGenerateLog.Name = "optGenerateLog";
            this.optGenerateLog.Size = new System.Drawing.Size(376, 22);
            this.optGenerateLog.TabIndex = 4;
            this.optGenerateLog.Text = "Generate event log for bed file format";
            this.optGenerateLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Directory";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(247, 29);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(227, 28);
            this.txtDest.TabIndex = 1;
            // 
            // listEvents
            // 
            this.listEvents.FormattingEnabled = true;
            this.listEvents.ItemHeight = 18;
            this.listEvents.Location = new System.Drawing.Point(28, 27);
            this.listEvents.Name = "listEvents";
            this.listEvents.Size = new System.Drawing.Size(371, 202);
            this.listEvents.TabIndex = 2;
            // 
            // groupEventLog
            // 
            this.groupEventLog.Controls.Add(this.listEvents);
            this.groupEventLog.Location = new System.Drawing.Point(47, 63);
            this.groupEventLog.Name = "groupEventLog";
            this.groupEventLog.Size = new System.Drawing.Size(427, 246);
            this.groupEventLog.TabIndex = 3;
            this.groupEventLog.TabStop = false;
            this.groupEventLog.Text = "groupBox1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(47, 315);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(126, 34);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnViewsSummary
            // 
            this.btnViewsSummary.Location = new System.Drawing.Point(179, 315);
            this.btnViewsSummary.Name = "btnViewsSummary";
            this.btnViewsSummary.Size = new System.Drawing.Size(124, 33);
            this.btnViewsSummary.TabIndex = 5;
            this.btnViewsSummary.Text = "View Summary";
            this.btnViewsSummary.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(257, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupEventLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.CheckBox optGenerateLog;
        private System.Windows.Forms.TextBox txtProcessedFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnViewsSummary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupEventLog;
        private System.Windows.Forms.ListBox listEvents;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}

