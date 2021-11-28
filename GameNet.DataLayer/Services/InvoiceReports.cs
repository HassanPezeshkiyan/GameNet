using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Services
{
    public class InvoiceReports
    {
        private readonly GameNetEntities db;

        public InvoiceReports(GameNetEntities context)
        {
            db = context;
        }

        public /*List<invoice_View_creationDate>*/IQueryable<invoice_View_creationDate> GetAll()
        {
            var result = db.invoice_View_creationDate.OrderByDescending(n => n.NCreationDate);
            return result;
        }

        //public List<invoice_View_creationDate> GetAllByFilter(string startDate = null, string endDate = null)
        //{
        //    var reports = db.invoice_View_creationDate
        //        .OrderByDescending(n => n.NCreationDate)
        //        .Where(n => n.NCreationDate >= startDate)
        //    return reports;
        //}
    }
}
