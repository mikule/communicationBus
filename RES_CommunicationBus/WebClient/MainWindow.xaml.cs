using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using Common;
using Common.CommunicationBus;
using Common.CommunicationModel;
using Common.Helper;
using Common.Helpers;
using ModelPodataka.DataModel;
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

            Resource r = new Resource(1, "resurs", "opis resursa", null);
            CommunicationBus_DbContext context = new CommunicationBus_DbContext();
            context.Resources.Add(r);
            context.SaveChanges();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ValidationOfRequest validation = new ValidationOfRequest();
            if(!validation.ValidateRequest(TextBoxEnter.Text))
            {
                MessageBox.Show("Pls enter valid request.");
                return;
            }

            Request request = RequestFactory.ConvertStringToRequest(TextBoxEnter.Text);
            string json = JsonConvert.SerializeObject(request, Formatting.Indented);
            CommunicationBusModule cmb = new CommunicationBusModule();
            Response response = cmb.SendRequest(json);
            
            txtBoxResponse.Text = "STATUS: " + response.Status + "\n" + "STATUS CODE: " + response.StatusCode + "\n" + "PAYLOAD: " + response.Payload;

            //try
            //{
            //    string json = JsonConvert.SerializeObject(request, Formatting.Indented);
            //    XNode node = JsonConvert.DeserializeXNode(json, "Request");
            //    JsonFormat.Text = json;
            //    XmlFormat.Text = node.ToString();
            //    response.Status = EStatus.SUCCESS;
            //    response.StatusCode = 2000;
            //    response.Payload = "";
            //    Response.Text = "STATUS: " + response.Status + "\n" + "STATUS CODE: " + response.StatusCode + "\n" + "PAYLOAD: " + response.Payload;

            //}

            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //} 
        }
    }
}

