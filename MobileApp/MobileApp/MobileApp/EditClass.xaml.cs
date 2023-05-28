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
    public partial class EditClass : ContentPage
    {
        readonly Class editClass;
        readonly Term term;
        public EditClass()
        {
            InitializeComponent();
            editClass = null;
        }
        public EditClass(Term term)
        {
            InitializeComponent();
            editClass = null;
            this.term = term;

            startDatePicker.MinimumDate = this.term.StartDate;
            startDatePicker.MaximumDate = this.term.EndDate;
            endDatePicker.MinimumDate = this.term.StartDate;
            endDatePicker.MaximumDate = this.term.EndDate;
        }
        public EditClass(Class editClass)
        {
            InitializeComponent();
            this.editClass = editClass;

            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Term>();
                this.term = conn.Table<Term>().FirstOrDefault(x => x.TermID == editClass.TermID);
            }
            startDatePicker.MinimumDate = this.term.StartDate;
            startDatePicker.MaximumDate = this.term.EndDate;
            endDatePicker.MinimumDate = this.term.StartDate;
            endDatePicker.MaximumDate = this.term.EndDate;

            classNameEntry.Text = editClass.ClassName;
            startDatePicker.Date = editClass.StartDate;
            endDatePicker.Date = editClass.EndDate;
            instructorNameEntry.Text = editClass.InstructorName;
            instructorEmailEntry.Text = editClass.InstructorEmail;
            instructorPhoneEntry.Text = editClass.InstructorPhone;
            notifications.IsToggled = editClass.Notification;
            notes.Text = editClass.Notes;
            statusPicker.SelectedItem = editClass.Status;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if(classNameEntry.Text == null || classNameEntry.Text.Length == 0)
            {
                await DisplayAlert("No Class Name", "Please enter a name for the class", "Ok");
                return;
            }
            if (statusPicker.SelectedIndex == -1)
            {
                await DisplayAlert("No Status Selected", "Please select a status for the class", "Ok");
                return;
            }
            if (false) { }
            if(DateTime.Compare(startDatePicker.Date, endDatePicker.Date) > 0)
            {
                await DisplayAlert("Impossible Dates", "Ensure that the start date is before the end date", "Ok");
                return;
            }
            if(instructorNameEntry.Text == null || instructorNameEntry.Text.Length == 0)
            {
                await DisplayAlert("No Teacher Name", "Please enter the teachers name", "Ok");
                return;
            }
            if(instructorPhoneEntry.Text == null || instructorPhoneEntry.Text.Length != 10 || !instructorPhoneEntry.Text.All(char.IsDigit))
            {
                await DisplayAlert("Invalid Phone Number", "Please enter the teachers 10 digit phone number", "Ok");
                return;
            }
            if(instructorEmailEntry.Text == null || instructorEmailEntry.Text.Length == 0)
            {
                await DisplayAlert("Invalid email address", "Please enter the teachers email address", "Ok");
                return;
            }
            Class newClass = new Class()
            {
                TermID = this.term.TermID,
                ClassName = classNameEntry.Text,
                StartDate = startDatePicker.Date,
                EndDate = endDatePicker.Date,
                InstructorName = instructorNameEntry.Text,
                InstructorEmail = instructorEmailEntry.Text,
                InstructorPhone = instructorPhoneEntry.Text,
                Status = statusPicker.SelectedItem.ToString(),
                Notification = notifications.IsToggled,
                Notes = notes.Text
                
            };
            if (this.editClass != null)
                newClass.ClassID = this.editClass.ClassID;
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Class>();
                conn.InsertOrReplace(newClass);
                
            }
            if (newClass.Notification)
            {
                String body = newClass.ClassName + " ends Today";
                CrossLocalNotifications.Current.Show("End date", body, (int)newClass.ClassID, newClass.EndDate);
            }
            else
            {
                CrossLocalNotifications.Current.Cancel((int)newClass.ClassID);
            }
            await Navigation.PopAsync();
        }
    }
}