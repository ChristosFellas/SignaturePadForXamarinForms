using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace SigniturePadDemo
{
    public partial class SignaturePadPage : ContentPage
    {
        public SignaturePadPage()
        {
            InitializeComponent();
        }

        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            Stream image = await PadView1.GetImageStreamAsync(SignaturePad.Forms.SignatureImageFormat.Jpeg);
        }

        private void ClearButton_Clicked(object sender, System.EventArgs e)
        {
            PadView1.Clear();
        }
    }
}
