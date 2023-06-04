using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace QLKS.DTO
{
    public class TotalPrices
    {
        private int soPhong;
        private decimal price;

        public int SoPhong { get => soPhong; set => soPhong = value; }
        public decimal Price { get => price; set => price = value; }
        public TotalPrices() { }   
    }
}
