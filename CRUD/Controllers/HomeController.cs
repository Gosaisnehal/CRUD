using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            CrudAppDbContext db = new CrudAppDbContext();
            /*Passing the list to view*/
            var countryList = db.tbl_Countries.ToList();
            //var contact = db.tbl_Contacts;
            ////contact.CityList 

            ViewBag.CountryList = new SelectList(countryList, "countryId", "countryName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(/*int ContactNo,*/ tbl_Contacts model)
        {

            try
            {
                if (ModelState.IsValid)

                {

                    CrudAppDbContext db = new CrudAppDbContext();
                    db.tbl_Contacts.Add(model);
                    db.SaveChanges();
                    /*To update the database and redirect to Create*/
                    TempData["Msg"] = "Contact created successfully.";
                    return RedirectToAction("Create");/*, new { ContactNo = model.contactID });*/
                }
                else
                {
                    TempData["Msg"] = "Please add some details first.";
                    return RedirectToAction("Create");
                   
                }
            }
            catch (Exception e)
            {
                TempData["Msg"] = "Contact was not created. " + e.Message;
                return RedirectToAction("Create");
            }
        }  
        [HttpGet]
        public ActionResult Read()
        {
            CrudAppDbContext db = new CrudAppDbContext();
            var list = db.tbl_Contacts.ToList();

            //var temp = db.cuntrylist(null);
            //ViewBag.temp2 = new SelectList(temp,"countryId", "countryName");

            return View(list);
        }

        public ActionResult Edit(int ContactNo)
        {
            using (var db = new CrudAppDbContext())
            {
                // accessing pertcular record for matching ID,choosen from  
                var data = db.tbl_Contacts.Where(x => x.contactID == ContactNo).SingleOrDefault();
                var countryList = db.tbl_Countries.ToList();
                ViewBag.CountryList = new SelectList(countryList, "countryId", "countryName");

                return View(data);
            }

        }

        [HttpPost]
        public ActionResult Edit(int ContactNo, tbl_Contacts model)

        {
            try
            {
                using (var db = new CrudAppDbContext())
                {
                    // accessing pertcular record for matching ID,choosen from  
                    var data = db.tbl_Contacts.Where(x => x.contactID == ContactNo).SingleOrDefault();

                    if (data != null)
                    {
                        data.firstName = model.firstName;
                        data.lastName = model.lastName;
                        data.e_mail = model.e_mail;
                        data.phoneNo = model.phoneNo;
                        data.unitNo = model.unitNo;
                        data.streetNo = model.streetNo;
                        data.streetName = model.streetName;
                        data.suburb = model.suburb;
                        data.state = model.state;
                        data.countryId = model.countryId;
                        //data.tbl_Countries.countryName = model.tbl_Countries.countryName;
                        data.company = model.company;
                        db.SaveChanges();
                        return RedirectToAction("Read");
                    }

                    else
                    {
                        return View();
                    }
                    var countryList = db.tbl_Countries.ToList();
                    ViewBag.CountryList = new SelectList(countryList, "countryId", "countryName");

                    return View(data);
                }
                TempData["Msg"] = "Contact was updated successfully.";
                return RedirectToAction("Read");
            }
            catch(Exception e )
            {
                TempData["Msg"] = "Contact was not updated.";
                return RedirectToAction("Edit", new { ContactNo = model.contactID});
            }
            }
    
         public ActionResult Details(int ContactNo)
        {
            using (var db = new CrudAppDbContext())
            {
                // accessing pertcular record for matching ID,choosen from  
                var data = db.tbl_Contacts.Where(x => x.contactID == ContactNo).SingleOrDefault();
                var countryList = db.tbl_Countries.ToList();
                ViewBag.CountryList = new SelectList(countryList, "countryId", "countryName");

                return View(data);
            }

        }

        public ActionResult Delete(int ContactNo)
        {
            using (var db = new CrudAppDbContext())
            {
                // accessing pertcular record for matching ID,choosen from  
                var data = db.tbl_Contacts.Where(x => x.contactID == ContactNo).SingleOrDefault();
                var countryList = db.tbl_Countries.ToList();
                ViewBag.CountryList = new SelectList(countryList, "countryId", "countryName");

                return View(data);
            }

        }
        [HttpPost]
        public ActionResult Delete(int ContactNo, tbl_Contacts model)
        {
            using (var db = new CrudAppDbContext())
            {
                // accessing pertcular record for matching ID,choosen from  
                var data = db.tbl_Contacts.Where(x => x.contactID == ContactNo).SingleOrDefault();

                if (data != null)
                {
                    db.tbl_Contacts.Remove(data);
                    db.SaveChanges();
                    return RedirectToAction("Read");
                }
                else
                {
                    return View();
                   
                }
            }
                
            }

        }
    }
