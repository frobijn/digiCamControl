using CameraControl.Core.Classes;
using System.Windows;

namespace CameraControl.windows
{
	/// <summary>
	/// Interaction logic for Welcome.xaml
	/// </summary>
	public partial class Welcome
	{
		public Welcome ()
		{
			InitializeComponent();
		}

		private void btn_facebook_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("http://www.facebook.com/DigiCamControl");
			Close();
		}

		private void btn_google_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("https://plus.google.com/+Digicamcontrol");
			Close();
		}

		private void btn_donate_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("http://digicamcontrol.com/donate");
			Close();
		}

		private void btn_twitter_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("https://twitter.com/digiCamControl");
			Close();
		}

		private void btn_flickr_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("https://www.flickr.com/groups/2224376@N22/");
			Close();
		}

		private void btn_site_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("http://digicamcontrol.com/");
		}

		private void btn_fork_Click (object sender, RoutedEventArgs e)
		{
			PhotoUtils.Run("https://github.com/frobijn/digiCamControl/");
		}
	}
}
