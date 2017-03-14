using AccountRecord.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountRecord.Controllers
{
    public class RecordController : Controller
    {
        // GET: Record
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult DetailList()
        {
            var itemlist = new List<RecordViewModel>
            {
                new RecordViewModel {Type="收入",TotalAmount=1000,Date=new DateTime(2017,3,9),Memo=""},
                new RecordViewModel {Type="支出",TotalAmount=200,Date=new DateTime(2017,5,9),Memo="Test"}
            };
            return View(itemlist);
        }

    }
}