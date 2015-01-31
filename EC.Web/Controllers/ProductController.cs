using EC.BLL;
using EC.Context;
using EC.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EC.Web.Controllers
{
    public class ProductController : Controller
    {
        IProductManager objIProdMgr = new ProductManager();
        string pFolderDir = "~/Images/Products";
        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(objIProdMgr.GetAllProducts());
        }
        public ActionResult CategoryWiseProducts(int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View(objIProdMgr.GetAllProducts().Where(p=>p.CategoryId == categoryId));
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        private List<SelectListItem> BindVendors()
        {
            IVendorManager objIVendorManager = new VendorManager();
            var objVendors = objIVendorManager.GetAllVendors().ToList();
            List<SelectListItem> items = new List<SelectListItem>();
            SelectListItem obj = new SelectListItem();
            obj.Text = "Choose.....";
            obj.Value = "0";
            items.Add(obj);

            foreach (var v in objVendors)
            {
                obj = new SelectListItem();
                obj.Text = v.Name;
                obj.Value = v.Id.ToString();
                items.Add(obj);
            }
            return items;
        }

        //
        // GET: /Product/Create

        [Authorize]
        public ActionResult CreateCategorywiseProduct(int categoryId)
        {                        
            ViewBag.Vendors = BindVendors();
            ViewBag.CategoryId = categoryId;
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            ViewBag.Vendors = BindVendors();
            ViewBag.CategoryId = "";

            return View();
        }

        //
        // POST: /Product/Create

        [Authorize]
        [HttpPost]
        public ActionResult Create(Product Product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    #region upload files
                    if (!string.IsNullOrEmpty(Product.ImagePaths))
                    {
                        string[] strPicArr = Product.ImagePaths.Split(';');
                        string directoryPath = Server.MapPath(pFolderDir);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        for (int i = 0; i < strPicArr.Length - 1; i++)
                        {
                            string uploadedFilePath = string.Format("{0}{1}", directoryPath, strPicArr[i]);

                            uploadedFilePath = directoryPath + @"\" + Guid.NewGuid().ToString() + "--" + strPicArr[i];

                            Request.SaveAs(uploadedFilePath, false);
                        }
                    }
                    
                    
                    #endregion
                    
                    objIProdMgr.AddProduct(Product);
                    return RedirectToAction("Index");
                }
            }
            catch(Exception ex)
            {
               ViewBag.Message = ex.Message;
            }
            finally {  }
            ViewBag.Vendors = BindVendors();

            ViewBag.CategoryId = Product.CategoryId;
                
            return View(Product);
        }

        //
        // GET: /Product/Edit/5

        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Product/Edit/5

        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Product/Delete/5

        [Authorize]
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Product/Delete/5

        [Authorize]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public JsonResult UploadImages(HttpPostedFileBase file)
        {
            string strImages = string.Empty;


            return Json(new
            {
                strImages=strImages
            });
        }

        //[AcceptVerbs(HttpVerbs.Post)]
        //[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        //public JsonResult UploadSizeReducedFiles()
        //{
        //    string fileName = null;
        //    string uploadedFilePath = null;

        //    try
        //    {
        //        fileName = Request.Headers["X-File-Name"];

        //        string directoryPath = Server.MapPath("~/Uploads/");

        //        if (!Directory.Exists(directoryPath))
        //        {
        //            Directory.CreateDirectory(directoryPath);
        //        }

        //        var stream = new StreamReader(Request.InputStream);
        //        string image = stream.ReadToEnd();

        //        image = image.Substring("image=data:image/jpeg;base64,".Length);
        //        byte[] buffer = Convert.FromBase64String(image);

        //        uploadedFilePath = string.Format("{0}{1}", directoryPath, fileName);

        //        System.IO.File.WriteAllBytes(uploadedFilePath, buffer);

        //        return Json(fileName + " completed", JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception e)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(fileName + " fail", JsonRequestBehavior.AllowGet);
        //    }
        //}

        //[AcceptVerbs(HttpVerbs.Post)]
        //[OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        //public JsonResult UploadFiles()
        //{
        //    string fileName = null;
        //    string uploadedFilePath = null;

        //    try
        //    {
        //        var len = Request.InputStream.Length;

        //        fileName = Request.Headers["X-File-Name"];

        //        string directoryPath = Server.MapPath(pFolderDir);

        //        if (!Directory.Exists(directoryPath))
        //        {
        //            Directory.CreateDirectory(directoryPath);
        //        }

        //        uploadedFilePath = string.Format("{0}{1}", directoryPath, fileName);

        //        uploadedFilePath = directoryPath +@"\"+ Guid.NewGuid().ToString() + fileName;

        //        Request.SaveAs(uploadedFilePath, false);

        //        return Json(fileName + " completed", JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception e)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(fileName + " fail", JsonRequestBehavior.AllowGet);
        //    }
        //}
        [AcceptVerbs(HttpVerbs.Post)]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
        public JsonResult UploadFiles()
        {
            string fileName = null;
            //string uploadedFilePath = null;

            try
            {
                var len = Request.InputStream.Length;

                fileName = Request.Headers["X-File-Name"];

                //string directoryPath = Server.MapPath(pFolderDir);

                //if (!Directory.Exists(directoryPath))
                //{
                //    Directory.CreateDirectory(directoryPath);
                //}

                //uploadedFilePath = string.Format("{0}{1}", directoryPath, fileName);

                //uploadedFilePath = directoryPath + @"\" + Guid.NewGuid().ToString() + fileName;

                //Request.SaveAs(uploadedFilePath, false);

                return Json(fileName + " completed", JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Response.StatusCode = 500;
                return Json(fileName + " fail", JsonRequestBehavior.AllowGet);
            }
        }
    }
}
