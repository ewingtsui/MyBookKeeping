using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBookKeeping.Models.ViewModels
{
    public class BookingsViewModels
    {
        public Guid ID { get; set; }
        public string BookType { get; set; }
        public DateTime BookDate { get; set; }
        public Decimal BookAmount { get; set; }
        public string BookMemo { get; set; }
    }
}