using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;


namespace Admin.BLL.Services
{

    public class BarcodeService
    {
        public void Get(string barcode)
        {
            var url = "http://www.barkodid.com/(barcode)";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            //var list = doc.GetElementbyId("currencies").Element("tbody").ChildNodes.Where(x => x.Name == "tr").ToList();
        }
    }
}
