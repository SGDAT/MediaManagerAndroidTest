using Plugin.MediaManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaManagerTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await CrossMediaManager.Current.Play("http://samsongabriels.co.uk/mpthreetest/test.mp3", Plugin.MediaManager.Abstractions.Enums.MediaFileType.Audio);

            CrossMediaManager.Current.AudioPlayer.PlayingChanged += AudioPlayer_PlayingChanged;
        }

        private void AudioPlayer_PlayingChanged(object sender, Plugin.MediaManager.Abstractions.EventArguments.PlayingChangedEventArgs e)
        {
            Console.WriteLine(e.Position);
        }
    }
}
