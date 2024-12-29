namespace CalorieCoach.UI
{
    partial class MainPageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            flpMain = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tsLogout = new ToolStripMenuItem();
            tsExit = new ToolStripMenuItem();
            tsMainPage = new ToolStripMenuItem();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            tsNewRecord = new ToolStripMenuItem();
            tsMealRecords = new ToolStripMenuItem();
            foodManagementToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            tsFoodCategories = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // flpMain
            // 
            flpMain.Location = new Point(0, 31);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(913, 478);
            flpMain.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ToolStripMenuItem1, foodManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(914, 25);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsLogout, tsExit, tsMainPage });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            fileToolStripMenuItem.Image = Properties.Resources.FolderOpened;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(58, 21);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsLogout
            // 
            tsLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tsLogout.Name = "tsLogout";
            tsLogout.Size = new Size(123, 22);
            tsLogout.Text = "Logout";
            tsLogout.Click += tsLogout_Click;
            // 
            // tsExit
            // 
            tsExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tsExit.Image = Properties.Resources.Exit;
            tsExit.Name = "tsExit";
            tsExit.Size = new Size(123, 22);
            tsExit.Text = "Exit";
            tsExit.Click += tsExit_Click;
            // 
            // tsMainPage
            // 
            tsMainPage.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            tsMainPage.Name = "tsMainPage";
            tsMainPage.Size = new Size(123, 22);
            tsMainPage.Text = "Reports";
            tsMainPage.Click += tsMainPage_Click;
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { tsNewRecord, tsMealRecords });
            ToolStripMenuItem1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ToolStripMenuItem1.Image = Properties.Resources._3407785_200;
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.Size = new Size(114, 21);
            ToolStripMenuItem1.Text = "MealRecords";
            // 
            // tsNewRecord
            // 
            tsNewRecord.Image = Properties.Resources._4556267_2001;
            tsNewRecord.Name = "tsNewRecord";
            tsNewRecord.Size = new Size(180, 22);
            tsNewRecord.Text = "New Record";
            tsNewRecord.Click += tsNewRecord_Click;
            // 
            // tsMealRecords
            // 
            tsMealRecords.Image = (Image)resources.GetObject("tsMealRecords.Image");
            tsMealRecords.Name = "tsMealRecords";
            tsMealRecords.Size = new Size(180, 22);
            tsMealRecords.Text = "Record";
            tsMealRecords.Click += tsMealRecords_Click;
            // 
            // foodManagementToolStripMenuItem
            // 
            foodManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8, tsFoodCategories });
            foodManagementToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            foodManagementToolStripMenuItem.Image = Properties.Resources._4556267_200;
            foodManagementToolStripMenuItem.Name = "foodManagementToolStripMenuItem";
            foodManagementToolStripMenuItem.Size = new Size(148, 21);
            foodManagementToolStripMenuItem.Text = "FoodManagement";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Image = Properties.Resources._3935622_200;
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(176, 22);
            toolStripMenuItem7.Text = "New Food";
            toolStripMenuItem7.Click += toolStripMenuItem7_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Image = Properties.Resources.meal_icon__1_;
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(176, 22);
            toolStripMenuItem8.Text = "Foods";
            toolStripMenuItem8.Click += toolStripMenuItem8_Click;
            // 
            // tsFoodCategories
            // 
            tsFoodCategories.Image = Properties.Resources._2995212_200;
            tsFoodCategories.Name = "tsFoodCategories";
            tsFoodCategories.Size = new Size(176, 22);
            tsFoodCategories.Text = "Food Categories";
            tsFoodCategories.Click += tsFoodCategories_Click;
            // 
            // MainPageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(flpMain);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "MainPageForm";
            Text = "MainPageForm";
            Load += MainPageForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsLogout;
        private ToolStripMenuItem tsExit;
        private ToolStripMenuItem foodManagementToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem tsFoodCategories;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem tsNewRecord;
        private ToolStripMenuItem tsMealRecords;
        private ToolStripMenuItem tsMainPage;
    }
}