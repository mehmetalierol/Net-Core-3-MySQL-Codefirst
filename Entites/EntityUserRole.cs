using Net_Core_3_MySQL_Codefirst.Base;
using Net_Core_3_MySQL_Codefirst.Entites.Interfaces;

namespace Net_Core_3_MySQL_Codefirst.Entites
{
    public class EntityUserRole : BaseEntity, IEntityUserRole
    {
        public EntityRole Role { get; set; }
        public EntityUser User { get; set; }
    }
}
