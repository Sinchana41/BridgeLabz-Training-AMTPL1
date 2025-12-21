using System;
using System.Data.SqlClient;

class Program
{
    
   const string connectionString = "Data Source=.;Initial Catalog=Employees_DB;Integrated Security=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n --Employee Menu--");
            Console.WriteLine("1. Insert employee");
            Console.WriteLine("2. Display all employees");
            Console.WriteLine("3. Update employee salary by ID");
            Console.WriteLine("4. Delete employee by ID");
            Console.WriteLine("5. Exit");
            Console.Write("Choose option (1-5): ");

            string opt = Console.ReadLine();
            if (opt == "1")
            {
                InsertEmployee();
            }
            else if (opt == "2")
            {
                DisplayAll();
            }
            else if (opt == "3")
            {
                UpdateSalaryById();
            }
            else if (opt == "4")
            {
                DeleteById();
            }
            else if (opt == "5") break;
            else Console.WriteLine("Invalid option. Try again.");
        }

        Console.WriteLine("Goodbye.");
    }

    static void InsertEmployee()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Age: ");
        if (!int.TryParse(Console.ReadLine(), out int age))
        {
            Console.WriteLine("Invalid age.");
            return;
        }

        Console.Write("Dept: ");
        string dept = Console.ReadLine();

        Console.Write("Salary: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
        {
            Console.WriteLine("Invalid salary.");
            return;
        }

        const string sql = @"
            INSERT INTO Employee ([Name], Age, Dept, Salary)
            VALUES (@name, @age, @dept, @salary);
        ";

        try
        {
            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@dept", dept);
            cmd.Parameters.AddWithValue("@salary", salary);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Inserted successfully." : "Insert failed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void DisplayAll()
    {
        const string sql = "SELECT EmployeeID, [Name], Age, Dept, Salary FROM Employee ORDER BY EmployeeID;";

        try
        {
            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, con);
            con.Open();
            using var dr = cmd.ExecuteReader();

            Console.WriteLine("\nID\tName\t\tAge\tDept\tSalary");
            Console.WriteLine("-----------------------------------------------------");
            while (dr.Read())
            {
                int id = dr.GetInt32(dr.GetOrdinal("EmployeeID"));
                string name = dr.GetString(dr.GetOrdinal("Name"));
                int age = dr.GetInt32(dr.GetOrdinal("Age"));
                string dept = dr.GetString(dr.GetOrdinal("Dept"));
                decimal salary = dr.IsDBNull(dr.GetOrdinal("Salary")) ? 0 : dr.GetDecimal(dr.GetOrdinal("Salary"));

                Console.WriteLine($"{id}\t{name}\t\t{age}\t{dept}\t{salary:C}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void UpdateSalaryById()
    {
        Console.Write("Enter EmployeeID to update: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        Console.Write("Enter new Salary: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal newSalary))
        {
            Console.WriteLine("Invalid salary.");
            return;
        }

        const string sql = "UPDATE Employee SET Salary = @salary WHERE EmployeeID = @id;";

        try
        {
            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@salary", newSalary);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Updated successfully." : "No employee found with that ID.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void DeleteById()
    {
        Console.Write("Enter EmployeeID to delete: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        const string sql = "DELETE FROM Employee WHERE EmployeeID = @id;";

        try
        {
            using var con = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine(rows > 0 ? "Deleted successfully." : "No employee found with that ID.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
