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
		LblTemperature.Text = result.list[0].main.temperature + "°C";
		LblHumidity.Text = result.list[0].main.humidity + "%";
		LblWind.Text = result.list[0].wind.speed + "km/h";
		ImgWeatherIcon.Source = ApiService.GetImageName(result.list[0].weather[0].icon) + ".png";
	}
}