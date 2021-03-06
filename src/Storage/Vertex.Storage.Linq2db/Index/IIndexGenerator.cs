﻿using System.Threading.Tasks;
using LinqToDB.Data;

namespace Vertex.Storage.Linq2db.Index
{
    public interface IIndexGenerator
    {
        Task CreateUniqueIndexIfNotExists(DataConnection conn, string table, string indexName, params string[] columns);

        Task CreateIndexIfNotExists(DataConnection conn, string table, string indexName, params string[] columns);
    }
}
