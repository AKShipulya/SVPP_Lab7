using System.Windows;

namespace BD_Adapter
{
    public partial class WindowPerson : Window
    {
        public WindowPerson(Person person)
        {
            InitializeComponent();
            grid.DataContext = person;
        }

        private void buttonOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
