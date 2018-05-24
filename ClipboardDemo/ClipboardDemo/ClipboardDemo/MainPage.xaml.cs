using Plugin.Clipboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClipboardDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void Copy(object sender, EventArgs e)
        {
            CrossClipboard.Current.SetText(Mensagem.Text);
            
           await DisplayAlert("Atenção", "O Texto \"" + CrossClipboard.Current.GetText() + "\" foi copiado.", "OK");
        }
    }
}
