﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banhang.Library
{
    public abstract class RepositoryBase : IDisposable
    {
        public String ConnectionString;
        public RepositoryBase()
        {
            ConnectionString = "Data Source=.;";
            ConnectionString += "Initial Catalog=QuanlySinhvien;";
            ConnectionString += "Integrated Security=SSPI;";
        }
        public void Dispose()
        {
        }
    }
}
