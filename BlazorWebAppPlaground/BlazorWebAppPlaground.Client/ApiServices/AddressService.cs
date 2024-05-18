namespace BlazorWebAppPlaground.Client.ApiServices;

public class AddressService : IAddressService
{
    public List<StateDto> GetStates(int countryId)
    {
        var states = new List<StateDto>()
        {
            new()
                {
                    Id = 1,
                    CountryId = 1,
                    Name = "Kerala"
                },
            new()
                {
                    Id = 2,
                    CountryId = 1,
                    Name = "Karnataka"
                },
                            new()
                {
                    Id = 3,
                    CountryId = 1,
                    Name = "TamilNadu"
                },
            new()
                {
                    Id = 4,
                    CountryId = 1,
                    Name = "Bihar"
                },
                            new()
                {
                    Id = 5,
                    CountryId = 2,
                    Name = "Dubai"
                },
            new()
                {
                    Id = 6,
                    CountryId = 2,
                    Name = "Sharjah"
                }
        };
        return states
        .Where(x => x.CountryId == countryId)
        .ToList();
    }

    public List<CountryDto> GetCountries()
    {
        return new()
        {
            new()
            {
                Id = 1,
                Name = "India"
            },
            new()
            {
                Id = 2,
                Name = "United Arab Emirates"
            }
        };
    }
}

public class CountryDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

public class StateDto
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public required string Name { get; set; }
}
