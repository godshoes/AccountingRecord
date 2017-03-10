using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountRecord.Models.ViewModels
{
    public class RecordViewModel
    {
        
        public int TotalAmount { get; set; }
        public DateTime Date { get; set; }
        public String Type{ get; set; }
        public string Memo { get; set; }
    }


}