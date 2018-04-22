﻿using Janus.ORM.SubSonic.SQLGeneration;

namespace Janus.ORM.SubSonic.DataProviders.MySQL
{
    class MySqlSqlFragment : SqlFragment
    {
        public MySqlSqlFragment()
        {
            this.LEFT_INNER_JOIN = this.LEFT_JOIN;  //MSSQL Doesn't like standard left join syntax.
            this.RIGHT_INNER_JOIN = this.RIGHT_JOIN;

        }
    }
}

