using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Classes;
using SQLite;
using Plugin.LocalNotifications;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssessmentEdit : ContentPage
    {
        readonly Class selectedClass;
        readonly Assessment editAssessment;
        public AssessmentEdit()
        {
            InitializeComponent();
            editAssessment = null;
        }

        public AssessmentEdit(Class selectedClass)
        {
            InitializeComponent();
            editAssessment = null;
            this.selectedClass = selectedClass;
            DueDatePicker.MinimumDate = selectedClass.StartDate;
            DueDatePicker.MaximumDate = selectedClass.EndDate;
        }
        public AssessmentEdit(Assessment assessment)
        {
            InitializeComponent();
            editAssessment = assessment;

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Class>();
                selectedClass = conn.Table<Class>().FirstOrDefault(x => x.ClassID == assessment.ClassID);
            }

            assessmentName.Text = assessment.AssessmentName;
            assessmentType.SelectedItem = assessment.AssessmentType;
            DueDatePicker.Date = assessment.DueDate;
            notificationsPicker.IsToggled = assessment.Notifications;
        }
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if(assessmentName.Text == null || assessmentName.Text.Length == 0)
            {
                await DisplayAlert("Invalid Class Name", "Please enter the name of the class", "Ok");
                return;
            }
            if(assessmentType.SelectedIndex == -1)
            {
                await DisplayAlert("No Status Selected", "Please select a status for the class", "Ok");
                return;
            }
            

            Assessment assessment = new Assessment()
            {
                AssessmentName = assessmentName.Text,
                AssessmentType = assessmentType.SelectedItem.ToString(),
                DueDate = DueDatePicker.Date,
                Notifications = notificationsPicker.IsToggled,
                ClassID = this.selectedClass.ClassID

            };

            if (this.editAssessment != null)
                assessment.AssessmentID = this.editAssessment.AssessmentID;
            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Assessment>();
                var assessmentList = conn.Table<Assessment>().Where(x => x.ClassID == selectedClass.ClassID).ToList();
                if(assessmentList.Count == 1 && editAssessment == null)
                {
                    if(assessmentList.ElementAt(0).AssessmentType == assessmentType.SelectedItem.ToString())
                    {
                        String head = "Too many " + assessmentType.SelectedItem.ToString() + "s";
                        await DisplayAlert(head, "Only one of each type of assessment for each class", "Ok");
                        return;
                    }
                }
                else if(assessmentList.Count == 2 && editAssessment != null)
                {
                    assessmentList.Remove(this.editAssessment);
                    if (assessmentList.ElementAt(0).AssessmentType == assessmentType.SelectedItem.ToString())
                    {
                        String head = "Too many " + assessmentType.SelectedItem.ToString() + "s";
                        await DisplayAlert(head, "Only one of each type of assessment for each class", "Ok");
                        return;
                    }
                }
                conn.InsertOrReplace(assessment);   
            }
            if (assessment.Notifications)
            {
                String body = assessment.AssessmentName + " is due today"; 
                CrossLocalNotifications.Current.Show("Due date", body, (int)assessment.AssessmentID, assessment.DueDate);
            }
            else
            {
                CrossLocalNotifications.Current.Cancel((int)assessment.AssessmentID);
            }
            await Navigation.PopAsync();
        }
    }
}