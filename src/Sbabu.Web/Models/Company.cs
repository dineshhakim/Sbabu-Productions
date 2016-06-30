using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sbabu.Web.Models
{
    [Table("Company")]
    public class Company : IEntity
    {
        public int Id { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(100)]
        public string Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(10)]
        public string ZipCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string State { get; set; }
        [StringLength(50)]
        public string EmaildId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string ContactNo { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string BusinessHours { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string WebsiteLink { get; set; }


        public List<SocialNetwork> SocialNetworks { get; set; }
    }
}
