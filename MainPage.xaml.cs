using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


using System.Net;

namespace TestPCL
{
	public partial class MainPage : ContentPage
	{
        WebClient client = new WebClient();
        //-----------------------
        //Тестовый комментарий 1
        //-----------------------
		public MainPage()
		{
			InitializeComponent();
            //client.DownloadFile("test.com", "test_file");
            label1.Text = client.ToString();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button1.Text = client.ToString();
        }

    }
}
