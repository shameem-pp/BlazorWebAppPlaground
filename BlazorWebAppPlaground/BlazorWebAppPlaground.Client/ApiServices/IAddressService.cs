
namespace BlazorWebAppPlaground.Client.ApiServices;

public interface IAddressService
{
    List<CountryDto> GetCountries();
    List<StateDto> GetStates(int countryId);
}