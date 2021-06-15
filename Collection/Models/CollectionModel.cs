using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Collection.Models
{
    public class CollectionModel
    {
        public int Id { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string  Description { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string WithThisActor { get; set; }
        [Required]
        public decimal Price { get; set; }

        public CollectionModel()
        {
            Id = 0;
            Category = "Patike";
            Description = "AirForce tn";
            Model = "NIKE";
            WithThisActor = "NN";
            
        }

        public CollectionModel(int id,string category, string description, string model,string withthisactor, decimal price)
        {
            Id = id;
            Category = category;
            Description = description;
            Model = model;
            WithThisActor = withthisactor;
            Price = price;
        }
    }
}