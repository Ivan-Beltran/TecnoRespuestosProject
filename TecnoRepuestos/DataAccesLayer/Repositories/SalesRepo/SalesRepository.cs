using DataAccesLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories.SalesRepo
{
    public class SalesRepository
    {
        private SqlConnect _dbConnection;

        public SalesRepository(SqlConnect _conecction)
        {
            _dbConnection = _conecction;
        }

        
    }
}
