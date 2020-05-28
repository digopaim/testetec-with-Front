using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TesteTec.Domain.Entities
{
    public class Morty
    {
        [Key]
        public int Id { get; set; }
 
    }
}
