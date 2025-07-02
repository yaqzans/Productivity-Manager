namespace ProductivityManager
{
    /// <summary>
    /// A central, single place to hold the application's database connection string.
    /// This makes the application much easier to manage.
    /// </summary>
    public static class DbConnection
    {
        // This is the single source of truth for the database connection string.
        // If you ever need to change it, you only have to change it here.
        public const string ConnectionString =
            "Data Source=DESKTOP-VGTB6P9;Initial Catalog=Productivity;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
    }
}
