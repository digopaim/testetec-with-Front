using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteTec.Domain.Entities
{
    public class Rick
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Dimensao")]
        public int IdDimensao { get; set; }
        [ForeignKey("Morty")]
        public int IdMorty { get; set; }
        public Morty Morty { get; set; }

        public Dimensao Dimensao { get; set; }
    }
}
