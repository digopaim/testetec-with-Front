using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteTec.Domain.Entities
{
    public class Dimensao
    {
        [Key]
        public int Id { get; set; }
        public string NomeDimensao { get; set; }
    }
}
