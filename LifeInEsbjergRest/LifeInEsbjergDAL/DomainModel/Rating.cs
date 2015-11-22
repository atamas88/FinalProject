using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
>>>>>>> 9a6fd4de09ce1e143e8c209bdada25be6ed06367
using System.Text;
using System.Threading.Tasks;

namespace LifeInEsbjergDAL.DomainModel
{
<<<<<<< HEAD
    class Rating
    {
=======
    [DataContract(IsReference = true)]
    [Table("Rating")]
    public class Rating
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Quality { get; set; }
        [DataMember]
        public int CustomerService { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public double OverAll { get; set; }
        [DataMember]
        //[ForeignKey("Company_Id")]
        public virtual Company Company { get; set; }
        //public int Company_Id { get; set; }
        //public virtual User user { get; set; }
>>>>>>> 9a6fd4de09ce1e143e8c209bdada25be6ed06367
    }
}
