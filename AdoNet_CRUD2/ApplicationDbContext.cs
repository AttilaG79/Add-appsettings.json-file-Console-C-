using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet_CRUD2
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration _configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }

        public void GetConnectionStringDB()
        {
            var getJsonData = _configuration.GetSection("ConnectionStrings:Default").Value;
            Console.WriteLine($"SQL Server ConnectionString : {getJsonData} ");
        }
    }
}
