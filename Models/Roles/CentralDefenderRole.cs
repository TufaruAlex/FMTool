namespace FM_Tool.Models.Roles
{
    public class CentralDefenderRole : IRole
    {
        public double ComputeScore(Player player, Mentality mentality)
        {
            double score = 0;
            if (mentality == Mentality.Defense)
            {
                score += player.Heading * 2;
                score += player.Marking * 2;
                score += player.Tackling * 2;
                score += player.Aggression;
                score += player.Anticipation;
                score += player.Bravery;
                score += player.Composure;
                score += player.Concentration;
                score += player.Decisions;
                score += player.Positioning * 2;
                score += player.Jumping_Reach * 2;
                score += player.Pace;
                score += player.Strength * 2;
                return score / 19;
            }
            else if (mentality == Mentality.Cover)
            {
                score += player.Heading;
                score += player.Marking * 2;
                score += player.Tackling * 2;
                score += player.Anticipation * 2;
                score += player.Bravery;
                score += player.Composure;
                score += player.Concentration * 2;
                score += player.Decisions * 2;
                score += player.Positioning * 2;
                score += player.Jumping_Reach;
                score += player.Pace * 2;
                score += player.Strength;
                return score / 19;
            }
            else if (mentality == Mentality.Stopper)
            {
                score += player.Heading * 2;
                score += player.Marking;
                score += player.Tackling * 2;
                score += player.Aggression * 2;
                score += player.Anticipation;
                score += player.Bravery * 2;
                score += player.Composure;
                score += player.Concentration;
                score += player.Decisions * 2;
                score += player.Positioning * 2;
                score += player.Jumping_Reach * 2;
                score += player.Strength * 2;
                return score / 20;
            }
            throw new NotSupportedException("This mentality is not supported for this role.");
        }
    }
}
