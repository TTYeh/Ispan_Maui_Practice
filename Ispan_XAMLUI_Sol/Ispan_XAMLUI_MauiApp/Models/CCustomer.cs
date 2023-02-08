using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_XAMLUI_MauiApp.Models
{
    public class CCustomer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {phone} {address} {email}";
        }
    }
}
