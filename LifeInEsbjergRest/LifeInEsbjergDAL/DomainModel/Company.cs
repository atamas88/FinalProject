using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace LifeInEsbjergDAL.DomainModel
{

    [DataContract(IsReference = true)]
    [Table("Company")]
    public class Company
    {
        [Key]
        [DataMember]
        public int Id { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Address { get; set; }

        [StringLength(50)]
        [DataMember]
        public string WebSite { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Tel { get; set; }

        [StringLength(50)]
        [DataMember]
        public string OpenHours { get; set; }

        [DataMember]
        public double MinPrice { get; set; }

        [DataMember]
        public double MaxPrice { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int NrRate { get; set; }

        [DataMember]
        public double AvgOvr { get; set; }

        [DataMember]
        public int CategoryId { get; set; }


    }
}
