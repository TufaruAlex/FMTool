namespace FM_Tool.Models.Roles
{
    public interface IRole
    {
        double ComputeScore(Player player, Mentality mentality);
    }
}
