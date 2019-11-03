using are_den.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace are_den.Controllers
{
    public class ProjectController : Controller
    {
        private ProjectContext db = new ProjectContext();

        // GET: Project
        public ActionResult List()
        {
            var projects = db.Projects.Where(i => i.StartDate == "2014").Select(i => new ProjectModel()
            {

                Id = i.Id,
                ProjectName = i.ProjectName.Length > 30 ? i.ProjectName.Substring(0, 100) + "..." : i.ProjectName,
                AgreementType = i.AgreementType,
                Contractor = i.Contractor,
                Employer = i.Employer,
                Placement = i.Placement,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                Duty = i.Duty,
                OperationTime = i.OperationTime,
                ProjectImage = i.ProjectImage


            }).AsQueryable();
            Console.WriteLine(projects);

            return View(projects.ToList());
        }

        public ActionResult Index()
        {
            var projects = db.Projects.Select(i => new ProjectModel()
            {

                Id = i.Id,
                ProjectName = i.ProjectName.Length > 45 ? i.ProjectName.Substring(0, 30) + "..." : i.ProjectName,
                AgreementType = i.AgreementType,
                Contractor = i.Contractor,
                Employer = i.Employer,
                Placement = i.Placement,
                StartDate = i.StartDate,
                EndDate = i.EndDate,
                Duty = i.Duty,
                OperationTime = i.OperationTime,
                ProjectImage = i.ProjectImage


            });

            return View(projects.ToList());
        }

        // GET: Project/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // GET: Project/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProjectName,Contractor,Employer,AgreementType,Placement,StartDate,EndDate,Area,Duty,OperationTime,ProjectImage")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Project/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Project/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProjectName,Contractor,Employer,AgreementType,Placement,StartDate,EndDate,Area,Duty,OperationTime,ProjectImage")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: Project/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
