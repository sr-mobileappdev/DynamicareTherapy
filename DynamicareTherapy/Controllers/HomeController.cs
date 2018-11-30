using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicareTherapy.Controllers
{
    
    public class HomeController : Controller
    {
        private DataService.IOutcomeGoals outcomeGoalService;
        private DataService.IClients clientService;
        private DataService.IMonitor monitorService;
        private DataService.IMonitorDetail monitorDetailService;
        private DataService.IMonitorOutcomeStatus monitorOutcomeStatusService;


        public HomeController(DataService.IOutcomeGoals outcomeGoalService,
            DataService.IClients clientService, DataService.IMonitor monitorService, DataService.IMonitorDetail monitorDetailService, DataService.IMonitorOutcomeStatus monitorOutcomeStatusService)
        {
            this.outcomeGoalService = outcomeGoalService;
            this.clientService = clientService;
            this.monitorDetailService = monitorDetailService;
            this.monitorService = monitorService;
            this.monitorOutcomeStatusService = monitorOutcomeStatusService;
        }
        public ActionResult Index()
        {
            ViewBag.Goals = outcomeGoalService.All().Where(o=>o.ClientMPI== 6000279).ToList();
            ViewBag.ClientMPI = 6000279;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GoalsPartial(int? ClientMPI)
        {
            if (ClientMPI != null)
            {
                var masters = monitorService.All().Where(o => o.ClientMPI == ClientMPI).FirstOrDefault();

                var detail = monitorDetailService.All().Where(o => o.IEPlProgressMonitorID == masters.IEPProgressMonitorID).ToList();
                ViewBag.Details = detail;
                ViewBag.Goals = outcomeGoalService.All().Where(o=>o.ClientMPI==ClientMPI).ToList();
                ViewBag.statuses = monitorOutcomeStatusService.All().ToList();
                ViewBag.ClientMPI = ClientMPI;

            }

            return PartialView();
        }

        public ActionResult LoadAll([DataSourceRequest]DataSourceRequest command,int? ClientMPI)
        {
            if (ClientMPI != null)
            {
                var list = monitorService.All().Where(o => o.ClientMPI == ClientMPI).ToList();

                return Json(list.ToDataSourceResult(command), JsonRequestBehavior.AllowGet);
            }

            return Json(null);
        }

        public ActionResult LoadAllDetail([DataSourceRequest]DataSourceRequest command, int MonitorID)
        {
            var list = monitorDetailService.All().Where(o => o.IEPlProgressMonitorID == MonitorID).ToList();

            return Json(list.ToDataSourceResult(command), JsonRequestBehavior.AllowGet);
        }

        public ActionResult LoadClients()
        {
            var list = clientService.All().Select(o => new { ID = o.ClientMPI, Name = o.ClientMPI });

            return Json(new SelectList(list,"ID","Name"), JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult SaveDetail(int Status,string Progress,string Strategy,int OutcomeGoalID,int ClientMPI,int? DetailID,string GoalStatement)
        {
            try
            {
              
                if (DetailID.HasValue)
                {
                    var model = monitorDetailService.Get(DetailID.Value);
                    var goal = outcomeGoalService.Get(OutcomeGoalID);
                    model.NewOutcomeGoal = Strategy;
                    model.ProgressInformation = Progress;
                    model.IEPProgressMonitorOutcomeStatusID = Status;

                    model.DateModified = DateTime.Now;
                    monitorDetailService.Update(model);

                    goal.Strategies = Strategy;
                    goal.ProgressMeasurements = Progress;
                    goal.GoalStatement = GoalStatement;
                    goal.DateModified = DateTime.Now;
                    outcomeGoalService.Update(goal);


                }
                else
                {
                    var goal = new DataModel.Models.IEPOutcomeGoal();
                    goal.Strategies = Strategy;
                    goal.ClientMPI = ClientMPI;
                    var number = outcomeGoalService.All().Where(o => o.ClientMPI == ClientMPI).OrderByDescending(o => o.GoalNumber).FirstOrDefault();
                    goal.GoalNumber = number != null ? number.GoalNumber+1 : 1;
                    goal.DateGoalDeveloped = DateTime.Now;
                    goal.ProgressMeasurements = Progress;
                    goal.GoalStatement = GoalStatement;
                    goal.DateModified = DateTime.Now;
                    outcomeGoalService.Add(goal);

                    var header = monitorService.All().Where(o => o.ClientMPI == ClientMPI).FirstOrDefault();
                    var model = new DataModel.Models.IEPProgressMonitorDetail();
                    model.IEPOutcomeGoalID = goal.IEPOutcomeGoalID;//OutcomeGoalID;
                    model.NewOutcomeGoal = Strategy;
                    model.ProgressInformation = Progress;
                    model.IEPProgressMonitorOutcomeStatusID = Status;
                    model.IEPlProgressMonitorID = header.IEPProgressMonitorID;
                    model.DateCreated = DateTime.Now;
                    model.DateModified = DateTime.Now;
                    monitorDetailService.Add(model);

                }
              
                return Json("Success");

            }catch(Exception ex)
            {
                return Json("Failed");
            }
        }
        [HttpPost]
        public ActionResult DeleteDetail(int DetailID)
        {
            try
            {

                monitorDetailService.Delete(monitorDetailService.Get(DetailID));

                return Json("Success");


            }
            catch (Exception ex)
            {
                return Json("Failed");

            }
        }
    }
}