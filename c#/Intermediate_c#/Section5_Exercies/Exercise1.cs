using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intermediate_Exercies
{
    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout;

        public void dbConnection(string connection)
        {
            if (connection == "")
            {
                Console.WriteLine("Invalid connection string");
            }
        }

        public abstract void openConnection();
        public abstract void closeConnection();
    }

    public class SqlConnection : DbConnection
    {
        public void dbConnection(string connection)
        {
            if (connection == "")
            {
                Console.WriteLine("Invalid connection string");
            }
            else
            {
                openConnection();
            }
        }

        public override void openConnection()
        {
            Console.WriteLine("Open SQL Connection");
        }

        public override void closeConnection()
        {
            Console.WriteLine("Close SQL Connection");
        }
    }

    public class OracleConnection : DbConnection
    {
        public void dbConnection(string connection)
        {
            if (connection == "")
            {
                Console.WriteLine("Invalid connection string");
            }
            else
            {
                openConnection();
            }
        }

        public override void openConnection()
        {
            Console.WriteLine("Open Oracle connection");
        }

        public override void closeConnection()
        {
            Console.WriteLine("Close Oracle connection");
        }
    }

    public class DbCommand
    {
        private DbConnection theDbUrl;
        public DbConnection db
        {
            get
            {
                return theDbUrl;
            }
            set
            {
                theDbUrl = value;
            }
        }
        public void DbCommand(DbConnection db)
       {
            if(DbConnection == null)
            {
                Console.WriteLine("A db object must be provided");
                return 1;
            }               
       }

        public void checkDb(DbConnection db)
        {
            Console.WriteLine("Checking Db security for: " + db);
        }
       public void Execute()
        {
            db.openConnection(db);
            checkDb(db);
            db.closeConnection(db);
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {

            var SQLdb = new SqlConnection();
            var dbCommand = new DbCommand(SQLdb);

            dbCommand.dbConnection("Valid DB URL");
            dbCommand.Execute();
            dbCommand.closeConnection();

            var Oracledb = new OracleConnection();
            Oracledb.dbConnection("");


        }
    }
}
