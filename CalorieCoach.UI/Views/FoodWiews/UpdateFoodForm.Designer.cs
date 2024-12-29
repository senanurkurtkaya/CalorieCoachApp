namespace CalorieCoach.UI.Views.FoodWiews
{
    partial class UpdateFoodForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            cbCategories = new ComboBox();
            pbImage = new PictureBox();
            numCaloriesPerUnit = new NumericUpDown();
            btnBrowse = new Button();
            btnSubmit = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCaloriesPerUnit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 250);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 0;
            label3.Text = "Image:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(107, 17);
            label4.TabIndex = 0;
            label4.Text = "CaloriesPerUnit:";
            // 
            // txtName
            // 
            txtName.Location = new Point(14, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 25);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(12, 122);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(138, 25);
            cbCategories.TabIndex = 2;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(12, 282);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(194, 120);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 3;
            pbImage.TabStop = false;
            pbImage.Click += btnBrowse_Click;
            // 
            // numCaloriesPerUnit
            // 
            numCaloriesPerUnit.Location = new Point(14, 206);
            numCaloriesPerUnit.Name = "numCaloriesPerUnit";
            numCaloriesPerUnit.Size = new Size(137, 25);
            numCaloriesPerUnit.TabIndex = 4;
            numCaloriesPerUnit.ValueChanged += numCaloriesPerUnit_ValueChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ControlLightLight;
            btnBrowse.Location = new Point(236, 329);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(86, 26);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ControlLightLight;
            btnSubmit.Location = new Point(236, 376);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(86, 26);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // UpdateFoodForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(370, 448);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Controls.Add(numCaloriesPerUnit);
            Controls.Add(pbImage);
            Controls.Add(cbCategories);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "UpdateFoodForm";
            Text = "UpdateFoodForm";
            Load += UpdateFoodForm_Load;
            Click += UpdateFoodForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCaloriesPerUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private ComboBox cbCategories;
        private PictureBox pbImage;
        private NumericUpDown numCaloriesPerUnit;
        private Button btnBrowse;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog;
    }
}