using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudUsingXamarin.Models
{
    public class Company
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
