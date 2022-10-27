using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using StudentDetails.Models;

namespace StudentDetails.Controllers
{
    public class tblStudentInfoesController : Controller
    {
        private StudentEntities db = new StudentEntities();

        // GET: tblStudentInfoes
        public ActionResult Index()
        {
            return View(db.tblStudentInfoes.ToList());
        }

        // GET: tblStudentInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudentInfo tblStudentInfo = db.tblStudentInfoes.Find(id);
            if (tblStudentInfo == null)
            {
                return HttpNotFound();
            }
            return View(tblStudentInfo);
        }

        // GET: tblStudentInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblStudentInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "StudentId,studentName,studentMobile,studentAddress,studentDept")] tblStudentInfo tblStudentInfo)
        {
            if (ModelState.IsValid)
            {
                db.tblStudentInfoes.Add(tblStudentInfo);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblStudentInfo);
        }

        // GET: tblStudentInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudentInfo tblStudentInfo = db.tblStudentInfoes.Find(id);
            if (tblStudentInfo == null)
            {
                return HttpNotFound();
            }
            return View(tblStudentInfo);
        }

        // POST: tblStudentInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,studentName,studentMobile,studentAddress,studentDept")] tblStudentInfo tblStudentInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblStudentInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblStudentInfo);
        }

        // GET: tblStudentInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblStudentInfo tblStudentInfo = db.tblStudentInfoes.Find(id);
            if (tblStudentInfo == null)
            {
                return HttpNotFound();
            }
            return View(tblStudentInfo);
        }

        // POST: tblStudentInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblStudentInfo tblStudentInfo = db.tblStudentInfoes.Find(id);
            db.tblStudentInfoes.Remove(tblStudentInfo);
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
