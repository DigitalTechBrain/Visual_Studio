using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using MVCDemo.Models;
using static MVCDemo.Models.ASPNET_MVC_ChartsDemo;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ASPNET_MVC_ChartsDemo.DataPoint> dataPoints = new List<DataPoint>();

            dataPoints.Add(new DataPoint(1496255400000, 2500));
            dataPoints.Add(new DataPoint(1496341800000, 2790));
            dataPoints.Add(new DataPoint(1496428200000, 3380));
            dataPoints.Add(new DataPoint(1496514600000, 4940));
            dataPoints.Add(new DataPoint(1496601000000, 4020));
            dataPoints.Add(new DataPoint(1496687400000, 3390));
            dataPoints.Add(new DataPoint(1496773800000, 4200));
            dataPoints.Add(new DataPoint(1496860200000, 3150));
            dataPoints.Add(new DataPoint(1496946600000, 3230));
            dataPoints.Add(new DataPoint(1497033000000, 4200));
            dataPoints.Add(new DataPoint(1497119400000, 5210));
            dataPoints.Add(new DataPoint(1497205800000, 4940));
            dataPoints.Add(new DataPoint(1497292200000, 3500));
            dataPoints.Add(new DataPoint(1497378600000, 3790));
            dataPoints.Add(new DataPoint(1497465000000, 3230));
            dataPoints.Add(new DataPoint(1497551400000, 2900));
            dataPoints.Add(new DataPoint(1497637800000, 3080));
            dataPoints.Add(new DataPoint(1497724200000, 3370));
            dataPoints.Add(new DataPoint(1497810600000, 2880));
            dataPoints.Add(new DataPoint(1497897000000, 3170));
            dataPoints.Add(new DataPoint(1497983400000, 3280));
            dataPoints.Add(new DataPoint(1498069800000, 4070));
            dataPoints.Add(new DataPoint(1498156200000, 5280));
            dataPoints.Add(new DataPoint(1498242600000, 4970));
            dataPoints.Add(new DataPoint(1498329000000, 2560));
            dataPoints.Add(new DataPoint(1498415400000, 2790));
            dataPoints.Add(new DataPoint(1498501800000, 3800));
            dataPoints.Add(new DataPoint(1498588200000, 4400));
            dataPoints.Add(new DataPoint(1498674600000, 4020));
            dataPoints.Add(new DataPoint(1498761000000, 3900));

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Career()
        {
            ViewBag.Message = "career Page.";

            return View();
        }

        [HttpPost]
        public ActionResult UploadFiles()
        {
            // Checking no of files injected in Request object  
            if (Request.Files.Count > 0)
            {
                try
                {
                    //  Get all files from Request object  
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/";  
                        string filename = Path.GetFileName(Request.Files[i].FileName);  

                        HttpPostedFileBase file = files[i];
                        string fname;

                        // Checking for Internet Explorer  
                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNETEXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\' });
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                        }

                        // Get the complete folder path and store the file inside it.  
                        fname = Path.Combine(Server.MapPath("~/Uploads/"), fname);
                        file.SaveAs(fname);
                    }
                    // Returns message that successfully uploaded  
                    return Json("File Uploaded Successfully!");
                }
                catch (Exception ex)
                {
                    return Json("Error occurred. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selected.");
            }
        }
    }
}