using System.Collections.Generic;
using System.Data.SqlClient;

namespace proiect
{
    public class ContractRepository
    {
        private string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\WINDOWS\Documents\ProiectDB.mdf;Integrated Security=True;Connect Timeout=30";

        public void AdaugaContract(Contract c)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Contracte
                                (IdContract, IdFurnizor, DataContract, Observatii, TotalContract)
                                VALUES
                                (@IdContract, @IdFurnizor, @DataContract, @Observatii, @TotalContract)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdContract", c.IdContract);
                    command.Parameters.AddWithValue("@IdFurnizor", c.IdFurnizor);
                    command.Parameters.AddWithValue("@DataContract", c.DataContract);
                    command.Parameters.AddWithValue("@Observatii", c.Observatii);
                    command.Parameters.AddWithValue("@TotalContract", c.TotalContract);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void StergeContract(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Contracte WHERE IdContract=@Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditeazaContract(Contract c)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Contracte
                                SET Observatii=@Observatii
                                WHERE IdContract=@IdContract";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdContract", c.IdContract);
                    command.Parameters.AddWithValue("@Observatii", c.Observatii);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Contract> GetContracte()
        {
            List<Contract> lista = new List<Contract>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query =
                    @"SELECT IdContract,
                             IdFurnizor,
                             DataContract,
                             Observatii
                      FROM Contracte";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Contract c = new Contract();

                        c.IdContract = reader.GetInt32(
                            reader.GetOrdinal("IdContract"));

                        c.IdFurnizor = reader.GetInt32(
                            reader.GetOrdinal("IdFurnizor"));

                        c.DataContract = reader.GetDateTime(
                            reader.GetOrdinal("DataContract"));

                        c.Observatii = reader["Observatii"].ToString();

                        c.Materiale = new List<Material>();

                        lista.Add(c);
                    }
                }
            }

            return lista;
        }
    }
}