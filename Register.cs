using System;
using System.Globalization;

namespace DesafioOakTecnologia
{
    internal class Register
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Available { get; set; }

        public Register(string name, string description, double price, bool available)
        {
            Name = name;
            Description = description;
            Price = price;
            Available = available;
        }

        override public string ToString()
        {
            return $"Nome: {Name}\nDescrição: {Description}\nValor: {Price.ToString("F2", CultureInfo.InvariantCulture)}\nDisponível: {Available}";
        }
    }
}
