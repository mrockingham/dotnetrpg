using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Wizard = 1,
        
        Brawler = 2,

        Healer = 3,

        Gunner = 4,

            }
}