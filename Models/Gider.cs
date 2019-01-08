using FlatAutomation.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAutomation.Models
{
    public enum Giders
    {
        Elektrik,Su,Temizlik,Asansor
    }
    class Gider : ICOMMON
    {
        public DateTime DateTimes { get; set; }
        public decimal Total { get; set; }
        public string Giders { get; set; }

   



    
    }
}
