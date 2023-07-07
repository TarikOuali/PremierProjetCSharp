using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace ApplicationDesktop.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            ObjectCategory = new Category();
        }

        public CommandHandler OkBtnClickHandler
        {
            get
            {
                return new CommandHandler(
                    () =>
                    {
                        //code du callback
                        MessageBox.Show(this.SelectedAuthor.ToString());
                    },
                    () => true
                    );
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                NotifyPropertyChanged();
            }
        }

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                _age = value;
                NotifyPropertyChanged();
            }
        }

        private bool _isHappy;
        public bool IsHappy
        {
            get => _isHappy;
            set
            {
                _isHappy = value;
                NotifyPropertyChanged();
            }
        }

        private Category _cat;

        public Category ObjectCategory
        {
            get { return _cat; }
            set { _cat = value; NotifyPropertyChanged(); }
        }

        public ObservableCollection<Author> Authors { get; set; }
            = new ObservableCollection<Author>()
            { new Author(1, "Tarik", 1888), new Author(2, "Baptiste", 1515) };

        private Author selectedAuth;

        public Author SelectedAuthor
        {
            get { return selectedAuth; }
            set
            {
                selectedAuth = value;
                NotifyPropertyChanged();
            }
        }

        private int selectedAuthorIndex;

        public int SelectedAuthorIndex
        {
            get { return selectedAuthorIndex; }
            set
            {
                selectedAuthorIndex = value;
                NotifyPropertyChanged();
            }
        }


    }

    public class Category : ViewModelBase
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; NotifyPropertyChanged(); }
        }

        private string catName;

        public string CategoryName
        {
            get { return catName; }
            set
            {
                catName = value;
                NotifyPropertyChanged();
            }
        }

    }


    public class Author
    {
        public Author(int id, string name, int birthYear)
        {
            Id = id;
            Name = name;
            BirthYear = birthYear;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public override string ToString()
        {
            return $"{Name} ({BirthYear})";
        }
    }
}
