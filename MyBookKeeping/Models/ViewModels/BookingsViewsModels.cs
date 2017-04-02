using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using MyBookKeeping.Filter;

namespace MyBookKeeping.Models.ViewModels
{
    public class BookingsViewModels
    {
        public Guid ID { get; set; }

        [Display(Name = "類別")]
        [Required]
        [Range(0,1)]
        public string BookType { get; set; }

        [Display(Name = "金額")]
        [Required]
        [Range(1, int.MaxValue)]
        public int BookAmount { get; set; } 

        [Display(Name = "日期")]
        [Required]
        [RemotePlus("CheckToday", "Validate", "", ErrorMessage = "日期不可大於今日")]   //改成這種寫法可以避免上面的問題
        public DateTime BookDate { get; set; }
        
        [Display(Name = "備註")]
        [Required]
        [MaxLength(100)]
        public string BookMemo { get; set; }
    }
}