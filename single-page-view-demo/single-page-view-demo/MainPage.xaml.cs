using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace single_page_view_demo
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
			Stream stream = typeof(MainPage).GetTypeInfo().Assembly.GetManifestResourceStream("single-page-view-demo.Assets.GIS Succinctly.pdf");

			//Load the Stream into SfPdfViewer
			pdfViewer.LoadDocument(stream);

			//Enable the Single page view mode (programatically)
			//pdfViewer.PageViewMode = Syncfusion.SfPdfViewer.XForms.PageViewMode.PageByPage;
		}
	}
}
