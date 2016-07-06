using Sbabu.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sbabu.Web.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<Portfolio> DJs { get; set; }
        public IEnumerable<Portfolio> Photos { get; set; }
        public IEnumerable<Portfolio> Videos { get; set; }

    }
}
