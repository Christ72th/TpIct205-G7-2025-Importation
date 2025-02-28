using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading.Tasks;

public class ConnexionBd
{
    private string ConnexionInfo = "server=localhost;database=pvs;user=root;password='';";

    public MySqlConnection seConnecter()
    {
        MySqlConnection conn = new MySqlConnection(ConnexionInfo);
        conn.Open();
        return conn;
    }/*
    public ConnexionBd(ConnexionInfo){
        ConnexionInfo=ConnexionInfo;
    }
*/
    public async Task<bool> InsererUtilisateur()
    {
        using (var conn = seConnecter())
        {
            /*string query = "INSERT INTO users(tenantid,Enable_U, Username, Password_U, FirstName, LastName,Title, CreateBy, CreationDate, LastUpdate)VALUES(8,'On',@Username,@Password,@FirstName, @LastName, @Title, @Username, NOW(),NOW());";
            string sql= "INSERT INTO Users(Username, Nom, Prenom) VALUES(@id, @nom, @prenom);";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.ExecuteNonQuery();*/
        }
        return true;
    }
}
/*

    public async Task<bool> RegisterUser(RegisterModel model)
    {
        using (var connection = new MySqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            var query = "INSERT INTO Users (FirstName, LastName, DateOfBirth, Email, BirthCity, Username, Password) " +
                        "VALUES (@FirstName, @LastName, @DateOfBirth, @Email, @BirthCity, @Username, @Password)";

            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", model.FirstName);
                command.Parameters.AddWithValue("@LastName", model.LastName);
                command.Parameters.AddWithValue("@DateOfBirth", model.DateOfBirth);
                command.Parameters.AddWithValue("@Email", model.Email);
                command.Parameters.AddWithValue("@BirthCity", model.BirthCity);
                command.Parameters.AddWithValue("@Username", model.Username);
                command.Parameters.AddWithValue("@Password", HashPassword(model.Password)); // Hachage du mot de passe

                var result = await command.ExecuteNonQueryAsync();
                return result > 0; // Retourne vrai si l'insertion a réussi
            }
        }
    }

    private string HashPassword(string password)
    {
        using (var sha256 = SHA256.Create())
        {
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }
}*/