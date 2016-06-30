using Microsoft.AspNet.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sbabu.Web.ViewModels
{
    public class PortfolioViewModel
    {

        [Display(Name = "Name")]
        public string PortfolioName { get; set; }
        [Display(Name = "Description")]
        public string PortfolioDescription { get; set; }
        [Display(Name = "Type")]
        public int PortfolioType { get; set; }

        public string Url { get; set; }

        [FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile Image { get; set; }

    }
}
