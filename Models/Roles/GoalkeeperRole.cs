namespace FM_Tool.Models.Roles
{
    public class GoalkeeperRole : IRole
    {
        public double ComputeScore(Player player, Mentality mentality)
        {
            if (mentality == Mentality.Defense) {
                double score = 0;
                score += player.Aerial_Reach * 2;
                score += player.Command_Of_Area * 2;
                score += player.Communication * 2;
                score += player.Handling * 2;
                score += player.Kicking * 2;
                score += player.One_On_Ones;
                score += player.Reflexes * 2;
                score += player.Throwing;
                score += player.Anticipation;
                score += player.Concentration * 2;
                score += player.Decisions;
                score += player.Positioning * 2;
                score += player.Agility * 2;
                return score / 13;
            }
            throw new NotSupportedException("This mentality is not supported for this role.");
        }
    }
}
