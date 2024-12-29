namespace CalorieCoach.UI.Views.MainPageViews
{
    partial class MainPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            flpUserReports = new FlowLayoutPanel();
            groupBox2 = new GroupBox();
            flpGeneralReports = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(flpUserReports);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.Location = new Point(29, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "special for you";
            // 
            // flpUserReports
            // 
            flpUserReports.Location = new Point(6, 24);
            flpUserReports.Name = "flpUserReports";
            flpUserReports.Size = new Size(610, 197);
            flpUserReports.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flpGeneralReports);
            groupBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox2.Location = new Point(29, 263);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(622, 257);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "General Reports";
            // 
            // flpGeneralReports
            // 
            flpGeneralReports.Location = new Point(6, 24);
            flpGeneralReports.Name = "flpGeneralReports";
            flpGeneralReports.Size = new Size(606, 227);
            flpGeneralReports.TabIndex = 1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainPage";
            Size = new Size(668, 551);
            Load += MainPager_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flpUserReports;
        private FlowLayoutPanel flpGeneralReports;
    }
}
