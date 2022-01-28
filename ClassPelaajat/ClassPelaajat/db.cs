using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ClassPelaajat
{
    public class db
    {
        public SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source = tietokanta.db; Version = 3; New = True; Compress = True;");
    }
}
