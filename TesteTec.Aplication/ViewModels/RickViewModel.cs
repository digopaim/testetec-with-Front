using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTec.Aplication.ViewModels
{
    public class RickViewModel
    {
        public int Id { get; set; }
        public DimensaoViewModel Dimensao { get; set; }
        public MortyViewModel Morty { get; set; }
    }
}
