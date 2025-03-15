using AppIocDemo.Interfaces;

namespace AppIocDemo.LayerBusiness.Entities
{
    public class Config : IConfig
    {
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
