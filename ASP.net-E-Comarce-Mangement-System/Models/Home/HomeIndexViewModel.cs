using ASP.net_E_Comarce_Mangement_System.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ASP.net_E_Comarce_Mangement_System.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        dbMyOnlineShoppingEntities context = new dbMyOnlineShoppingEntities();

        public IEnumerable<Tbl_Product> ListOfProducts { get; set; }

        public HomeIndexViewModel CreateModel(string search)
        {

            SqlParameter[] param = new SqlParameter[] {
                   new SqlParameter("@search",search??(object)DBNull.Value)
                   };
            IEnumerable<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search ", param).ToList();
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
    }
}