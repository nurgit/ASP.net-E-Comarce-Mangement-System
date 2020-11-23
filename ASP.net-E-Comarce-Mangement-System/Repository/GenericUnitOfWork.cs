using ASP.net_E_Comarce_Mangement_System.Models;
using ASP.net_E_Comarce_Mangement_System.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.net_E_Comarce_Mangement_System.Repository
{
    public class GenericUnitOfWork :IDisoisable
    {
        private dbMyOnlineShoppingEntities DBEntity = new dbMyOnlineShoppingEntities();
        public IRepository<Tbl_EntityType> GetRepositoryInstance<Tbl_EntityType>() where Tbl_EntityType : class
        {
            return new GenericRepository<Tbl_EntityType>(DBEntity);
        }

        public void SaveChanges()// SaveChanges() this method is responsible to DBEntity save 
        {
            DBEntity.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)//Dispose() method is responsible  to DBEntity Dispose. 
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    DBEntity.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
    }
}