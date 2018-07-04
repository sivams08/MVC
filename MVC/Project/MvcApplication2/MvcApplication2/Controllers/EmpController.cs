using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/
        static List<Employee> EData = new List<Employee>();
        public ActionResult EmployeeDetail()
        {
            return View(EData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee E)
        {
            EData.Add(E);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            foreach (Employee E1 in EData)
            {
                if (E1.EmpId == id)
                    return View(E1);
            }
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee E)
        {
            foreach (Employee E1 in EData)
            {
                if (E1.EmpId == E.EmpId)
                {
                    E1.EmpName = E.EmpName;
                    E1.Gender = E.Gender;
                }
            }
            return View();
        }
        public ActionResult Details(int id)
        {
            foreach (Employee obj in EData)
            {
                if (obj.EmpId == id)
                {
                    return View(obj);
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            foreach (Employee E1 in EData)
            {
                if (E1.EmpId == id)
                    return View(E1);
            }
            return View();
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Deleteconfirmed(int id)
        {
            foreach (Employee E1 in EData)
            {
                if (E1.EmpId == id)
                {
                    EData.Remove(E1);
                    return View();
                }
            }
            return View();
        }
    }
}
