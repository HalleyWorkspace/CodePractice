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
    public partial class AssessmentInfo : ContentPage
    {
        readonly Assessment assessment;
        public AssessmentInfo()
        {
            InitializeComponent();
        }

        public AssessmentInfo(Assessment assessment)
        {
            InitializeComponent();
            this.assessment = assessment;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            assessmentName.Text = assessment.AssessmentName;
            type.Text = assessment.AssessmentType;
            dueDate.Text = assessment.DueDate.ToString("d");
            if (assessment.Notifications)
                notifications.Text = "Yes";
            else if (!assessment.Notifications)
                notifications.Text = "No";
        }
    }
}