namespace SampleApp;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
        Disappearing += ModalPage_Disappearing;
	}

    private void ModalPage_Disappearing(object? sender, EventArgs e)
    {
    }

    private void CloseModalBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}