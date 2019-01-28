using Net_Core_3_MySQL_Codefirst.Base;
using Net_Core_3_MySQL_Codefirst.Entites.Interfaces;

namespace Net_Core_3_MySQL_Codefirst.Entites
{
    public class EntityRole : BaseEntity, IEntityRole
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
