namespace CalorieCoach.UI.FoodWiews
{
    partial class FoodItem
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
            lblFoodName = new Label();
            label2 = new Label();
            lblCategory = new Label();
            lblCaloriesPerUnitTitle = new Label();
            lblCaloriesPerUnit = new Label();
            pbFoodImage = new PictureBox();
            btnUpdate = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(167, 3);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Font = new Font("Segoe UI", 9F);
            lblFoodName.Location = new Point(167, 20);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(79, 15);
            lblFoodName.TabIndex = 0;
            lblFoodName.Text = "lblFoodName";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(167, 56);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "Category:";
           
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F);
            lblCategory.Location = new Point(167, 73);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "lblCategory";
            
            // 
            // lblCaloriesPerUnitTitle
            // 
            lblCaloriesPerUnitTitle.AutoSize = true;
            lblCaloriesPerUnitTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblCaloriesPerUnitTitle.Location = new Point(165, 111);
            lblCaloriesPerUnitTitle.Name = "lblCaloriesPerUnitTitle";
            lblCaloriesPerUnitTitle.Size = new Size(103, 17);
            lblCaloriesPerUnitTitle.TabIndex = 0;
            lblCaloriesPerUnitTitle.Text = "CaloriesPerUnit";
            // 
            // lblCaloriesPerUnit
            // 
            lblCaloriesPerUnit.AutoSize = true;
            lblCaloriesPerUnit.Location = new Point(165, 130);
            lblCaloriesPerUnit.Name = "lblCaloriesPerUnit";
            lblCaloriesPerUnit.Size = new Size(101, 15);
            lblCaloriesPerUnit.TabIndex = 0;
            lblCaloriesPerUnit.Text = "lblCaloriesPerUnit";
            // 
            // pbFoodImage
            // 
            pbFoodImage.Location = new Point(3, 3);
            pbFoodImage.Name = "pbFoodImage";
            pbFoodImage.Size = new Size(158, 142);
            pbFoodImage.TabIndex = 1;
            pbFoodImage.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Snow;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(296, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(77, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(167, 111);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 0;
            label3.Text = "CaloriesPerUnit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 130);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 0;
            label4.Text = "lblCaloriesPerUnit";
            // 
            // FoodItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(btnUpdate);
            Controls.Add(pbFoodImage);
            Controls.Add(label4);
            Controls.Add(lblCaloriesPerUnit);
            Controls.Add(label3);
            Controls.Add(lblCaloriesPerUnitTitle);
            Controls.Add(lblCategory);
            Controls.Add(label2);
            Controls.Add(lblFoodName);
            Controls.Add(label1);
            Name = "FoodItem";
            Size = new Size(392, 160);
            Load += FoodItem_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoodImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFoodName;
        private Label label2;
        private Label lblCategory;
        private Label lblCaloriesPerUnitTitle;
        private Label lblCaloriesPerUnit;
        private PictureBox pbFoodImage;
        private Button btnUpdate;
        private Label label3;
        private Label label4;
    }
}
