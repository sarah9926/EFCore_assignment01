using EFCore_assignment01.Contexts;

namespace EFCore_assignment01
{
    internal class Program
    {
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            if (context.Database.CanConnect())
            {
                Console.WriteLine("Database created successfully");
            }
            else
            {
                Console.WriteLine("Database connection failed");
            }

            //I added the migration in the package manager console and then updated the database to create the database and tables
            //I verfied that the db was created by checking sql server management studio and I also checked the database connection in the code and it was successful
        }
    }
}
