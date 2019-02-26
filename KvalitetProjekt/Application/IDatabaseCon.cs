using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalitetProjekt.Application
{
    public interface IDatabaseCon
    {
        private static string connectionString =
            "Server=EALSQL1.eal.local; Database= C_DB13_2018; User Id=C_STUDENT13; Password=C_OPENDB13;";
        string ConnectionString1 { get; set; }
    }
}
