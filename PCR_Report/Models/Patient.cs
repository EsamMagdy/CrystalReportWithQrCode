using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCR_Report.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public int Phone { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime ResultDate { get; set; }
        public int Report { get; set; }
        public int HESNNo { get; set; }
        public int TestDescriptionId { get; set; }
        public TestDescription TestDescription { get; set; }
        //public ResultEnum Result { get; set; }
        public int Result { get; set; }
        public string LinkForQrCode { get; set; }
        public string MedicalCenter { get; set; }
    }
}