using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DatabaseType db)
        {
            if(db  == DatabaseType.Sql)
            {
                // TODO - Set up the SQL Connector
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

    }
}
