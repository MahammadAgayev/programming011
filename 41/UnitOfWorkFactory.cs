using _40.Repositeries.Abstract;
using _40.Repositeries.Memory;
using _40.Repositeries.SqlServer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    internal class UnitOfWorkFactory
    {
        public static IUnitOfWork GetUnitOfWork(string type)
        {
            switch (type)
            {
                case "sqlserver":
                    return new SqlUnitOfWork(100, 600, System.Data.IsolationLevel.ReadCommitted);
                case "memory":
                    return new MemoryUnitOfWork();
                default:
                    return new MemoryUnitOfWork();
            }
        }
    }
}
