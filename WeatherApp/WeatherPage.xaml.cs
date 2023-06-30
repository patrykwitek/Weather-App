using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public List<Models.List> WeatherList;
	public WeatherPage()
	{
		InitializeComponent();
		WeatherList = new List<Models.List>();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		var result = await ApiService.GetWeather(50.054810, 19.927839);
		foreach(var item in result.list)
		{
			WeatherList.Add(item);
		}
		CvWeather.ItemsSource = WeatherList;

		LblCity.Text = result.city.name;
		LblWeatherDescription.Text = result.list[0].weather[0].description;
		LblTemperature.Text = result.list[0].main.temperature + "°C";
		LblHumidity.Text = result.list[0].main.humidity + "%";
		LblWind.Text = result.list[0].wind.speed + "km/h";
		ImgWeatherIcon.Source = result.list[0].weather[0].customIcon + ".png";
	}
}