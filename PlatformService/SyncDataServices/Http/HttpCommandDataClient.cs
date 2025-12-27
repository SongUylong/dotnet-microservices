using System.Text.Json;
using PlatformService.Dtos;
using System.Text;
namespace PlatformService.SyncDataServices.Http
{
  public class HttpCommandDataClient : ICommandDataClient
  {
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
    {
      _httpClient = httpClient;
      _configuration = configuration;
    }

    public async Task sendPlatformToCommand(PlatformReadDto plat)
    {
      var httpContent =
          new StringContent(JsonSerializer.Serialize(plat), Encoding.UTF8, "application/json");
      var response = await _httpClient.PostAsync(
          $"{_configuration["CommandService"]}/api/c/commands", httpContent);
      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("--> Sync Post To CommandService Was Ok!");
      }
      else
      {
        Console.WriteLine("--> Sync Post To CommandService Was NOT Ok!");
      }
    }
  }
}
