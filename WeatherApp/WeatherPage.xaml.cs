using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var result = await ApiService.GetWeather(50.054810, 19.927839);
		LblCity.Text = result.city.name;
		LblWeatherDescription.Text = result.list[0].weather[0].description;
	}
}