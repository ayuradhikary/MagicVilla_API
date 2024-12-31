using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
                new VillaDTO{Id=1, Name="Pool view", Sqft=100,Occupency=4},
                new VillaDTO{Id=2, Name="Beach View", Sqft=50,Occupency=3}
        };
    }
}
