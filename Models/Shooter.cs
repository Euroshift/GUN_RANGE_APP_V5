﻿using System;

namespace GUN_RANGE_APP_V5.Models
{
    public class Shooter
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CID { get; set; } = string.Empty;
        public string Team { get; set; } = string.Empty;
        public string Division { get; set; } = string.Empty;
        public string GunInformation { get; set; } = string.Empty;
        public string QualificationsTraining { get; set; } = string.Empty;
        public string AdditionalTrainingType { get; set; } = string.Empty;
        public int AdditionalTrainingHours { get; set; }
        public bool IsRetired { get; set; }
        public bool IsActive { get; set; }
        public string OfficerId { get; set; } = string.Empty;
        public string IssuedEquipment { get; set; } = string.Empty;
        public string LastRangeDate { get; set; } = string.Empty;
        public string MarksAwards { get; set; } = string.Empty;
    }
}