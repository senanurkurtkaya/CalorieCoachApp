namespace CalorieCoach.UI.Views.FoodWiews
{
    partial class NewFood
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
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbCategories = new ComboBox();
            numCaloriesPerUnit = new NumericUpDown();
            pbImage = new PictureBox();
            btnBrowse = new Button();
            btnSubmit = new Button();
            openFileDialog = new OpenFileDialog();
            txtUnit = new TextBox();
            Unit = new Label();
            ((System.ComponentModel.ISupportInitialize)numCaloriesPerUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(48, 17);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(184, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(16, 71);
            label2.Name = "label2";
            label2.Size = new Size(68, 17);
            label2.TabIndex = 0;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(16, 130);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 0;
            label3.Text = "CaloriesPerUnit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 258);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 0;
            label4.Text = "Image:";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(16, 91);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(184, 23);
            cbCategories.TabIndex = 4;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // numCaloriesPerUnit
            // 
            numCaloriesPerUnit.Location = new Point(16, 150);
            numCaloriesPerUnit.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCaloriesPerUnit.Name = "numCaloriesPerUnit";
            numCaloriesPerUnit.Size = new Size(184, 23);
            numCaloriesPerUnit.TabIndex = 6;
            numCaloriesPerUnit.ValueChanged += numCaloriesPerUnit_ValueChanged;
            // 
            // pbImage
            // 
            pbImage.BackColor = SystemColors.ControlLightLight;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Location = new Point(12, 289);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(205, 145);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 7;
            pbImage.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnBrowse.Location = new Point(142, 440);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 8;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSubmit.Location = new Point(223, 440);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(16, 207);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(184, 23);
            txtUnit.TabIndex = 2;
            txtUnit.TextChanged += txtUnit_TextChanged;
            // 
            // Unit
            // 
            Unit.AutoSize = true;
            Unit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Unit.Location = new Point(16, 187);
            Unit.Name = "Unit";
            Unit.Size = new Size(38, 17);
            Unit.TabIndex = 0;
            Unit.Text = "Unit:";
            // 
            // NewFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Controls.Add(pbImage);
            Controls.Add(numCaloriesPerUnit);
            Controls.Add(cbCategories);
            Controls.Add(txtUnit);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Unit);
            Controls.Add(label1);
            Name = "NewFood";
            Size = new Size(313, 494);
            Load += NewFood_Load;
            ((System.ComponentModel.ISupportInitialize)numCaloriesPerUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbCategories;
        private NumericUpDown numCaloriesPerUnit;
        private PictureBox pbImage;
        private Button btnBrowse;
        private Button btnSubmit;
        private OpenFileDialog openFileDialog;
        private TextBox txtUnit;
        private Label Unit;
    }
}
