namespace Net_Core_3_MySQL_Codefirst.Entites.Interfaces
{
    public interface IEntityUserRole
    {
        EntityRole Role { get; set; }

        EntityUser User { get; set; }
    }
}
