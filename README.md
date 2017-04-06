ASP.NET MVC 記帳本

demo網址 : http://accountingbook.azurewebsites.net/AccountingBook

Version 1 (done)
•必須使用Layout
•下方列表部分建議分開，不要寫在同一頁並且要有假資料（禁止寫死在HTML）
•上方輸入的部分可以只是切版的結果不用實現功能
•前方數字是流水號，不是DB的值


Version 2 (done)

請將記帳本呈現資料的部分改為真DB 
•可使用EF , ADO.NET
•範例資料庫請使用HomeWorkDB 內的資料
•不可改變第一天設計的ViewModel

建議練習 
•實做Service 層

額外挑戰 
•UnitOfWork
•Repository

個人挑戰 
•IOC & DI ( 使用 Unity容器 )
•Unit of Work 生命週期調整


Version 3 

初階版 
•將記帳本的寫入功能完成。
•必須真的寫進資料庫
•所有欄位必填 i.「金額」只能輸入正整數
ii.「日期」不得大於今天
iii.「備註」最多輸入100個字元（備註為 TextArea）
iv.列表加入顏色變換
v.類型的「支出」字樣顯現為紅色

•類型的「收入」字樣顯現為藍色

進階版 
•將記帳本的寫入功能改為 AJAX。

你將會遇到以下問題
•如何片段更新下方 List 


Version 4 

初階版 
•日期欄位加入選擇器 
•金額必須用選的 
•實做 RSS
•增加管理專用的 Area  ◦管理員可以編輯所有的歷史資料 
◦非管理員進入會「跳回首頁」

•登入才可以寫入資料 

進階版 
•如果你已經將寫入改為 AJAX 請嘗試維持 AJAX實做這塊。
