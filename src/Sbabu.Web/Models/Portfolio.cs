using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sbabu.Web.Models
{
    public class Portfolio : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string PortfolioName { get; set; }
        [Display(Name = "Description")]
        public string PortfolioDescription { get; set; }
        [Display(Name = "Type")]
        public int PortfolioType { get; set; }

        public string Url { get; set; }
        
    }
}
