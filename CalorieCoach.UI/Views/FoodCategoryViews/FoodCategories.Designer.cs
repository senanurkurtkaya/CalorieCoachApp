namespace CalorieCoach.UI.Views.FoodCategoryViews
{
    partial class FoodCategories
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
            txtNewCategory = new TextBox();
            txtUpdateFoodCategory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            lbFoodCategories = new ListBox();
            hScrollBar1 = new HScrollBar();
            SuspendLayout();
            // 
            // txtNewCategory
            // 
            txtNewCategory.Location = new Point(129, 92);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(143, 25);
            txtNewCategory.TabIndex = 0;
            txtNewCategory.TextChanged += txtNewCategory_TextChanged;
            // 
            // txtUpdateFoodCategory
            // 
            txtUpdateFoodCategory.Location = new Point(129, 133);
            txtUpdateFoodCategory.Name = "txtUpdateFoodCategory";
            txtUpdateFoodCategory.Size = new Size(143, 25);
            txtUpdateFoodCategory.TabIndex = 1;
            txtUpdateFoodCategory.TextChanged += txtUpdateFoodCategory_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 2;
            label1.Text = "Food Categories";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(13, 96);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 3;
            label2.Text = "New Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(11, 136);
            label3.Name = "label3";
            label3.Size = new Size(112, 17);
            label3.TabIndex = 4;
            label3.Text = "Update Category";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(329, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 27);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(329, 91);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 27);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(329, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 27);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbFoodCategories
            // 
            lbFoodCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbFoodCategories.FormattingEnabled = true;
            lbFoodCategories.ItemHeight = 17;
            lbFoodCategories.Location = new Point(0, 231);
            lbFoodCategories.Name = "lbFoodCategories";
            lbFoodCategories.Size = new Size(445, 378);
            lbFoodCategories.TabIndex = 1;
            lbFoodCategories.SelectedIndexChanged += lbFoodCategories_SelectedIndexChanged;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(324, 0);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(91, 17);
            hScrollBar1.TabIndex = 7;
            // 
            // FoodCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            Controls.Add(hScrollBar1);
            Controls.Add(lbFoodCategories);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUpdateFoodCategory);
            Controls.Add(txtNewCategory);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FoodCategories";
            Size = new Size(445, 631);
            Load += FoodCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewCategory;
        private TextBox txtUpdateFoodCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private ListBox lbFoodCategories;
        private HScrollBar hScrollBar1;
    }
}
