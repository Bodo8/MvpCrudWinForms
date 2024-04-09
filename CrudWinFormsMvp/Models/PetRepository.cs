using CrudWinFormsMvp.AppConnection;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWinFormsMvp.Models
{
    public class PetRepository : IPetRepository
    {
        public int Add(Pet pet)
        {
            using IDbConnection db = CreateConnection();
            string query = $"INSERT INTO [dbo].[Pet] (PetName, PetType, Colour) VALUES (@PetName, @PetType, @Colour)";
            return db.Execute(query, pet);
        }

        public int Delete(Pet pet)
        {
            using IDbConnection db = CreateConnection();
            string query = $"DELETE FROM [dbo].[Pet] WHERE IdPet=@IdPet";
            return db.Execute(query, pet);
        }

        public int Update(Pet pet)
        {
            using IDbConnection db = CreateConnection();
            string query = $"UPDATE [dbo].[Pet] SET PetName=@PetName, PetType=@PetType, Colour=@Colour WHERE IdPet=@IdPet";
            return db.Execute(query, pet);
        }

        public IEnumerable<Pet> GetAll()
        {
            using IDbConnection db = CreateConnection();

            return db.Query<Pet>("SELECT * FROM Pet");
        }

        public IEnumerable<Pet> GetByValue(string value)
        {
            using IDbConnection db = CreateConnection();
            string query = $"SELECT * FROM [dbo].[Pet] WHERE PetName=@PetName OR PetType=@PetType OR Colour=@Colour";
            return db.Query<Pet>(query, new { PetName = value, PetType = value, Colour = value });
        }

        private IDbConnection CreateConnection()
        {
            IDbConnection conn = new SqlConnection(AppConnectionString.SqlConnectionString);
            conn.Open();
            return conn;
        }
    }
}
