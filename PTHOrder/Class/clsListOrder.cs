using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PTHOrder.Class
{
    class clsListOrder
    {
        //khai báo biến các Feild của table
        public string OrderCode { get; set; }
        public DateTime DateSuggest { get; set; }
        public string Followers { get; set; }
        public string SupplierCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string PlaceOfDelivery { get; set; }
        public string PaymentConditions { get; set; }
        public int VAT { get; set; }
        //Store lấy dữ liệu table
        public DataTable tbOrder_GetList()
        {
            string procname = "tbOrder_GetList";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            return db.ExecuteDataTable(procname);
        }
        //Store edit dữ liệu
        public DataTable tbOrder_Get()
        {
            string procname = "tbOrder_Get";
            DbAccess db = new DbAccess();
            db.CreateNewSqlCommand();
            db.AddParameter("@OrderCode", OrderCode);
            return db.ExecuteDataTable(procname);
        }
        //store chèn dữ liệu vào table
        public bool Insert()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);
                db.AddParameter("@DateSuggest", DateSuggest);
                db.AddParameter("@Followers", Followers);
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@DeliveryDate", DeliveryDate);
                db.AddParameter("@PlaceOfDelivery", PlaceOfDelivery);
                db.AddParameter("@PaymentConditions", PaymentConditions);
                db.AddParameter("@VAT", VAT);
                db.ExecuteNonQueryWithTransaction("tbOrder_Insert");//thực thi store chèn
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }
        //Store cập nhật dữ liệu table
        public bool Update()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();

            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);
                db.AddParameter("@DateSuggest", DateSuggest);
                db.AddParameter("@Followers", Followers);
                db.AddParameter("@SupplierCode", SupplierCode);
                db.AddParameter("@DeliveryDate", DeliveryDate);
                db.AddParameter("@PlaceOfDelivery", PlaceOfDelivery);
                db.AddParameter("@PaymentConditions", PaymentConditions);
                db.AddParameter("@VAT", VAT);
                db.ExecuteNonQueryWithTransaction("tbOrder_Update");//thực thi store cập nhật dữ liệu
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }
        //Store xóa dữ liệu table
        public bool Delete()
        {
            DbAccess db = new DbAccess();
            db.BeginTransaction();
            try
            {
                db.CreateNewSqlCommand();
                db.AddParameter("@OrderCode", OrderCode);// xóa dựa vào trường khóa 
                db.ExecuteNonQueryWithTransaction("tbOrder_Delete");//thực thi store xóa dữ liệu
                db.CommitTransaction();
                return true;
            }
            catch
            {
                db.RollbackTransaction();
                return false;
            }
        }

    }


}
