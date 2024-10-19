using MasterPiece.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterPiece.Controllers
{
    public class HomeController : Controller
    {
        private MasterPieceEntities6 db = new MasterPieceEntities6();
        public ActionResult Index()
        {
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitFeedback([Bind(Include = "Name,Email,Subject,Message,CreatedAt")] Feedback model)
        {
            if (ModelState.IsValid)
            {
                // Set the feedback created time
                model.CreatedAt = DateTime.Now;

                // Save the feedback to the database
                db.Feedbacks.Add(model);
                db.SaveChanges();

                // Set a flag in TempData to indicate a successful submission
                TempData["FeedbackSuccess"] = true;

                // Ensure TempData survives the redirect
                TempData.Keep("FeedbackSuccess");

                // Redirect to the same page to clear the form
                return RedirectToAction("Index");
            }
            return View("Index", model);  // Return the same view in case of validation failure
        }


    }
}