using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCoach.UI.Views.MealRecordViews
{
    public partial class MealRecords : UserControl
    {
        private readonly string _containerName = "MealRecordsByDate";
        public MealRecords()
        {
            InitializeComponent();
        }

        private void MealRecords_Load(object sender, EventArgs e)
        {
            dtpMealRecordDate.MaxDate = DateTime.Now;
            GetMealRecords();
        }
        private void GetMealRecords()
        {
            var mainPageForm = (MainPageForm)this.Parent.Parent;

            var selectedDate = dtpMealRecordDate.Value;

            flowLayoutPanel1.Controls.RemoveByKey(_containerName);

            var mealRecordsByDate = new MealRecordsByDate(mainPageForm.CurrentUser.Id, selectedDate);

            //mealRecordsByDate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            //mealRecordsByDate.Dock = DockStyle.Fill;

            flowLayoutPanel1.Controls.Add(mealRecordsByDate);
        }

        private void dtpMealRecordDate_ValueChanged(object sender, EventArgs e)
        {

            GetMealRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpMealRecordDate.Value;
            var newMealRecord = new NewMealRecord(selectedDate);
            var dialogResult = newMealRecord.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                GetMealRecords();
            }
        }
    }
}
