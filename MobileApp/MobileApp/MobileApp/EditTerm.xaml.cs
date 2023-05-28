using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using MobileApp.Classes;

namespace MobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditTerm : ContentPage
    {
        readonly Term term;
        public EditTerm()
        {
            InitializeComponent();
            this.term = null;
        }

        public EditTerm(Term term)
        {
            InitializeComponent();
            this.term = term;
            termNameEntry.Text = term.TermName;
            startDatePicker.Date = term.StartDate;
            endDatePicker.Date = term.EndDate;
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {

            if (termNameEntry.Text == null || termNameEntry.Text.Length == 0)
            {
                await DisplayAlert("No Term Name", "Please enter a name for the term", "Ok");
                return;
            }
            if(DateTime.Compare(startDatePicker.Date, endDatePicker.Date) > 0)
            {
                await DisplayAlert("Impossible Dates", "Ensure that the start date is before the end date", "Ok");
                return;
            }
            Term term = new Term()
            {
                TermName = termNameEntry.Text,
                StartDate = startDatePicker.Date,
                EndDate = endDatePicker.Date

            };
            if (this.term != null)
                term.TermID = this.term.TermID;
            
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Term>();

               
                conn.InsertOrReplace(term);
                
                await Navigation.PopAsync();
            }
        }
    }
}