using WeatherApp.Helpers;
using WeatherApp.Services;

namespace WeatherApp;

public partial class WeatherPage : ContentPage
{
	public List<Models.List> WeatherData;
	private double Latitude;
	private double Longitude;

	public WeatherPage()
	{
		InitializeComponent();
		WeatherData = new List<Models.List>();
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await GetLocation();
        await GetWeatherDataByLocation(Latitude, Longitude);
    }

	public async Task GetLocation()
	{
		Location location = await Geolocation.GetLocationAsync();
		Latitude = location.Latitude;
		Longitude = location.Longitude;
	}

	public async Task GetWeatherDataByLocation(double latitude, double longitude)
	{
        var result = await WeatherService.GetWeather(latitude, longitude);
        SetWeatherData(result);
    }

    public async Task GetWeatherDataByCityName(string city)
    {
        var result = await WeatherService.GetWeatherByCityName(city);
		SetWeatherData(result);
    }

    public void SetWeatherData(dynamic result)
    {
        foreach(var item in result.list)
        {
            WeatherData.Add(item);
        }
        CvWeather.ItemsSource = WeatherData;

        City.Text = result.city.name;
        WeatherDescription.Text = result.list[0].weather[0].description;
        Temperature.Text = result.list[0].main.temperature + ConstantHelper.CelciusDegrees;
        Humidity.Text = result.list[0].main.humidity + ConstantHelper.Percent;
        Wind.Text = result.list[0].wind.speed + ConstantHelper.KilometersPerHour;
        ImgWeatherIcon.Source = result.list[0].weather[0].customIcon + ConstantHelper.FormatFilePNG;
    }

    private async void TapCurrentLocationWeather(object sender, EventArgs e)
    {
        await GetLocation();
        await GetWeatherDataByLocation(Latitude, Longitude);
    }

    private async void ClickCityWeather(object sender, EventArgs e)
	{
		var response = await DisplayPromptAsync("", "", ConstantHelper.CityPopupAccept, ConstantHelper.CityPopupCancel, ConstantHelper.CityPopupContent);
		if (response is not null)
		{
            await GetWeatherDataByCityName(response);
		}
	}
}