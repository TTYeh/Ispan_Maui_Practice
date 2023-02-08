using Ispan_XAMLUI_MauiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan_XAMLUI_MauiApp
{
    internal class CustomerViewModels
    {
        CCustomer currnetCustomer = new CCustomer();
        List<CCustomer> Mycustomers = new List<CCustomer>();
        private int currentId { get; set; }

        public CustomerViewModels()
        {
            this.currentId = 0;
            InitData();
        }
        public void InitData()
        {
            // 清除快取資料
            ClaerCache();
            // 載入範例資料
            #region data
            Mycustomers.Add(new CCustomer()
            {
                id = 1,
                name = "John",
                phone = "12345678",
                address = "Taipei",
                email = "ass@bss.com"
            });
            Mycustomers.Add(new CCustomer()
            {
                id = 2,
                name = "Mike",
                phone = "246810",
                address = "Park",
                email = "fff@bss.com"
            });
            Mycustomers.Add(new CCustomer()
            {
                id = 3,
                name = "Japan",
                phone = "1357911",
                address = "Ispan",
                email = "ddd@bss.com"
            });
            #endregion
        }
        private static void ClaerCache()
        {
            App app = Application.Current as App;
            app.Queryword = "";
            app.selectIndex = -1;
        }
        public void GetFirst()
        {
            this.currentId = 0;
        }
        public void GetPrevious()
        {
            this.currentId = currentId - 1 >= 0 ? currentId -- : currentId;
        }
        public void GetNext()
        {
            this.currentId = currentId + 1 < Mycustomers.Count - 1 ? currentId ++ : currentId;
        }
        public void GetLast()
        {
            this.currentId = Mycustomers.Count - 1;
        }
        public CCustomer Current()
        {
            return Mycustomers[currentId];
        }
        public CCustomer current()
        {
            return Mycustomers[currentId];
        }
    }
}
