using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MyBookKeeping.Models.ViewModels
{
    public class BookingsViewModels
    {
        public Guid ID { get; set; }

        [Display(Name = "類別")]
        public string BookType { get; set; }
        
        [Display(Name = "日期")]
        [Required]
        [Remote("Valid", "Accounting", ErrorMessage = "日期不可大於今天")]
        public DateTime BookDate { get; set; }
        
        [Display(Name = "金額")]
        [Required]
        [Range(1, int.MaxValue)]
        public Decimal BookAmount { get; set; }
        
        [Display(Name = "備註")]
        public string BookMemo { get; set; }
    }
}