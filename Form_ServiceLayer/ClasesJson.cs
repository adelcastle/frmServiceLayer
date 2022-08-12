using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_ServiceLayer
{
    class ClasesJson
    {

    }


    class Order
    {
        public string CardCode { get; set; }
        public string DocDate { get; set; }
        public string DocDueDate { get; set; }
        public string DocType { get; set; }
   

        public List<DocumentLine> DocumentLines { get; set; }


    }

    class DocumentLine
    {
        public string ItemCode { get; set; }
        public float Quantity { get; set; }
        public string TaxCode { get; set; }
        public float UnitPrice { get; set; }


    }



}
