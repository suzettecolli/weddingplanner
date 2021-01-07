using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Infrastructure.Persistence
{
    /// <summary>
    /// Helper class for creating an connection string.
    /// </summary>
    public static class DBConnector
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"dbsys.cs.vsb.cz\STUDENT";   // update me
            builder.UserID = @"dra0111";              // update me
            builder.Password = "iMXpTxo0J2";      // update me
            builder.InitialCatalog = "dra0111";
            return builder;
        }
    }
}
