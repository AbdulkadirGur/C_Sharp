using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.add();
            database.Delete();
            Database database2 = new SqlServer();
            database2.add();
            database2.Delete();

            Console.ReadLine(); 
        }
       
    }

    
    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("Added by default ");

        }
        public abstract void Delete();

    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted  by  Sql ");
        }
    }

    class OracleServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted  by  Oracle ");

        }
    }
}


