namespace GunRangeV3.Models
{
    public class UpdatedShooterDto
    {
        public int ShooterId { get; set; }
        public string ShooterName { get; set; }
        public string ShooterCID { get; set; }
        public string ShooterTeam { get; set; }
        public string ShooterDivision { get; set; }
        public string GunInformation { get; set; }
        public string QualificationsTraining { get; set; }
        public string AdditionalTrainingType { get; set; }
        public int AdditionalTrainingHours { get; set; }
        public bool IsRetired { get; set; }
        public bool IsActive { get; set; }
        public string OfficerId { get; set; }
        public string IssuedEquipment { get; set; }
        public string LastRangeDate { get; set; }
    }

}
