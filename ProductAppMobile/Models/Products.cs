using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppMobile.Models
{
    public class Products
    {
        public ObservableCollection<Product> products {  get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }
}
