namespace Refit.Mvc.Helpers;

[Headers("Content-Type: application/json")]
public interface IApiService
{
    [Get("/WeatherForecast/GetDatas")]
    Task<ApiResponse<string>> GetDatas();

    [Post("/WeatherForecast/UpdateAnnualEstimationById")]
    Task<ApiResponse<string>> AddNewData();

    [Put("/WeatherForecast/UpdateAnnualEstimationById")]
    Task<ApiResponse<string>> UpdateData();

    [Delete("/WeatherForecast/DeleteMaintanceData")]
    Task<ApiResponse<string>> DeleteData(int maintanceId);
}
