using System.Linq;
using System.Net;
using System.Web.Mvc;
using OnionArchitecture.Core;
using OnionArchitecture.Core.Interfaces;

namespace OnionArchitecture.Web.Controllers
{
    public class BloodDonorsController : Controller
    {
        IBloodDonorRepository _db;

        public BloodDonorsController(IBloodDonorRepository db)
        {
            this._db = db;
        }

        // GET: BloodDonors
        public ActionResult Index()
        {
            return View(_db.GetBloodDonors().ToList());
        }

        // GET: BloodDonors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonor bloodDonor = _db.FindById(id);
            if (bloodDonor == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonor);
        }

        // GET: BloodDonors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloodDonors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BloodDonorID,Name,BloodGroup,City,Country,PinCode,PhoneNumber,Email,IsActive,IsPrivate,IsVerified")] BloodDonor bloodDonor)
        {
            if (ModelState.IsValid)
            {
                _db.Add(bloodDonor);
                return RedirectToAction("Index");
            }

            return View(bloodDonor);
        }

        // GET: BloodDonors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonor bloodDonor = _db.FindById(id);
            if (bloodDonor == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonor);
        }

        // POST: BloodDonors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BloodDonorID,Name,BloodGroup,City,Country,PinCode,PhoneNumber,Email,IsActive,IsPrivate,IsVerified")] BloodDonor bloodDonor)
        {
            if (ModelState.IsValid)
            {
                _db.Edit(bloodDonor);
                return RedirectToAction("Index");
            }
            return View(bloodDonor);
        }

        // GET: BloodDonors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodDonor bloodDonor = _db.FindById(id);
            if (bloodDonor == null)
            {
                return HttpNotFound();
            }
            return View(bloodDonor);
        }

        // POST: BloodDonors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BloodDonor bloodDonor = _db.FindById(id);
            _db.Remove(bloodDonor.BloodDonorID);
            return RedirectToAction("Index");
        }

    }
}
