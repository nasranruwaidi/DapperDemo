using DapperDemo.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace DapperDemo.Repository
{
    public class CompanyRepository : ICompanyRepository
    {

        private IDbConnection db;

        public CompanyRepository(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }

        public Company Add(Company company)
        {

        }

        public Company Find(int id)
        {
    
        }

        public List<Company> GetAll()
        {
            var sql = "select * from companies";
            return db.Query<Company>(sql).ToList();

        }

        public void Remove(int id)
        {

        }

        public Company Update(Company company)
        {

        }
    }
}
