using Npgsql;
using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.DAO
{
    class PositiveResultsDao : IPositiveResults
    {
        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";

        public List<PositiveResults> GetResults()
        {
            throw new NotImplementedException();
        }

        public int InsertResult(PositiveResults positive)
        {
            var wasInsert = 1;

            cmd.CommandText = "insert into tb_resultadospositivos (resultadospositivos_cliente_id, resultadospositivos_animal_id, resultadospositivos_resultados) values(@ClienteId, @AnimalId, @Result) ";
            cmd.Parameters.AddWithValue("@ClienteId", positive.CustomerId);
            cmd.Parameters.AddWithValue("@AnimalId", positive.AnimalId);
            cmd.Parameters.AddWithValue("@Result", positive.Result);

            try
            {
                cmd.Connection = connection.Connect();
                wasInsert = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

            return wasInsert;
        }

        public int UpdateResult(PositiveResults positive)
        {
            var wasUpdated = 1;

            cmd.CommandText = "update tb_resultadospositivos set resultadospositivos_cliente_id = @ClienteId, resultadospositivos_animal_id = @AnimalId, resultadospositivos_resultados = @Result";
            cmd.Parameters.AddWithValue("@ClienteId", positive.CustomerId);
            cmd.Parameters.AddWithValue("@AnimalId", positive.AnimalId);
            cmd.Parameters.AddWithValue("@Result", positive.Result);

            try
            {
                cmd.Connection = connection.Connect();
                wasUpdated = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

            return wasUpdated;
        }
    }
}
