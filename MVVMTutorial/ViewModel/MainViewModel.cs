using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input; // Richtiger Import für ICommand
using System.Collections;

namespace MVVMTutorial.ViewModel
{
    public class MainViewModel : ObservableObject // Vererbung mit : Elternklasse 'ObservableObject'
    {
        private Model.SimplePerson person; // Dies ist eine Instanzvariable (oder ein Feld)

        public Model.SimplePerson Person // Property
        {
            get { return person; }
            set { SetProperty(ref person, value); }
        }

        // ICommand-Eigenschaften
        public ICommand ClearName { get; }
        public ICommand DeleteChildName { get; }
        public ICommand ResetData { get; }

        // Konstruktor
        public MainViewModel()
        {
            person = new Model.SimplePerson();
            ClearName = new RelayCommand(ClearNameOfPerson);
            DeleteChildName = new RelayCommand<IList>(DeleteNameOfChildFromList); // IList ist eine Schnittstelle, also 'Interface', gut für mehrere Namen
            ResetData = new RelayCommand(GenerateSampleData);

            GenerateSampleData();
        }

        private void GenerateSampleData()
        {
            Person.SureName = "Otto";
            Person.LastName = "Bismarck";
            Person.Childs = new ObservableCollection<string> { "Willhelm", "Marie", "Herbert" };
        }

        private void DeleteNameOfChildFromList(IList? obj)
        {
            if (obj != null)
            {
                var copyOfSelectedItems = ((IList<object>)obj).ToList();

                foreach (string item in copyOfSelectedItems)
                {
                    Person.Childs.Remove(item);
                }
            }
        }

        private void ClearNameOfPerson()
        {
            Person.LastName = string.Empty; // In der Methode wird der Property 'LastName' eine leerer String zugewiesen
            Person.SureName = string.Empty;
        }
    }
}
