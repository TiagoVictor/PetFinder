using Npgsql;
using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;

namespace PetDiscovery.DAO
{
    class AdressDao : IAdress
    {

        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";


        public int DeleteAdress(Adress adress)
        {
            var wasDeleted = 1;

            cmd.CommandText = "delete from tb_Endereco where endereco_Id = @Id";
            cmd.Parameters.AddWithValue("@Id", adress.Id);

            try
            {
                cmd.Connection = connection.Connect();
                wasDeleted = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }
            
            return wasDeleted;
        }

        public Adress GetAdress(int rollNo)
        {
            throw new NotImplementedException();
        }

        public List<Adress> GetAllAdress()
        {
            throw new NotImplementedException();
        }

        public int InsertAdress(Adress adress, LogedUser loged)
        {
            var wasInsert = 1;

            cmd.CommandText = "insert into tb_Endereco (endereco_Id, endereco_cliente_Id, endereco_Cidade, endereco_UF, endereco_Pais, endereco_Rua, endereco_Numero, endereco_cliente_Id) values (@Id, @IdCliente, @Cidade, @UF, @Pais, @Rua, @Numero, @ClienteId) ";
            cmd.Parameters.AddWithValue("@Id", adress.Id);
            cmd.Parameters.AddWithValue("@IdCliente", adress.CustomerId);
            cmd.Parameters.AddWithValue("@Cidade", adress.City);
            cmd.Parameters.AddWithValue("@UF", adress.UF);
            cmd.Parameters.AddWithValue("@Pais", adress.Country);
            cmd.Parameters.AddWithValue("@Rua", adress.Street);
            cmd.Parameters.AddWithValue("@Numero", adress.Number);
            cmd.Parameters.AddWithValue("@ClienteId", loged.Id);

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

        public int UpdateAdress(Adress adress)
        {
            var wasUpdated = 1;

            cmd.CommandText = "update tb_Endereco set endereco_Id = @Id, endereco_cliente_Id = @IdCliente, endereco_Cidade = @Cidade, endereco_UF = @UF, endereco_Pais = @Pais, endereco_Rua = @Rua, endereco_Numero = @Numero" ;

            if (adress.Id != 0)
            {
                cmd.Parameters.AddWithValue("@Id", adress.Id);
            }

            if (adress.CustomerId != 0)
            {
                cmd.Parameters.AddWithValue("@IdCliente", adress.CustomerId);
            }

            if (adress.City != null)
            {
                cmd.Parameters.AddWithValue("@Cidade", adress.City);
            }

            if (adress.UF != null)
            {
                cmd.Parameters.AddWithValue("@UF", adress.UF);
            }

            if (adress.Country != null)
            {
                cmd.Parameters.AddWithValue("@Pais", adress.Country);
            }

            if (adress.Street != null)
            {
                cmd.Parameters.AddWithValue("@Rua", adress.Street);
            }

            if (adress.Number != null)
            {
                cmd.Parameters.AddWithValue("@Numero", adress.Number);
            }

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
