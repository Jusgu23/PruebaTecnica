using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class cliente
    {
        public int Id { get; set; }
        public int Identification { get; set; }
        public string FirstName { get; set; }
        public string SecondtName { get; set; }
        public string FirstSurname { get; set; }
        public string SecondtSurname { get; set; }
        public string Addres { get; set; }
        public int phone { get; set; }
        public int IdOrder { get; set; }
    }
    public class InventoryProduct
    {
        public int Id { get; set; }
        public int CodeProduct { get; set; }
        public string NomeProduct { get; set; }
        public Boolean State { get; set; }
        public decimal ValueUnit { get; set; }
        public int QuantityStock { get; set; }
    }
    public class ServiceOrder
    {
        public int Id { get; set; }
        public int IdentificationClient { get; set; }
        public int CodeProduct { get; set; }
        public DateTime DateRegister { get; set; }
        public int Estado { get; set; }
        public string DeliveryAddress { get; set; }
        public int Priority { get; set; }
        public decimal ValueParcial { get; set; }
        public decimal ValueTotalOrder { get; set; }
        public int cantidadPedido { get; set; }
    }
}