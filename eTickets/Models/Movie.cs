using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}
