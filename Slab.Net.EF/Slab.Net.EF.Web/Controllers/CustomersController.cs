using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Entities.Model.DTOS;
using Slab.Net.EF.Entities.Model.Mapper;
using Slab.Net.EF.Logic;

namespace Slab.Net.EF.Web.Controllers
{
    public class CustomersController : Controller
    {

        static readonly CustomersLogic logic = new CustomersLogic();
        static readonly CustomersMapper mapper = new CustomersMapper();
       
        // GET: Customers/Listado
        public ActionResult Listado()
        {
            return View(mapper.Map(logic.GetAll()));
        }



        // POST: Customers/Delete/5
        public ActionResult Delete(string ID)
        {
            if (ID == null)
                return Json(data: "Not Deleted", behavior: JsonRequestBehavior.AllowGet);
            try
            {
                logic.Remove(ID);
                return Json(data: "Deleted", behavior: JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var aux = ex;
                while (aux.InnerException != null)
                    aux = aux.InnerException;
                return Json(data: aux.Message, behavior: JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Customers/Update
        public ActionResult Update(CustomerDTO customer)
        {
            if (customer == null)
                return Json(data: "Not Deleted", behavior: JsonRequestBehavior.AllowGet);
            try
            {
                logic.Update(mapper.Map(customer));
                return Json(data: "Updated", behavior: JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var aux = ex;
                while (aux.InnerException != null)
                    aux = aux.InnerException;
                return Json(data: aux.Message, behavior: JsonRequestBehavior.AllowGet);
            }
        }

        // POST: Customers/Insert
        public ActionResult Insert(CustomerDTO customer)
        {
            if (customer == null)
                return Json(data: "Not Deleted", behavior: JsonRequestBehavior.AllowGet);
            try
            {
                logic.Add(mapper.Map(customer));
                return Json(data: "Added", behavior: JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var aux = ex;
                while (aux.InnerException != null)
                    aux = aux.InnerException;
                return Json(data: aux.Message, behavior: JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Customers/Details/5
        public ActionResult Details(String ID)
        {
            return View(mapper.Map(logic.Get(ID)));
        }

    }
}

