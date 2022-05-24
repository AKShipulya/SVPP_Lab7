using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person;
        ObservableCollection<Person> collection = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            person = new Person();
            stackpanelPerson.DataContext = person;
            listBox.DataContext = collection;
            FillData();
        }

        private void buttonView_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show(person.ToString());
            FillData();
        }
        private void FillData()
        {
            collection.Clear();
            foreach (var p in Person.getAllPersons())
            {
                collection.Add(p);
            }
        }

        private void buttonInsert_Click(object sender, RoutedEventArgs e)
        {
            person.Insert();
            FillData();
        }

        private void buttonFind_Click(object sender, RoutedEventArgs e)
        {
            person = Person.Find(textBoxName.Text);
            if (person == null)
            {
                MessageBox.Show("Нет такой записи!");
                person = new Person();
            }
            else
                MessageBox.Show(person.ToString());
        }

        private void buttonChange_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Нет выбранной записи!");
                return;
            }
            person.Id = ((Person)listBox.SelectedItem).Id;

            if (textBoxName.Text.Length > 0)
                person.Name = textBoxName.Text;
            else
                person.Name = ((Person)listBox.SelectedItem).Name;
            decimal d = Convert.ToDecimal(textBoxSum.Text);
            if (d != 0)
                person.Sum = d;
            else
                person.Sum = ((Person)listBox.SelectedItem).Sum;
            person.Update();
            FillData();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                MessageBox.Show("Нет выбранной записи!");
                return;
            }
            var id = ((Person)listBox.SelectedItem).Id;
            Person.Delete(id);
            FillData();
        }
    }
}
