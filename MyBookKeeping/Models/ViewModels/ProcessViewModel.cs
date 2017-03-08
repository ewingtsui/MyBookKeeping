using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyBookKeeping.Models;

namespace MyBookKeeping.Models.ViewModels
{
    public class ProcessViewModel
    {
        public List<BookingsModels> InitData()
        {
            List<BookingsModels> ListData = new List<BookingsModels>()
            {
                new BookingsModels() {SeqNo=1,BookType="支出",BookDate=DateTime.Parse("2017/01/01"),BookAmount=300},
                new BookingsModels() {SeqNo=2,BookType="收入",BookDate=DateTime.Parse("2017/01/02"),BookAmount=1600},
                new BookingsModels() {SeqNo=3,BookType="支出",BookDate=DateTime.Parse("2017/01/03"),BookAmount=800}
            };

            return ListData;
        }
    }
}