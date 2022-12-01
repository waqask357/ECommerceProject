using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceProject.Web.Controllers
{
    public class SharedController : Controller
    {
        public JsonResult UploadImage()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;

            try
            {
                var file = Request.Files[0];

                var randomName = Guid.NewGuid();
                var imageExtension = Path.GetExtension(file.FileName);



                var filename = randomName + imageExtension;


                var path = Path.Combine(Server.MapPath("~/Content/WebsiteImages"), filename);
                file.SaveAs(path);
                //result.Data = new { Success = true, ImageURL = path };

                result.Data = new
                {
                    Success = true,
                    ImageURL = "/Content/WebsiteImages/" + filename
                };


                //var newimage = new image() { name = filename };

                //if (Imageserver.Instance.SaveNewImage(newimage))
                //{
                //    result.Data = new { Success = true, image = filename, File = newimage.Id, ImageURL = string.Format("{0}{1}", Variables.ImageFolderPath, filename) };
                //}
                //else
                //{
                //    result.Data = new { Success = false, Message = new HttpStatusCodeResult(500) };
                //}

            }
            catch (Exception ex)
            {
                result.Data = new { Success = false, Message = ex.Message };
            }
            return result;
        }
    }
}