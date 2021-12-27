using System.Data.SqlClient;

// next steps...
// we'd like to keep all the database-specific implementation details in their own classes
//     and even if its own project
// today we learned what's called the "connected architecture" in ADO.NET for queries
//     tomorrow we'll see "disconnected architecture" for when using less memory is less important than closing the connection quicker
// we'll probably want to have classes to represent the data we read and write with the database.
//    we might even want a separate set of classes for the DB compared to the rest of our code
string connectionString = File.ReadAllText("D:/Study_Documents/Revature/Training/DBConnectionStrings/BooksDB.txt");

Console.Write("Input title: ");
string _title = Console.ReadLine()!;
Console.Write("Input pages: ");
int _pages = int.Parse(Console.ReadLine()!);
AddNewBook(_title, _pages);
ListBooks();

void ListBooks()
{
    // steps of connected architecture
    // 1. open the connection
    using SqlConnection connection = new SqlConnection(connectionString);
    connection.Open();
    // 2. execute the command
    string commandText = "SELECT * FROM Books ORDER BY Title;";
    using SqlCommand command = new SqlCommand(commandText, connection);
    using SqlDataReader reader = command.ExecuteReader();
    // 3. process the results
    while (reader.Read())
    {
        // goes through each row at a time

        // several ways to get the data in the current row (by column index)
        //string title = reader.GetString(0);
        string? title = reader["Title"].ToString();
        string? author = reader["Author"].ToString();
        int pages = reader.GetInt32(2);
        string? thickness = reader["Thickness"].ToString();
        int genreid = reader.GetInt32(4);
        int publisherid = reader.GetInt32(5);
        Console.WriteLine($"\"{title}\"\t{author}\t{pages}\t{thickness}\t{genreid}\t{publisherid}");
    }
    // 4. close the connection
    connection.Close();

    /* 
     * can reopen the same connection and reuse it
     * it't no big deal to not do that and just instantiate a new one though
     * because the sqlClient ADO.NET code maintains a "connection pool"
    */
}

void AddNewBook(string title, int pages)
{
    using SqlConnection connection = new(connectionString);
    connection.Open();
    /* vulnerable to sql injection
     * - a malicious user is able to manipulate his input to create unexpected sql queries
     * Two main mitigations:
     * (1) Never put user input directly into a SQL command. Always use a SqlParameter
     * (2) Your APP should be connecting to the database with the minium necessary permissions on 
     *     that database user. (we would use DCL (Data Control Language) to manage that (CREATE USER, GRANT, REVOKE))
    */
    using SqlCommand command = new($"INSERT Books VALUES (@title,'E.F.Codd',@pages,'thick', 2,3)", 
        connection);
    // prevent sql injection
    command.Parameters.AddWithValue("title", title);
    command.Parameters.AddWithValue("pages", pages);
    command.ExecuteNonQuery();   //return # rows effected
    connection.Close();
}
