
using GUN_RANGE_APP_V5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GUN_RANGE_APP_V5.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var shooters = _dbContext.Shooters.ToList();
            var viewModel = new ShooterListViewModel
            {
                Shooters = shooters
            };
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult GetShooter(int id)
        {
            var shooter = _dbContext.Shooters.FirstOrDefault(s => s.Id == id);
            return Json(shooter);
        }


        [HttpPost]
        public IActionResult UpdateShooter(int shooterId, string shooterName, string shooterCID, string shooterTeam, string shooterDivision, string shooterGunInformation,
            string shooterQualificationsTraining, string shooterAdditionalTrainingType, int shooterAdditionalTrainingHours, bool shooterisRetired, bool shooterisActive,
            string shooterOfficerId, string shooterIssuedEquipment, string shooterLastDateRange)
        {
            var upShooter = _dbContext.Shooters.Find(shooterId);
            if (upShooter != null)
            {
                upShooter.Name = shooterName;
                upShooter.CID = shooterCID;
                upShooter.Team = shooterTeam;
                upShooter.Division = shooterDivision;
                upShooter.GunInformation = shooterGunInformation;
                upShooter.QualificationsTraining = shooterQualificationsTraining;
                upShooter.AdditionalTrainingType = shooterAdditionalTrainingType;
                upShooter.AdditionalTrainingHours = shooterAdditionalTrainingHours;
                upShooter.IsRetired = shooterisRetired;
                upShooter.IsActive = shooterisActive;
                upShooter.OfficerId = shooterOfficerId;
                upShooter.IssuedEquipment = shooterIssuedEquipment;
                upShooter.LastRangeDate = shooterLastDateRange;

                _dbContext.SaveChanges();
                return Json(new { success = true, message = "Shooter updated successfully." });
            }
            else
            {
                return Json(new { success = false, message = "Shooter not found." });
            }
        }

        [HttpPost]
        public IActionResult AddNewShooter(string shooterName, string shooterCID, string shooterTeam, string shooterDivision, string shooterGunInformation,
            string shooterQualificationsTraining, string shooterAdditionalTrainingType, int shooterAdditionalTrainingHours, bool shooterIsRetired, bool shooterIsActive,
            string shooterOfficerId, string shooterIssuedEquipment, string shooterLastRangeDate)
        {
            try
            {
                // Create a new Shooter object and populate its properties
                var newShooter = new Shooter
                {
                    // Generate a new ID for the shooter (assuming the ID is an auto-increment primary key in the database)
                    // You can adjust this part based on your database configuration
                    // For databases like SQL Server, IDENTITY column will auto-generate IDs
                    // For other databases, you may need to implement a mechanism to generate unique IDs
                    // ID = <Generated ID>,
                    Name = shooterName,
                    CID = shooterCID,
                    Team = shooterTeam,
                    Division = shooterDivision,
                    GunInformation = shooterGunInformation,
                    QualificationsTraining = shooterQualificationsTraining,
                    AdditionalTrainingType = shooterAdditionalTrainingType,
                    AdditionalTrainingHours = shooterAdditionalTrainingHours,
                    IsRetired = shooterIsRetired,
                    IsActive = shooterIsActive,
                    OfficerId = shooterOfficerId,
                    IssuedEquipment = shooterIssuedEquipment,
                    LastRangeDate = shooterLastRangeDate
                    // Add other properties as needed
                };

                // Add the new shooter to the database
                _dbContext.Shooters.Add(newShooter);
                _dbContext.SaveChanges();

                return Json(new { success = true, message = "Shooter added successfully." });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Failed to add shooter. " + ex.Message });
            }
        }



        [HttpPost]
        public IActionResult DeleteShooter(int shooterId)
        {
            var delShooter = _dbContext.Shooters.Find(shooterId);
            if (delShooter != null)
            {
                _dbContext.Shooters.Remove(delShooter); // Remove the shooter from the DbSet


                _dbContext.SaveChanges();
                return Json(new { success = true, message = "Shooter DELETED successfully." });
            }
            else
            {
                return Json(new { success = false, message = "Shooter not found." });
            }
        }




        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}