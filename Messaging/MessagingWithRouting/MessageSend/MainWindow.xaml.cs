using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
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
using MessagingWithRouting;

namespace MessageSend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CreateMessage()
        {
            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\Private$\PersonQueue"))
            {
                messageQueue = new MessageQueue(@".\Private$\PersonQueue");
                messageQueue.Label = "Person Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\PersonQueue");
                messageQueue = new MessageQueue(@".\Private$\PersonQueue");
                messageQueue.Label = "Person Queue";
            }

            if (MessageQueue.Exists(@".\Private$\AnotherPersonQueue"))
            {
                messageQueue = new MessageQueue(@".\Private$\AnotherPersonQueue");
                messageQueue.Label = "AnotherPerson Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\AnotherPersonQueue");
                messageQueue = new MessageQueue(@".\Private$\AnotherPersonQueue");
                messageQueue.Label = "AnotherPerson Queue";
            }

            if (checkboxPerson.IsChecked == true)
            {
                messageQueue = new MessageQueue(@".\Private$\PersonQueue");
                Person person = new Person();
                person.FirstName = personFirstNameTxt.Text;
                person.LastName = personLastNameTxt.Text;
                person.Age = int.Parse(personAgeTxt.Text);
                messageQueue.Send(person);
            }
            else
            {
                messageQueue = new MessageQueue(@".\Private$\AnotherPersonQueue");          
                AnotherPerson person = new AnotherPerson();
                person.Name = personFirstNameTxt.Text + " " + personLastNameTxt.Text;
                person.Age = int.Parse(personAgeTxt.Text);
                messageQueue.Send(person);
            }
        }
        private void sendMessageBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateMessage();
        }
    }
}
