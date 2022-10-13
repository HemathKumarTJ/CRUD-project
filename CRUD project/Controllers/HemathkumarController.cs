using Crud.Core.IService;
using Crud.Core.Model;
using Crud.Entity;
using Crud.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_project.Controllers
{
    public class HemathkumarController : Controller
    {
        private readonly IDetailsServices _detailsServices;
        public HemathkumarController(IDetailsServices detailsServices)
        {

            _detailsServices = detailsServices;
        }


        #region Create
        // This is for  creating a form
        public IActionResult Winner()
        {
            return View();
        }

        public IActionResult Loser(Details details )
        {
                _detailsServices.CreateDetails(details);
                return RedirectToAction("Winner");
        }
        #endregion 

        #region Read
        // This is for Reading the  form
        public IActionResult Read()
        {
            var value = _detailsServices.ListMethod();
            return View(value);
        }  
        #endregion

        #region update
        // This is for updating the form
        public IActionResult Edit(int id)
        {
            var value = _detailsServices.SaveMethod(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(int id, Details details)
        {
            _detailsServices.Update(id, details);
            return RedirectToAction("Read");

        }
        #endregion

        #region Delete

        // This is for deleting the form

      
        public IActionResult Delete(int id)
        {
            _detailsServices.DeleteDone(id);
            return RedirectToAction("Read");

        }
        #endregion



    }
}
