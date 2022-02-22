using CrystalDecisions.CrystalReports.Engine;
using PCR_Report.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace PCR_Report.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Download_PDF()
        {
            var context = new ApplicationDbContext();

            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/Report"), "Patient_Data.rpt"));
            rd.SetDataSource(context.Patients.Include(s => s.TestDescription).Select(c => new
            {
                Id = c.Id,
                Name = c.PatientName,
                CollectionDate = c.CollectionDate,
                DateOfBirth = c.DateOfBirth,
                HESNNo = c.HESNNo,
                QrCode = c.LinkForQrCode,
                MedicalCenter = c.MedicalCenter,
                Nationality = c.Nationality,
                PhoneNo = c.Phone,
                ReportNo = c.Report,
                Result = c.Result,
                ResultDate = c.ResultDate,
                DescriptionAr = c.TestDescription.DescriptionAr,
                DescriptionEn = c.TestDescription.DescriptionEn,
                SampleAr = c.TestDescription.SampleAr,
                SampleEn = c.TestDescription.SampleEn
            }).ToList());

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();


            rd.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape;
            rd.PrintOptions.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(5, 5, 5, 5));
            rd.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA5;

            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);

            return File(stream, "application/pdf", "CustomerList.pdf");
        }
    }
}