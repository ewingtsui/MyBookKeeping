using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MyBookKeeping.Models;
using MyBookKeeping.Models.ViewModels;
using System.Web.Mvc;

namespace MyBookKeeping.Models.Service
{
    public class AccountBookService
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();

        public void AddData([Bind(Include = "Id,Categoryyy,Amounttt,Dateee,Remarkkk")] AccountBook acct)
        {
            db.AccountBook.Add(acct);
        }
        
        public int Save()
        {
            return db.SaveChanges();            
        }

        public List<BookingsViewModels> AccountBookList()
        {
            List<BookingsViewModels> LastDetail = new List<BookingsViewModels>();

            foreach (var item in db.AccountBook.OrderByDescending(d => d.Dateee).Take(10).ToList())
            {
                BookingsViewModels GetAccountBook = new BookingsViewModels();

                GetAccountBook.ID = item.Id;
                GetAccountBook.BookType = item.Categoryyy.ToString();
                GetAccountBook.BookAmount = item.Amounttt;
                GetAccountBook.BookDate = item.Dateee;
                GetAccountBook.BookMemo = item.Remarkkk;

                LastDetail.Add(GetAccountBook);
            }

            return LastDetail;
        }
    }
}