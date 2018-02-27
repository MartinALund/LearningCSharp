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

namespace MessageReceive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MessageQueue personQueue = new MessageQueue(@".\Private$\PersonQueue");
        MessageQueue anotherPersonQueue = new MessageQueue(@".\Private$\AnotherPersonQueue");

        public MainWindow()
        {
            InitializeComponent();
        }

        public void RetrieveMessageFromPersonQueue()
        {
            personQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(Person) });

            Message[] messages = personQueue.GetAllMessages();
            StringBuilder builder = new StringBuilder();

            var isOK = messages.Count() > 0 ? true : false;
            foreach (Message m in messages)
            {
                try
                {
                    Person person = new Person();
                    var command = (Person)m.Body;

                    person.FirstName = command.FirstName;
                    person.LastName = command.LastName;
                    person.Age = command.Age;
                    builder.Append(person.ToString() + "\n");
                }
                catch (MessageQueueException ex)
                {
                }
            }
            messageTextBlock.Text += builder.ToString();
        }

        public void RetrieveMessageFromAnotherPersonQueue()
        {
            anotherPersonQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(AnotherPerson) });

            Message[] messages = anotherPersonQueue.GetAllMessages();
            StringBuilder builder = new StringBuilder();

            var isOK = messages.Count() > 0 ? true : false;
            foreach (Message m in messages)
            {
                try
                {
                    AnotherPerson person = new AnotherPerson();
                    var command = (AnotherPerson)m.Body;
                    person.Name = command.Name;
                    person.Age = command.Age;
                    builder.Append(person.ToString() + "\n");
                }
                catch (MessageQueueException ex)
                {
                }
            }
            messageTextBlock.Text += builder.ToString();

        }

        private void getPersonMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            RetrieveMessageFromPersonQueue();           
        }

        private void getAnotherPersonMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            RetrieveMessageFromAnotherPersonQueue();
        }

        private void deletePersonMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            personQueue.Purge();
            messageTextBlock.Text = "";
        }

        private void deleteAnotherPersonMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            anotherPersonQueue.Purge();
            messageTextBlock.Text = "";
        }
    }
}
