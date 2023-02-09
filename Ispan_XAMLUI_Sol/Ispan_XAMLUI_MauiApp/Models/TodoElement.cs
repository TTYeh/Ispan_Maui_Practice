using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_XAMLUI_MauiApp.Models
{
    public class TodoElement
    {
        public string Item { get; set; }

        public string FinishedDate { get; set; }

        public override string ToString()
        {
            return Item + " " + FinishedDate;
        }
    }
}
