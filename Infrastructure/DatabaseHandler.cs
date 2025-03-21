using System;

namespace Infrastructure
{
    public class DatabaseHandler
    {
        private string connectionstring;

        public void Connect( string conn )
        {
            try {
                connectionstring = conn;
            }
            catch(Exception ex)
            {
                throw ex; // FxCop violation: rethrow
            }
        }

        public object query(string sql) {
            // FxCop violation: SQL injection possibility
            return null;
        }
    }
}