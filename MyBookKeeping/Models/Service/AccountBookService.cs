using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyBookKeeping.Models;
using MyBookKeeping.Models.ViewModels;

namespace MyBookKeeping.Models.Service
{
    public class AccountBookService
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        
        public List<BookingsViewModels> AccountBookList()
        {
            List<BookingsViewModels> LastDetail = new List<BookingsViewModels>();

            foreach(var item in db.AccountBook.OrderBy(d=>d.Id).ToList())
            {
                BookingsViewModels GetAccountBook = new BookingsViewModels();

                if (item.Categoryyy == 0)
                {
                    GetAccountBook.BookType = "支出";
                }
                else
                {
                    GetAccountBook.BookType = "收入";
                }

                GetAccountBook.BookAmount = item.Amounttt;
                GetAccountBook.BookDate = item.Dateee;
                GetAccountBook.BookMemo = item.Remarkkk;

                LastDetail.Add(GetAccountBook);
            }

            return LastDetail;
        }
    }
}