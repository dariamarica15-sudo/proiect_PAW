using System.Collections.Generic;
using System.Data.SqlClient;

namespace proiect
{
    public class MaterialRepository
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS\Documents\ProiectDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void AdaugaMaterial(Material m, int idFurnizor)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Materiale
                                (Id, Denumire, Cantitate, PretUnitar, IdFurnizor)
                                VALUES
                                (@Id, @Denumire, @Cantitate, @PretUnitar, @IdFurnizor)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", m.Id);
                    command.Parameters.AddWithValue("@Denumire", m.Denumire);
                    command.Parameters.AddWithValue("@Cantitate", m.Cantitate);
                    command.Parameters.AddWithValue("@PretUnitar", m.PretUnitar);
                    command.Parameters.AddWithValue("@IdFurnizor", idFurnizor);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void StergeMaterial(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Materiale WHERE Id=@Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditeazaMaterial(Material m)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Materiale
                                SET Denumire=@Denumire,
                                    Cantitate=@Cantitate,
                                    PretUnitar=@PretUnitar
                                WHERE Id=@Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", m.Id);
                    command.Parameters.AddWithValue("@Denumire", m.Denumire);
                    command.Parameters.AddWithValue("@Cantitate", m.Cantitate);
                    command.Parameters.AddWithValue("@PretUnitar", m.PretUnitar);

                    command.ExecuteNonQuery();
                }
            }
        }

        public Dictionary<int, List<Material>> GetMateriale()
        {
            Dictionary<int, List<Material>> materiale =
                new Dictionary<int, List<Material>>();

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    @"SELECT Id,
                     Denumire,
                     Cantitate,
                     PretUnitar,
                     IdFurnizor
              FROM Materiale";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    SqlDataReader reader =
                        command.ExecuteReader();

                    while (reader.Read())
                    {
                        Material m = new Material();

                        m.Id = reader.GetInt32(
                            reader.GetOrdinal("Id"));

                        m.Denumire = reader.GetString(
                            reader.GetOrdinal("Denumire"));

                        m.Cantitate = reader.GetDouble(
                            reader.GetOrdinal("Cantitate"));

                        m.PretUnitar = reader.GetDecimal(
                            reader.GetOrdinal("PretUnitar"));

                        int idFurnizor = reader.GetInt32(
                            reader.GetOrdinal("IdFurnizor"));

                        if (!materiale.ContainsKey(idFurnizor))
                        {
                            materiale[idFurnizor] =
                                new List<Material>();
                        }

                        materiale[idFurnizor].Add(m);
                    }
                }
            }

            return materiale;
        }
        public void EditeazaMaterial(Material m, int idInitial)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Materiale
                         SET Id = @IdNou,
                             Denumire = @Denumire,
                             Cantitate = @Cantitate,
                             PretUnitar = @PretUnitar
                         WHERE Id = @IdInitial";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdNou", m.Id);
                    command.Parameters.AddWithValue("@Denumire", m.Denumire);
                    command.Parameters.AddWithValue("@Cantitate", m.Cantitate);
                    command.Parameters.AddWithValue("@PretUnitar", m.PretUnitar);
                    command.Parameters.AddWithValue("@IdInitial", idInitial);

                    command.ExecuteNonQuery();
                }
            }
        }
    }


}