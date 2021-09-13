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


        public void DeleteAdress(Adress adress)
        {
            cmd.CommandText = "delete from tb_Endereco where endereco_Id = @Id";
            cmd.Parameters.AddWithValue("@Id", adress.Id);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }
        }

        public Adress GetAdress(int rollNo)
        {
            throw new NotImplementedException();
        }

        public List<Adress> GetAllAdress()
        {
            throw new NotImplementedException();
        }

        public void InsertAdress(Adress adress)
        {
            cmd.CommandText = "insert into tb_Endereco (endereco_Id, endereco_cliente_Id, endereco_Cidade, endereco_UF, endereco_Pais, endereco_Rua, endereco_Numero) values (@Id, @IdCliente, @Cidade, @UF, @Pais, @Rua, @Numero) ";
            cmd.Parameters.AddWithValue("@Id", adress.Id);
            cmd.Parameters.AddWithValue("@IdCliente", adress.CustomerId);
            cmd.Parameters.AddWithValue("@Cidade", adress.City);
            cmd.Parameters.AddWithValue("@UF", adress.UF);
            cmd.Parameters.AddWithValue("@Pais", adress.Country);
            cmd.Parameters.AddWithValue("@Rua", adress.Street);
            cmd.Parameters.AddWithValue("@Numero", adress.Number);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

        }

        public void UpdateAdress(Adress adress)
        {
            cmd.CommandText = "update tb_Endereco set endereco_Id = @Id, endereco_cliente_Id = @IdCliente, endereco_Cidade = @Cidade, endereco_UF = @UF, endereco_Pais = @Pais, endereco_Rua = @Rua, endereco_Numero = @Numero" ;

            if (adress.Id != null)
            {
                cmd.Parameters.AddWithValue("@Id", adress.Id);
            }

            if (adress.CustomerId != null)
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
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
