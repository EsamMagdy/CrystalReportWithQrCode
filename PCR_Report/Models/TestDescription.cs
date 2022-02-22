using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCR_Report.Models
{
    public class TestDescription
    {
        public int Id { get; set; }
        public string SampleAr { get; set; }
        public string SampleEn { get; set; }
        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }
    }
}