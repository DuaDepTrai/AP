using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250226.test
{
    interface IBook
    {
        string ID { get; }
        string Name { get; set; }
        string AuthorName { get; set; }
        string Subject { get; set; }
        double BuyingPrice { get; set; }
        double SellingPrice { get; set; }

        void ShowDetail();
        void SetDetail(string name, string authorName, string subject, double buyingPrice);
        void SetSellingPrice(double newSellingPrice);
    }
}
