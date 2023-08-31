using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public List<Models.List> WeatherList;
	private double latitude;
	private double longitude;
	public WeatherPage()
	{
		InitializeComponent();
		WeatherList = new List<Models.List>();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await GetLocation();
        await GetWeatherDataByLocation(latitude, longitude);
    }

	public async Task GetLocation()
	{
		Location location = await Geolocation.GetLocationAsync();
		latitude = location.Latitude;
		longitude = location.Longitude;
	}

	private async void TapLocation_Tapped(object sender, EventArgs e)
	{
		await GetLocation();
		await GetWeatherDataByLocation(latitude, longitude);
	}

	public async Task GetWeatherDataByLocation(double latitude, double longitude)
	{
        var result = await ApiService.GetWeather(latitude, longitude);
        foreach (var item in result.list)
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