using CreditSuisse_TestDev.Interfaces;
using System.Data.SqlClient;

namespace CreditSuisse_TestDev.Repositories;

class InstrumentRepository
{
    private const string ConnectionString = "Server=localhost;Database=CreditSuisse_Instruments;Integrated Security=True;";

    public void InsertFinancialInstruments(List<IFinancialInstrument> instruments)
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            foreach (var instrument in instruments)
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO FinancialInstruments (MarketValue, Type) VALUES (@MarketValue, @Type)", connection))
                {
                    command.Parameters.AddWithValue("@MarketValue", instrument.MarketValue);
                    command.Parameters.AddWithValue("@Type", instrument.Type);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public void ExecuteCategorizeInstrumentsProcedure()
    {
        using (SqlConnection connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("CategorizeInstruments", connection))
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
        }
    }
}
