using AppIocControllers.Interfaces;

namespace AppIocControllers.LayerBusiness.Entities
{
    public class Config : IConfig
    {
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
