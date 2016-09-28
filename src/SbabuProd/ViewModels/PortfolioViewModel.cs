using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

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
