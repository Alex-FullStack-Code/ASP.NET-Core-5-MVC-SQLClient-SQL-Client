using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sweetalert.Controllers;
using sweetalert.Models;
using System.Threading.Tasks;

namespace HealthAppFrontend.Controllers
{
    public class MedicalCenterFrontController : BaseController
    {

        private readonly IMedicalCenterRepository _medicalCenterRepository;
        
        public MedicalCenterFrontController(IMedicalCenterRepository medicalCenterRepository)
        {
           _medicalCenterRepository = medicalCenterRepository;
        }

        // GET: MedicalCenterFrontController
        public async Task<ActionResult> Index()
        {
            string UrlWebApi = "http://localhost:20495/centers";
        
            return View(await _medicalCenterRepository.GetAllAsync(UrlWebApi));
        }

        // GET: MedicalCenterFrontController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string UrlWebApi = $"http://localhost:20495/centers/{id}";
            return View(await _medicalCenterRepository.GetByIdAsync(UrlWebApi));
        }

        // GET: MedicalCenterFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedicalCenterFrontController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MedicalCenterFront newMedicalCenter)
        {
            try
            {
                string UrlWebApi = "http://localhost:20495/centers";
                await _medicalCenterRepository.InsertAsync(UrlWebApi, newMedicalCenter);
                //Notify("Se ha creado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible crear", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: MedicalCenterFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MedicalCenterFrontController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, MedicalCenterFront medicalCenterFront)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/centers/{id}";
                await _medicalCenterRepository.UpdateAsync(UrlWebApi, medicalCenterFront);
                //Notify("Se ha actualizado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible actualizar", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: MedicalCenterFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MedicalCenterFrontController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, MedicalCenterFront medicalCenterFront)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/centers/{medicalCenterFront.id}";
                var response = await _medicalCenterRepository.DeleteAsync(UrlWebApi);
                //Notify("Se ha eliminado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No se ha podido eliminar el centro medico debido a una dependencia", notificationType: NotificationType.error);
                return View();
            }
        }
    }
}
