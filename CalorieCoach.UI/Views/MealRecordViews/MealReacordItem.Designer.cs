namespace CalorieCoach.UI.Views.MealRecordViews
{
    partial class MealRecordItem
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
            flpFoodPortions = new FlowLayoutPanel();
            lblMealType = new Label();
            lblTime = new Label();
            label4 = new Label();
            lblCalories = new Label();
            SuspendLayout();
            // 
            // flpFoodPortions
            // 
            flpFoodPortions.Location = new Point(17, 49);
            flpFoodPortions.Name = "flpFoodPortions";
            flpFoodPortions.Size = new Size(283, 128);
            flpFoodPortions.TabIndex = 1;
            // 
            // lblMealType
            // 
            lblMealType.AutoSize = true;
            lblMealType.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblMealType.Location = new Point(17, 16);
            lblMealType.Name = "lblMealType";
            lblMealType.Size = new Size(45, 17);
            lblMealType.TabIndex = 0;
            lblMealType.Text = "label1";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblTime.Location = new Point(96, 16);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(45, 17);
            lblTime.TabIndex = 0;
            lblTime.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(322, 70);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 0;
            label4.Text = "TotalCalories";
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCalories.Location = new Point(322, 100);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(45, 17);
            lblCalories.TabIndex = 0;
            lblCalories.Text = "label2";
            // 
            // MealRecordItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(lblCalories);
            Controls.Add(label4);
            Controls.Add(lblTime);
            Controls.Add(lblMealType);
            Controls.Add(flpFoodPortions);
            Name = "MealRecordItem";
            Size = new Size(429, 204);
            Load += MealReacordItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpFoodPortions;
        private Label lblMealType;
        private Label lblTime;
        private Label label4;
        private Label lblCalories;
    }
}
