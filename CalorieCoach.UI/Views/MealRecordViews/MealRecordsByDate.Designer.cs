namespace CalorieCoach.UI.Views.MealRecordViews
{
    partial class MealRecordsByDate
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
            flpMainContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpMainContainer
            // 
            flpMainContainer.BackColor = Color.LightGray;
            flpMainContainer.Location = new Point(3, 3);
            flpMainContainer.Name = "flpMainContainer";
            flpMainContainer.Size = new Size(427, 707);
            flpMainContainer.TabIndex = 0;
            // 
            // MealRecordsByDate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpMainContainer);
            Name = "MealRecordsByDate";
            Size = new Size(433, 717);
            Load += MealRecordsByDate_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpMainContainer;
    }
}
