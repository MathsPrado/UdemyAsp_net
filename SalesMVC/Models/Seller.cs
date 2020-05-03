using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;

namespace SalesMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime BaseDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime baseDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseDate = baseDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addSales(SalesRecord sr) 
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSalles(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amout);
        }
    }
}
