using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

[ApiController]
[Route("api/etudiantControl")]
public class EtudiantsController : ControllerBase
{
    private readonly string _connexionInfo = "server=localhost;database=bonita;user=root;password='';";

    [HttpPost("update")]
    public async Task<IActionResult> UpdateNote([FromBody] UpdateNoteRequest request)
    {
        using (var conn = new MySqlConnection(_connexionInfo))
        {
            await conn.OpenAsync();
            string commandText = $"UPDATE note SET {request.Field} = @value WHERE Matricule = @matricule";

            using (var command = new MySqlCommand(commandText, conn))
            {
                command.Parameters.AddWithValue("@value", request.Value);
                command.Parameters.AddWithValue("@matricule", request.Matricule);

                int rowsAffected = await command.ExecuteNonQueryAsync();
                if (rowsAffected > 0)
                {
                    return Ok();
                }
                return NotFound();
            }
        }
    }
}

public class UpdateNoteRequest
{
    public string Matricule { get; set; }
    public string Field { get; set; }
    public string Value { get; set; }
}