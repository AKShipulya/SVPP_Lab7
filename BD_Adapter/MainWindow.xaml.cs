using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace BD_Adapter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable personTable = new DataTable();
        public MainWindow()
        {
            InitializeComponent();
            Fill();
        }
        private void Fill()
        {
            personTable.Rows.Clear();
            personTable = Person.ViewAll();
            personGrid.ItemsSource = personTable.DefaultView;
        }

        private void ButtonView_Click(object sender, RoutedEventArgs e)
        {
            Fill();
        }

        private void ButtonFind_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            WindowPerson windowPerson = new WindowPerson(person);
            if (windowPerson.ShowDialog() == false)
                return;
            MessageBox.Show(person.Find());
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            Person.Update();
            Fill();
        }
    }
}
