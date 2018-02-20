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

namespace MessageRecieve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MessageQueue messageQueue = new MessageQueue(@".\Private$\SomeTestName");

        public MainWindow()
        {
            InitializeComponent();
            
        }


        public void RetrieveMessage()
        {
            messageQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(Person) });

            Message[] messages = messageQueue.GetAllMessages();
            StringBuilder builder = new StringBuilder();

            var isOK = messages.Count() > 0 ? true : false;
            foreach (Message m in messages)
            {
                try
                {
                    var command = (Person)m.Body;
                    builder.Append("Name: " + command.FirstName + " " + command.LastName + " age: " + command.Age +  "\n");
                }
                catch (MessageQueueException ex)
                {
                }
                catch (Exception ex)
                {
                }
            }
            messageTextBlock.Text = builder.ToString();
        }

        private void getMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            RetrieveMessage();
        }

        private void deleteMessagesBtn_Click(object sender, RoutedEventArgs e)
        {
            messageQueue.Purge();
            RetrieveMessage();
        }
    }
}
