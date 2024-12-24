using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sweetalert.Controllers;
using sweetalert.Models;
using System.Threading.Tasks;

namespace HealthAppFrontend.Controllers
{
    public class DoctorFrontController : BaseController
    {

        private readonly IDoctorFrontRepository _doctorFrontRepository;

        public DoctorFrontController(IDoctorFrontRepository doctorFrontRepository)
        {
            _doctorFrontRepository = doctorFrontRepository;
        }
        // GET: DoctorFrontController
        public async Task<ActionResult> Index()
        {
            string UrlWebApi = "http://localhost:20495/doctores";
            return View(await _doctorFrontRepository.GetAllAsync(UrlWebApi));
        }

        // GET: DoctorFrontController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string UrlWebApi = $"http://localhost:20495/doctores/{id}";
            return View(await _doctorFrontRepository.GetByIdAsync(UrlWebApi));
        }

        // GET: DoctorFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorFrontController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RichDoctorFront richDoctorFront)
        {
            try
            {
                string UrlWebApi = "http://localhost:20495/doctores";
                await _doctorFrontRepository.InsertAsync(UrlWebApi, richDoctorFront);
                //Notify("Se ha creado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible crear", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: DoctorFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DoctorFrontController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, RichDoctorFront richDoctorFront)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/doctores/{id}";
                await _doctorFrontRepository.UpdateAsync(UrlWebApi, richDoctorFront);
                //Notify("Se ha actualizado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible actualizar", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: DoctorFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DoctorFrontController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, RichDoctorFront richDoctorFront)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/doctores/{richDoctorFront.id}";
                var response = await _doctorFrontRepository.DeleteAsync(UrlWebApi);
                //Notify("Se ha eliminado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No se ha podido eliminar el doctor", notificationType: NotificationType.error);
                return View();
            }
        }
    }
}
