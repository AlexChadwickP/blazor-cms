using System;
using System.Threading.Tasks;
using Npgsql;

namespace DatabaseManager.Client
{
    public class Create
    {
        public async Task SubmitAsync(DatabaseConfig cfg, ClientSchema schema)
        {
            await using var conn = new NpgsqlConnection(cfg.GetConnectionString());
            await conn.OpenAsync();

            await using (
                var cmd = new NpgsqlCommand(@"INSERT INTO client (
                first_name, last_name, email, phone_number, website
                )
                VALUES (
                    @fn, @ln, @e, @pn, @w
                )", conn)
            )
            {
                cmd.Parameters.AddWithValue("fn", schema.FirstName);
                cmd.Parameters.AddWithValue("ln", schema.LastName);
                cmd.Parameters.AddWithValue("e", schema.Email);
                cmd.Parameters.AddWithValue("pn", schema.PhoneNumber);
                cmd.Parameters.AddWithValue("w", schema.Website);
                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}