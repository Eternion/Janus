﻿using System;
using Janus.ORM.SubSonic.Query;
using Janus.ORM.SubSonic.Schema;

namespace Janus.ORM.SubSonic.DataProviders.SQLite
{

    public class SQLiteProvider : DbDataProvider, IDataProvider
    {
        public override string InsertionIdentityFetchString { get { return String.Empty; } }

        public SQLiteProvider(string connectionString, string providerName) : base(connectionString, providerName)
        {}

        public override string QualifyTableName(ITable table)
        {
            string qualifiedTable;

            qualifiedTable = qualifiedTable = String.Format("`{0}`", table.Name);


            return qualifiedTable;
        }

        public override string QualifyColumnName(IColumn column)
        {
            string qualifiedFormat;
            qualifiedFormat = "`{2}`";
            return String.Format(qualifiedFormat, column.Table.SchemaName, column.Table.Name, column.Name);
        }

        public override ISchemaGenerator SchemaGenerator
        {
            get { return new SQLiteSchema(); }
        }

        public override ISqlGenerator GetSqlGenerator(SqlQuery query)
        {
            return new SQLiteGenerator(query);
        }

        public override IQueryLanguage QueryLanguage { get { return new SQLiteLanguage(this); } }

    }
}
