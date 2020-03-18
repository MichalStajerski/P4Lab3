using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lab3
{
    class Zajecia
    {

        public int Id { get; set; }
        [Required] //wymagana wartosc do nazwa nie moze byc null - adnotacja 
        [MaxLength(255)]
        [Column("Nazwa przedmiotu")] // pozwala zmienic nazwe kolumny
        public string Nazwa { get; set; }
        public DateTime GodzinaRozpoczecia { get; set; }

    }
}
