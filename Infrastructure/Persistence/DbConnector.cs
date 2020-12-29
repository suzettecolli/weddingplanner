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
            builder.UserID = "ple0049";              // update me
            builder.Password = "*******";      // update me
            builder.InitialCatalog = "ple0049";
            return builder;
        }
    }
}
