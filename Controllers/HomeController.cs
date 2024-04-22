
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

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}