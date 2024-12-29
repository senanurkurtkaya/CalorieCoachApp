namespace CalorieCoach.UI.Views.MealRecordViews
{
    partial class NewMealRecord
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
            label1 = new Label();
            btnCancel = new Button();
            btnAddFood = new Button();
            flpFoods = new FlowLayoutPanel();
            cbMealTypes = new ComboBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "MealType";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancel.Location = new Point(294, 27);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAddFood.Location = new Point(12, 99);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 23);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add Food";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // flpFoods
            // 
            flpFoods.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpFoods.AutoScroll = true;
            flpFoods.BackColor = Color.Silver;
            flpFoods.Location = new Point(12, 128);
            flpFoods.Name = "flpFoods";
            flpFoods.Size = new Size(470, 161);
            flpFoods.TabIndex = 3;
            // 
            // cbMealTypes
            // 
            cbMealTypes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            cbMealTypes.FormattingEnabled = true;
            cbMealTypes.Location = new Point(12, 27);
            cbMealTypes.Name = "cbMealTypes";
            cbMealTypes.Size = new Size(121, 25);
            cbMealTypes.TabIndex = 4;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubmit.Location = new Point(385, 29);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // NewMealRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(494, 301);
            Controls.Add(cbMealTypes);
            Controls.Add(flpFoods);
            Controls.Add(btnAddFood);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Name = "NewMealRecord";
            Text = "NewMealRecord";
            Load += NewMealRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private Button btnAddFood;
        private FlowLayoutPanel flpFoods;
        private ComboBox cbMealTypes;
        private Button btnSubmit;
    }
}