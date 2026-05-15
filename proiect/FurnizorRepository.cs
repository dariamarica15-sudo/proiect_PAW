using System.Collections.Generic;
using System.Data.SqlClient;

namespace proiect
{
    public class FurnizorRepository
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS\Documents\ProiectDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void AdaugaFurnizor(Furnizor f)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Furnizori
                                (Id, Nume, CUI, Adresa, Telefon, Email)
                                VALUES
                                (@Id, @Nume, @CUI, @Adresa, @Telefon, @Email)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", f.Id);
                    command.Parameters.AddWithValue("@Nume", f.Nume);
                    command.Parameters.AddWithValue("@CUI", f.CUI);
                    command.Parameters.AddWithValue("@Adresa", f.Adresa);
                    command.Parameters.AddWithValue("@Telefon", f.Telefon);
                    command.Parameters.AddWithValue("@Email", f.Email);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Furnizor> GetFurnizori()
        {
            List<Furnizor> lista = new List<Furnizor>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Id, Nume, CUI, Adresa, Telefon, Email FROM Furnizori";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Furnizor f = new Furnizor();

                        f.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        f.Nume = reader.GetString(reader.GetOrdinal("Nume"));
                        f.CUI = reader.GetString(reader.GetOrdinal("CUI"));
                        f.Adresa = reader.GetString(reader.GetOrdinal("Adresa"));
                        f.Telefon = reader.GetString(reader.GetOrdinal("Telefon"));
                        f.Email = reader.GetString(reader.GetOrdinal("Email"));

                        lista.Add(f);
                    }
                }
            }

            return lista;
        }

        public void StergeFurnizor(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Furnizori WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditeazaFurnizor(Furnizor f)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Furnizori
                                SET Nume = @Nume,
                                    CUI = @CUI,
                                    Adresa = @Adresa,
                                    Telefon = @Telefon,
                                    Email = @Email
                                WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", f.Id);
                    command.Parameters.AddWithValue("@Nume", f.Nume);
                    command.Parameters.AddWithValue("@CUI", f.CUI);
                    command.Parameters.AddWithValue("@Adresa", f.Adresa);
                    command.Parameters.AddWithValue("@Telefon", f.Telefon);
                    command.Parameters.AddWithValue("@Email", f.Email);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}