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
using System.Xml.Linq;
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Response response = new Response();
            ValidationOfRequest validation = new ValidationOfRequest();
            if (validation.ValidateRequest(TextBoxEnter.Text) == true)
            {

                Request request = RequestFactory.ConvertStringToRequest(TextBoxEnter.Text);

                try
                {
                    string json = JsonConvert.SerializeObject(request, Formatting.Indented);
                    XNode node = JsonConvert.DeserializeXNode(json, "Request");
                    JsonFormat.Text = json;
                    XmlFormat.Text = node.ToString();
                    response.Status = Status.SUCCESS;
                    response.StatusCode = 2000;
                    response.Payload = "";
                    Response.Text = "STATUS: " + response.Status + "\n" + "STATUS CODE: " + response.StatusCode + "\n" + "PAYLOAD: " + response.Payload;

                }

                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                response.Status = Status.BAD_FORMAT;
                response.StatusCode = 5000;
                response.Payload = "";
                Response.Text = "STATUS: " + response.Status + "\n" + "STATUS CODE: " + response.StatusCode + "\n" + "PAYLOAD: " + response.Payload;
                return;
            }
        }
    }
}

