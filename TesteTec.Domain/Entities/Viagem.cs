using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteTec.Domain.Entities
{
    public class Viagem
    {   
        [Key]
        public  int Id { get; set; }
      
        [ForeignKey("Dimensao")]
        public int IdDimensao { get; set; }
        public Dimensao Dimensao { get; set; }
    }
}
