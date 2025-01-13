using FM_Tool.Models.Roles;

namespace FM_Tool.Models
{
    public class Player
    {
        public int Corners { get; set; }
        public int Crossing { get; set; }
        public int Dribbling { get; set; }
        public int Finishing { get; set; }
        public int First_Touch { get; set; }
        public int Free_Kick_Taking { get; set; }
        public int Heading { get; set; }
        public int Long_Shots { get; set; }
        public int Long_Throws { get; set; }
        public int Marking { get; set; }
        public int Passing { get; set; }
        public int Penalty_Taking { get; set; }
        public int Tackling { get; set; }
        public int Technique { get; set; }
        public int Aggression { get; set; }
        public int Anticipation { get; set; }
        public int Bravery { get; set; }
        public int Composure { get; set; }
        public int Concentration { get; set; }
        public int Decisions { get; set; }
        public int Determination { get; set; }
        public int Flair { get; set; }
        public int Leadership { get; set; }
        public int Off_The_Ball { get; set; }
        public int Positioning { get; set; }
        public int Teamwork { get; set; }
        public int Vision { get; set; }
        public int Work_Rate { get; set; }
        public int Acceleration { get; set; }
        public int Agility { get; set; }
        public int Balance { get; set; }
        public int Jumping_Reach { get; set; }
        public int Natural_Fitness { get; set; }
        public int Pace { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Aerial_Reach { get; set; }
        public int Command_Of_Area { get; set; }
        public int Communication { get; set; }
        public int Eccentricity { get; set; }
        public int Handling { get; set; }
        public int Kicking { get; set; }
        public int One_On_Ones { get; set; }
        public int Reflexes { get; set; }
        public int Punching { get; set; }
        public int Rushing_Out { get; set; }
        public int Throwing { get; set; }

        public double GetRoleScore(IRole role, Mentality mentality)
        {
            return role.ComputeScore(this, mentality);
        }
    }
}
