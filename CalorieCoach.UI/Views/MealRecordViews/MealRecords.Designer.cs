namespace CalorieCoach.UI.Views.MealRecordViews
{
    partial class MealRecords
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
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dtpMealRecordDate = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(326, 16);
            button1.Name = "button1";
            button1.Size = new Size(122, 26);
            button1.TabIndex = 1;
            button1.Text = "New Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 80);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(448, 412);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // dtpMealRecordDate
            // 
            dtpMealRecordDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dtpMealRecordDate.Location = new Point(14, 15);
            dtpMealRecordDate.Name = "dtpMealRecordDate";
            dtpMealRecordDate.Size = new Size(228, 25);
            dtpMealRecordDate.TabIndex = 3;
            dtpMealRecordDate.ValueChanged += dtpMealRecordDate_ValueChanged;
            // 
            // MealRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(dtpMealRecordDate);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "MealRecords";
            Size = new Size(451, 494);
            Load += MealRecords_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dtpMealRecordDate;
    }
}
