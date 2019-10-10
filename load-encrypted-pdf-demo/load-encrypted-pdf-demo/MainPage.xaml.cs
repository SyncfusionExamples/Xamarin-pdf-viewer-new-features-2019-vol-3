using Syncfusion.SfPdfViewer.XForms;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;

namespace load_encrypted_pdf_demo
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool textChanged = false;
        public MainPage()
        {
            InitializeComponent();
            pdfViewer.PasswordErrorOccurred += PdfViewer_PasswordErrorOccurred;
            Stream stream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("load-encrypted-pdf-demo.Assets.Encrypted Document.pdf");
            pdfViewer.LoadDocument(stream);
            SetPlatformDesign();
        }

        /// <summary>
        ///This to handle the password errors occurs during loading the PDF documents .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PdfViewer_PasswordErrorOccurred(object sender, PasswordErrorOccurredEventArgs e)
        {
            if (e.Title.Contains("Error loading encrypted PDF document") && textChanged)
            {
                MessageLabel.Text = "Invalid Password .";
            }
            pdfviewergrid.IsVisible = false;
            pdfviewergrid.IsVisible = false;
            popupgrid.IsVisible = true;            
            popupLoginView.IsVisible = true;  
        }

        private void OKButton_Clicked(object sender, EventArgs e)
        {
            Stream stream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("load-encrypted-pdf-demo.Assets.Encrypted Document.pdf");
            stream.Position = 0;
            textChanged = true;
            popupgrid.IsVisible = false;
            pdfviewergrid.IsVisible = true;
            popupLoginView.IsVisible = false;
            pdfviewergrid.IsVisible = true;
            pdfViewer.LoadDocument(stream, PasswordEntry.Text);            
        }

        private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (e.NewTextValue.Length == 0)
            {
                OKButton.IsEnabled = false;
                MessageLabel.Text = "";
                textChanged = false;
                OKButton.BackgroundColor = Color.Transparent;
                if (Device.RuntimePlatform == Device.UWP)
                    OKButton.BackgroundColor = Color.FromRgb(204, 204, 204);
            }
            else
            {
                MessageLabel.Text = "";
                textChanged = true;
                if (!OKButton.IsEnabled)
                {
                    OKButton.IsEnabled = true;
                    OKButton.TextColor = Color.Blue;
                }
            }
        }
        void SetPlatformDesign()
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                contentsGrid.RowDefinitions[1].Height = 35;
                contentsGrid.RowDefinitions[2].Height = 40;
                contentsGrid.RowDefinitions[4].Height = 50;
                OKButton.Padding = new Thickness(20, 0, 20, 0);
                OKButton.WidthRequest = 70;
                OKButton.BackgroundColor = Color.Transparent;
                OKButton.TextColor = Color.LightBlue;
                OKButton.HorizontalOptions = LayoutOptions.End;
            }
            if (Device.RuntimePlatform == Device.iOS)
            {
                pdfViewer.Margin = new Thickness(0, 30, 0, 0);
                m_infoLabel.FontSize = 12;
                OKButton.HorizontalOptions = LayoutOptions.End;
            }
            if (Device.RuntimePlatform == Device.UWP)
            {
                OKButton.BackgroundColor = Color.FromRgb(204, 204, 204);
                OKButton.TextColor = Color.LightBlue;
                OKButton.CornerRadius = 0;
            }
        }
    }
}
