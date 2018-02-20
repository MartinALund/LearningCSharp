using System;
using System.Collections.Generic;
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
using System.Messaging;

namespace Messaging
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
            if (MessageQueue.Exists(@".\Private$\SomeTestName"))
            {
                messageQueue = new MessageQueue(@".\Private$\SomeTestName");
                messageQueue.Label = "Testing Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\SomeTestName");
                messageQueue = new MessageQueue(@".\Private$\SomeTestName");
                messageQueue.Label = "Newly Created Queue";
            }

            Person person = new Person();
            person.FirstName = personFirstNameTxt.Text;
            person.LastName = personLastNameTxt.Text;
            person.Age = int.Parse(personAgeTxt.Text);
            messageQueue.Send(person);
        }

        private void sendMessageBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateMessage();
        }
    }


}
