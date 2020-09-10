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
using Newtonsoft.Json; // Nuget Package


namespace WebClient
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

        

        private void ConvertToJson(object sender, RoutedEventArgs e)
        {

          
                string text = TextBoxEnter.Text.ToString();
                string[] partsOfRequest = text.Split('/');
                if (partsOfRequest[0] == "GET")
                {
                }
                else if (partsOfRequest[0] == "POST")
                {
                }
                else if (partsOfRequest[0] == "PATCH")
                {
                }
                else if (partsOfRequest[0] == "DELETE")
                {
                }
                else
                {
                    MessageBox.Show("Request is not well formated", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                  
                }

                Request request = new Request();
                request.Verb = partsOfRequest[0];
                request.Noun = partsOfRequest[1];
                
            /*
            if (partsOfRequest[2] != null)
            {
              //  string[] query = partsOfRequest[2].Split('&');
                string[] name = partsOfRequest[2].Split('=');
                request.Query.Name = name[1];
                //string[] id = query[1].Split('=');
                //request.Query.Id = id[1];
            }

    */

                try
                {
                    string json = JsonConvert.SerializeObject(request);
                    JsonFormat.Text = json;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }

            
        }

     
    }
}
