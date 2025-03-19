using AppIocDemo.Model.Interfaces;

namespace AppIocDemo.LayerBusiness.Entities
{
    public class UserConfig : IUserConfig
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
