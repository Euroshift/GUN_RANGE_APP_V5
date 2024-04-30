using System;

namespace GUN_RANGE_APP_V5.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string OfficerId { get; set; } = string.Empty;
        public string GunInformation { get; set; } = string.Empty;
        public string AdditionalEquipment { get; set; } = string.Empty;
                       
    }
}