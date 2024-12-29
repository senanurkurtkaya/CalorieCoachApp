namespace CalorieCoach.UI.Views.MealRecordViews
{
    partial class AddFoodToMeal
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
            label1 = new Label();
            label2 = new Label();
            numPortion = new NumericUpDown();
            button1 = new Button();
            cbFood = new ComboBox();
            lblUnit = new Label();
            ((System.ComponentModel.ISupportInitialize)numPortion).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 0;
            label1.Text = "Food";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(188, 13);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 0;
            label2.Text = "Portion";
            // 
            // numPortion
            // 
            numPortion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            numPortion.Location = new Point(188, 46);
            numPortion.Name = "numPortion";
            numPortion.Size = new Size(155, 25);
            numPortion.TabIndex = 1;
            numPortion.ValueChanged += numPortion_ValueChanged;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.Remove;
            button1.Location = new Point(411, 46);
            button1.Name = "button1";
            button1.Size = new Size(63, 28);
            button1.TabIndex = 2;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbFood
            // 
            cbFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(13, 46);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(155, 25);
            cbFood.TabIndex = 3;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(343, 46);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(0, 15);
            lblUnit.TabIndex = 3;
            // 
            // AddFoodToMeal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            Controls.Add(lblUnit);
            Controls.Add(cbFood);
            Controls.Add(button1);
            Controls.Add(numPortion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFoodToMeal";
            Size = new Size(520, 116);
            Load += AddFoodToMeal_Load;
            ((System.ComponentModel.ISupportInitialize)numPortion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numPortion;
        private Button button1;
        private ComboBox cbFood;
        private Label lblUnit;
    }
}
