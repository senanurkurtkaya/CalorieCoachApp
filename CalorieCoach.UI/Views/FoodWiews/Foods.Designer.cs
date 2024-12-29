namespace CalorieCoach.UI.FoodWiews
{
    partial class Foods
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
            flpFoodItems = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpFoodItems
            // 
            flpFoodItems.Anchor = AnchorStyles.None;
            flpFoodItems.BackColor = Color.LightGray;
            flpFoodItems.Location = new Point(3, 3);
            flpFoodItems.Name = "flpFoodItems";
            flpFoodItems.RightToLeft = RightToLeft.No;
            flpFoodItems.Size = new Size(412, 509);
            flpFoodItems.TabIndex = 0;
            // 
            // Foods
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(flpFoodItems);
            Name = "Foods";
            Size = new Size(418, 515);
            Load += Foods_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpFoodItems;
    }
}
