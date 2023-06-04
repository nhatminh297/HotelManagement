using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DTO
{
    public class SelectedServices
    {
        public SelectedServices() { }
        private int soPhong;
        private int idService;
        private string servicesName;
        private string servicesType;
        private decimal prices;
        private int count;
        private decimal totalPrices;

        public string ServicesType { get => servicesType; set => servicesType = value; }
        public decimal Prices { get => prices; set => prices = value; }
        public string ServicesName { get => servicesName; set => servicesName = value; }
        public int SoPhong { get => soPhong; set => soPhong = value; }
        public int Count { get => count; set => count = value; }
        public int IdService { get => idService; set => idService = value; }
        public decimal TotalPrices { get => totalPrices; set => totalPrices = value; }

        public SelectedServices( int soPhong, int idService,string serviceName, string servicesType, decimal prices, int count)
        {   
            SoPhong = soPhong;
            IdService = idService;
            ServicesName = serviceName;
            ServicesType = servicesType;
            Prices = prices;
            Count = count;
            TotalPrices = totalPrices;
        }
    }
}
