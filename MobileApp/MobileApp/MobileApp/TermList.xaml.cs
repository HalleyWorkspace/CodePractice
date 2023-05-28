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
    public partial class TermList : ContentPage
    {
        private bool isEdit = false;
        private bool isDrop = false;
        
        public TermList()
        {
            InitializeComponent();
        }

        private void AddTermButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditTerm());
            
        }

        private void EditTermButton_Clicked(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                isEdit = true;
                EditTermButton.BackgroundColor = Color.FromHex("#42892E");
                if (isDrop)
                {
                    isDrop = false;
                    DropTermButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isEdit = false;
                EditTermButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }

        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Term>();
                

                
                if (conn.Table<Term>().Count() == 0) 
                    GenerateSample();
                
                var terms = conn.Table<Term>().ToList();
                TermListView.ItemsSource = terms;
            }

        }

        private void TermListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            
            var term = e.Item as Term;
            
            if(isEdit)
            { 
                Navigation.PushAsync(new EditTerm(term));
                isEdit = false;
                EditTermButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else if (isDrop)
            {
                using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Term>();
                    conn.CreateTable<Class>();
                    conn.CreateTable<Assessment>();

                    var classList = conn.Table<Class>().Where(x => x.TermID == term.TermID).ToList();
                    foreach(Class currentClass in classList)
                    {
                        conn.Table<Assessment>().Where(x => x.ClassID == currentClass.ClassID).Delete();
                        conn.Delete(currentClass);
                    }
                    conn.Delete(term);

                    conn.CreateTable<Term>();
                    var newTermList = conn.Table<Term>().ToList();

                    TermListView.ItemsSource = newTermList;
                }
                isDrop = false;
                DropTermButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else 
                Navigation.PushAsync(new ClassList(term));

           
        }

        private void DropTermButton_Clicked(object sender, EventArgs e)
        {
            
            if (!isDrop)
            {
                isDrop = true;
                DropTermButton.BackgroundColor = Color.Red;
                if (isEdit)
                {
                    isEdit = false;
                    EditTermButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isDrop = false;
                DropTermButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }

        private void GenerateSample()
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Term>();
                conn.CreateTable<Class>();
                conn.CreateTable<Assessment>();

                Term term = new Term()
                {
                    TermName = "Term 1",
                    StartDate = DateTime.Today.AddDays(-60),
                    EndDate = DateTime.Today.AddDays(60),

                };
                conn.Insert(term);
                Class newClass = new Class()
                {
                    ClassName = "C971",
                    Status = "In Progress",
                    InstructorName = "Jake Halley",
                    InstructorEmail = "thalle6@wgu.edu",
                    InstructorPhone = "5402292763",
                    Notification = false,
                    StartDate = DateTime.Today.AddDays(-15),
                    EndDate = DateTime.Today.AddDays(15),
                    TermID = term.TermID
                };
                conn.Insert(newClass);
                Assessment assessment1 = new Assessment()
                {
                    AssessmentName = "Assessment 1",
                    AssessmentType = "Objective Assessment",
                    DueDate = DateTime.Today.AddDays(14),
                    Notifications = false,
                    ClassID = newClass.ClassID
                };
                Assessment assessment2 = new Assessment()
                {
                    AssessmentName = "Assessment 2",
                    AssessmentType = "Performance Assessment",
                    DueDate = DateTime.Today.AddDays(14),
                    Notifications = false,
                    ClassID = newClass.ClassID
                };
                conn.Insert(assessment1);
                conn.Insert(assessment2);
            }
        }

        
    }
}