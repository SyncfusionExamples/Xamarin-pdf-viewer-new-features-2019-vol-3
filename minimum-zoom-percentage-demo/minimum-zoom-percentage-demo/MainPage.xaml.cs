using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace minimum_zoom_percentage_demo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			//Read the PDF into a Stream
			Stream stream = typeof(MainPage).GetTypeInfo().Assembly.GetManifestResourceStream("minimum-zoom-percentage-demo.Assets.GIS Succinctly.pdf");

			//Load the Stream into SfPdfViewer
			pdfViewer.LoadDocument(stream);

			//Set the minimum zoom percentage value to ‘10’ (programatically)
			//pdfViewer.MinimumZoomPercentage = 50;
		}

	}
}
