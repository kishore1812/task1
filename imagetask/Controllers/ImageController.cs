using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace imagetask.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult showimg()
        {
            string imgpath = Server.MapPath("~/content/Image/images-02.jpeg");
            byte[] bytedata = System.IO.File.ReadAllBytes(imgpath);
            string imgBase64Data = Convert.ToBase64String(bytedata);
            string imgDataURL = string.Format("data:image/jpg;base64,{0}", imgBase64Data);
            ViewBag.ImageData = imgDataURL;
            return View();
        
            
        }
    }
}