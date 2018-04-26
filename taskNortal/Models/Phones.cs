using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace taskNortal.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Spec Specs { get; set; }
        public Image Image { get; set; }
    }
    public class Spec
    {
        public string Manufacturer { get; set; }
        public int Storage { get; set; }
        public string Os { get; set; }
        public int Camera { get; set; }
    }
    public class Image
    {
        public string Small { get; set; }
        public string Large { get; set; }
    }
}