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

        public int AddData(BookingsViewModels viewModel)
        {
            this.db.AccountBook.Add(new AccountBook()
            {
                Id = Guid.NewGuid(),
                Categoryyy = Convert.ToInt32(viewModel.BookType),
                Amounttt = viewModel.BookAmount,
                Dateee = viewModel.BookDate,
                Remarkkk = viewModel.BookMemo
            });

            return this.db.SaveChanges();
        }
        
        public List<BookingsViewModels> AccountBookList()
        {
            List<BookingsViewModels> LastDetail = new List<BookingsViewModels>();

            foreach(var item in db.AccountBook.OrderBy(d=>d.Id).ToList())
            {
                BookingsViewModels GetAccountBook = new BookingsViewModels();

                GetAccountBook.ID = item.Id;
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