namespace OOP.Studies.Encapsulation
{
    public class Repository
    {
        private string connectionString;

        private DbConnection dbConnection = new DbConnection();

        public void ExecuteComand(string query)
        {
            dbConnection.OpenConnection(connectionString);
            BeginTransaction();
            

            Commit();
            dbConnection.CloseConnection();
        }

        protected void BeginTransaction()
        {
            // create transaction
        }

        protected void Commit()
        {
            // commit command
        }
    }
}
