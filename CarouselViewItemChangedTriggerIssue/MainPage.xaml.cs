using System.Diagnostics;

namespace CarouselViewItemChangedTriggerIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}

    private void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    {
		//This should be called once when the Carousel is initialized.
		Debug.WriteLine("CurrentItemChanged CarouselView");
    }
}


