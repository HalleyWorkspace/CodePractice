using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Classes;
using SQLite;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentList : ContentPage
    {
        readonly Class current;
        private int listCount;
        private bool isEdit = false;
        private bool isDrop = false;
        public AssessmentList()
        {
            InitializeComponent();
        }

        public AssessmentList(Class selectedClass)
        {
            InitializeComponent();
            current = selectedClass;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            className.Text = current.ClassName;
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Assessment>();

                var assessments = conn.Table<Assessment>().ToList();
                List<Assessment> currentList = CreateCurrentAssessmentList(current, assessments);
                listCount = currentList.Count;
                AssessmentListView.ItemsSource = currentList;
            }
        }

        private List<Assessment> CreateCurrentAssessmentList(Class current, List<Assessment> assessments)
        {
            List<Assessment> listOfAssessments = new List<Assessment>();
            foreach (Assessment currentAssessment in assessments)
                if (current.ClassID == current.ClassID)
                    listOfAssessments.Add(currentAssessment);
            return listOfAssessments;
        }

        private void AddAssessment_Clicked(object sender, EventArgs e)
        {
            if (listCount < 2)
                Navigation.PushAsync(new AssessmentEdit(current));
            else
                DisplayAlert("Max Assessments", "Each class may only have 2 assessments.", "OK");
        }

        private void EditAssessmentButton_Clicked(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                isEdit = true;
                EditAssessmentButton.BackgroundColor = Color.FromHex("#42892E");
                if (isDrop)
                {
                    isDrop = false;
                    DropAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isEdit = false;
                EditAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }

        private void AssessmentListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var assessment = e.Item as Assessment;
            if (isEdit)
            {
                Navigation.PushAsync(new AssessmentEdit(assessment));
                isEdit = false;
                EditAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else if (isDrop)
            {
                using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Assessment>();

                    conn.Delete(assessment);

                    var assessments = conn.Table<Assessment>().ToList();
                    List<Assessment> currentList = CreateCurrentAssessmentList(current, assessments);
                    listCount = currentList.Count;
                    AssessmentListView.ItemsSource = currentList;
                }
                isDrop = false;
                DropAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else
                Navigation.PushAsync(new AssessmentInfo(assessment));
        }

        private void DropAssessmentButton_Clicked(object sender, EventArgs e)
        {
            if (!isDrop)
            {
                isDrop = true;
                DropAssessmentButton.BackgroundColor = Color.Red;
                if (isEdit)
                {
                    isEdit = false;
                    EditAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isDrop = false;
                DropAssessmentButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }
    }
}