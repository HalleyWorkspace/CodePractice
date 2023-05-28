using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Classes;
using Xamarin.Essentials;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassInfo : ContentPage
    {
        readonly Class current;
        public ClassInfo()
        {
            InitializeComponent();
        }

        public ClassInfo(Class current)
        {
            InitializeComponent();
            this.current = current;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            className.Text = current.ClassName;
            status.Text = current.Status;
            startDate.Text = current.StartDate.ToString("d");
            endDate.Text = current.EndDate.ToString("d");
            instructorName.Text = current.InstructorName;
            instructorEmail.Text = current.InstructorEmail;
            instructorPhone.Text = current.InstructorPhone;
            notes.Text = current.Notes;
            if (current.Notification)
                notifications.Text = "Yes";
            else if (!current.Notification)
                notifications.Text = "No";
        }

        private void AssessmentButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AssessmentList(current));
        }

        private async void ShareNotes_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = notes.Text,
                Title = "Share Notes"
            });
        }
    }
}