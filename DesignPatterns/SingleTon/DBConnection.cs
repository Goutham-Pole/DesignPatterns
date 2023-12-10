using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.SingleTon
{
    internal class DBConnection
    {
        static Lazy<DBConnection> connection=new Lazy<DBConnection>(()=>new DBConnection());
        public DBConnection dbConnection { get; }
        private static DBConnection instance;
        private static int count=0;
        private DBConnection()
        {
            count++;
            Console.WriteLine(count+" object");
        }

        public static DBConnection GetConnection()
        {
            return connection.Value;
                /*if (instance is null)
                    instance = new DBConnection();
            return instance;*/
        }
    }
}
