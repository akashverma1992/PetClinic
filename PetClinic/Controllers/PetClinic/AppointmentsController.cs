using PetClinic.Models.PetClinicModels;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace PetClinic.Controllers.PetClinic {
    public class AppointmentsController : Controller {
        private PetClinicDBContext db = new PetClinicDBContext();

        // GET: Appointments
        public ActionResult Index(string searchAppointment) {
            //return View(db.Appointments.ToList());
            var aptID = from id in db.Appointments select id;
            if (!string.IsNullOrEmpty(searchAppointment)) {
                aptID = aptID.Where(i => i.AppointmentID.Contains(searchAppointment));
            }
            return View(aptID);
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null) {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // GET: Appointments/Create
        public ActionResult Create() {
            PetClinicDBContext db = new PetClinicDBContext();
            ViewBag.Doctors = new SelectList(db.Doctors, "ID", "DoctorName");
            ViewBag.Rooms = new SelectList(db.Doctors, "ID", "RoomNumber");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ClientName,DoctorName,Date,RoomNumber")] Appointment appointment) {
            if (ModelState.IsValid) {
                // insert appointment check code for the same date
                string aptno = this.createAppointmentID(appointment);
                appointment.AppointmentID = aptno;
                //appointment.DoctorName;

                db.Appointments.Add(appointment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null) {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ClientName,DoctorName,Date,RoomNumber")] Appointment appointment) {
            if (ModelState.IsValid) {
                db.Entry(appointment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(appointment);
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int? id) {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appointment appointment = db.Appointments.Find(id);
            if (appointment == null) {
                return HttpNotFound();
            }
            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {
            Appointment appointment = db.Appointments.Find(id);
            db.Appointments.Remove(appointment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private string createAppointmentID(Appointment appointment) {
            int index = appointment.ClientName.IndexOf(" ");
            char[] name = new char[appointment.ClientName.Length];
            for (int i = 0; i < appointment.ClientName.Length; i++) {
                if (appointment.ClientName[i] != appointment.ClientName[index]) {
                    name[i] = appointment.ClientName[i];
                }
            }
            string aptno = new string(name)
                    + "-" + appointment.RoomNumber
                    + "-" + appointment.Date.Year
                    + "-" + appointment.Date.Month
                    + "-" + appointment.Date.Day;
            return aptno;
        }
    }
}
