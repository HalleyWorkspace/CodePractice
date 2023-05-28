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
    public partial class ClassList : ContentPage
    {
        private bool isEdit = false;
        private bool isDrop = false;
        readonly Term currentTerm;
        int classCount;
        public ClassList()
        {
            InitializeComponent();
        }
        public ClassList(Term term)
        {
            InitializeComponent();
            currentTerm = term;
            
        }

        private void AddClassButton_Clicked(object sender, EventArgs e)
        {
            if(classCount < 6)
                Navigation.PushAsync(new EditClass(this.currentTerm));
            else
                DisplayAlert("Max Number of Classess", "Only 6 classes are allowed in each term", "OK");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            termName.Text = currentTerm.TermName;
            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<Class>();

                var classes = conn.Table<Class>().ToList();
                List<Class> currentList = CreateCurrentClassList(currentTerm, classes);
                classCount = currentList.Count;
                ClassListView.ItemsSource = currentList;
            }
        }

        private List<Class> CreateCurrentClassList(Term term, List<Class> classList)
        {
            List<Class> currentClassList = new List<Class>();

            foreach(Class current in classList)
                if (current.TermID == term.TermID)
                    currentClassList.Add(current);
            return currentClassList;
        }

        private void ClassListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var currentClass = e.Item as Class;

            if (isEdit)
            {
                Navigation.PushAsync(new EditClass(currentClass));
                isEdit = false;
                EditClassButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else if (isDrop)
            {
                using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                {
                    conn.CreateTable<Class>();
                    conn.CreateTable<Assessment>();

                    conn.Table<Assessment>().Where(x => x.ClassID == currentClass.ClassID).Delete();
                    conn.Delete(currentClass);

                    var classes = conn.Table<Class>().ToList();
                    List<Class> currentList = CreateCurrentClassList(currentTerm, classes);
                    classCount = currentList.Count;
                    ClassListView.ItemsSource = currentList;
                }
                isDrop = false;
                DropClassButton.BackgroundColor = Color.FromHex("#4986AD");
            }
            else
                Navigation.PushAsync(new ClassInfo(currentClass));
            
        }

        

        private void EditClassButton_Clicked(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                isEdit = true;
                EditClassButton.BackgroundColor = Color.FromHex("#42892E");
                if (isDrop)
                {
                    isDrop = false;
                    DropClassButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isEdit = false;
                EditClassButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }

        private void DropClassButton_Clicked(object sender, EventArgs e)
        {
            if (!isDrop)
            {
                isDrop = true;
                DropClassButton.BackgroundColor = Color.Red;
                if (isEdit)
                {
                    isEdit = false;
                    EditClassButton.BackgroundColor = Color.FromHex("#4986AD");
                }
            }
            else
            {
                isDrop = false;
                DropClassButton.BackgroundColor = Color.FromHex("#4986AD");
            }
        }

        
    }
}