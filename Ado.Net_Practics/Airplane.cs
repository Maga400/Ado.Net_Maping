using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net_Practics
{
    public class Airplane
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Airplane() 
        {
            
        }

        public Airplane(int ıd, string marka, string model, double price)
        {
            Id = ıd;
            Marka = marka;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nMarka: {Marka}\nModel: {Model}\nPrice: {Price}\n";
        }

    }
}
