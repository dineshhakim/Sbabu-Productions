using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbabu.Web.Models
{
    public class Portfolio
    {
        public int Id { get; set; }

        public string PortfolioName { get; set; }

        public string PortfolioDescription { get; set; }

        public int PortfolioType { get; set; }

        public string Url { get; set; }
    }
}
