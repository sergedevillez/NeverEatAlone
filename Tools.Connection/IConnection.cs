using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace Tools.Connection
{
    public interface IConnection
    {
        DbConnection CreateConnection();
        int ExecuteNonQuery(Command command);
        IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataRecord, TResult> selector);
        object ExecuteScalar(Command command);
        DataTable GetDataTable(Command command);
    }
}