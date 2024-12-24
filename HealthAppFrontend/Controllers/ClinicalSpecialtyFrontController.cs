using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sweetalert.Controllers;
using sweetalert.Models;
using System;
using System.Threading.Tasks;

namespace HealthAppFrontend.Controllers
{
    public class ClinicalSpecialtyFrontController : BaseController
    {

        private readonly IClinicalSpecialtyRepository _clinicalSpecialtyRepository;

        public ClinicalSpecialtyFrontController(IClinicalSpecialtyRepository clinicalSpecialtyRepository)
        {
            _clinicalSpecialtyRepository = clinicalSpecialtyRepository;
        }
        // GET: ClinicalSpecialtyFrontController
        public new async Task<ActionResult> Index()
        {
            string UrlWebApi = "http://localhost:20495/specialties";
            return View(await _clinicalSpecialtyRepository.GetAllAsync(UrlWebApi));
        }

        // GET: ClinicalSpecialtyFrontController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            string UrlWebApi = $"http://localhost:20495/specialties/{id}";
            return View(await _clinicalSpecialtyRepository.GetByIdAsync(UrlWebApi));
        }


        //GET: ClinicalSpecialtyFrontController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Create

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ClinicalSpecialtyFront newClinicalSpecialty)
        {
            try
            {
                string UrlWebApi = "http://localhost:20495/specialties";
                await _clinicalSpecialtyRepository.InsertAsync(UrlWebApi, newClinicalSpecialty);
                //Notify("Se ha creado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible crear", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: ClinicalSpecialtyFrontController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, ClinicalSpecialtyFront editClinicalSpecialty)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/specialties/{id}";
                await _clinicalSpecialtyRepository.UpdateAsync(UrlWebApi, editClinicalSpecialty);
                //Notify("Se ha actualizado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No ha sido posible actualizar", notificationType: NotificationType.error);
                return View();
            }
        }

        // GET: ClinicalSpecialtyFrontController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClinicalSpecialtyFrontController/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, ClinicalSpecialtyFront clinicalSpecialtyToDelete)
        {
            try
            {
                string UrlWebApi = $"http://localhost:20495/specialties/{clinicalSpecialtyToDelete.id}";                
                var response = await _clinicalSpecialtyRepository.DeleteAsync(UrlWebApi);
                //Notify("Se ha eliminado correctamente", notificationType: NotificationType.success);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                //Notify("No se ha podido eliminar la especialidad debido a una dependencia", notificationType: NotificationType.error);
                return View();
            }
        }
    }
}
