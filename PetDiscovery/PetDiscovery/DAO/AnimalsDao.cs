using Npgsql;
using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetDiscovery.DAO
{
    class AnimalsDao : IAnimals
    {

        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";

        public int Delete(Animals animals)
        {
            var wasDeleted = 1;

            cmd.CommandText = "delete from tb_animais where animais_Id = @Id";
            cmd.Parameters.AddWithValue("@Id", animals.Id);

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

        public int Insert(Animals animals, LogedUser loged)
        {
            var wasInsert = 1;

            cmd.CommandText = "insert into tb_animais (animais_Id, animais_Nome, animais_FlagAchadoPerdido, animais_FlagBuscaIgnora, animais_cliente_Id, animais_Tipo, animais_Raca, animais_cliente_Id, animais_UF, animais_Cidade, animais_Bairro, animais_Rua, animais_Distancia) values (@Id, @Nome, @FlagAP, @FlagProcura, @IdCliente, @Tipo, @Raca, @ClienteId, @Uf, @Cidade, @Bairro, @Rua, @Distancia) ";
            cmd.Parameters.AddWithValue("@Id", animals.Id);
            cmd.Parameters.AddWithValue("@Cidade", animals.Name);
            cmd.Parameters.AddWithValue("@UF", animals.FoundAndLostFlag);
            cmd.Parameters.AddWithValue("@Pais", animals.KeepSearching);
            cmd.Parameters.AddWithValue("@IdCliente", animals.CustomerId);
            cmd.Parameters.AddWithValue("@Tipo", animals.Type);
            cmd.Parameters.AddWithValue("@Raca", animals.Breed);
            cmd.Parameters.AddWithValue("@ClienteId", loged.Id);
            cmd.Parameters.AddWithValue("@UF", animals.UfAnimal);
            cmd.Parameters.AddWithValue("@Cidade", animals.CityAnimal);
            cmd.Parameters.AddWithValue("@Bairro", animals.NeigherborAnimal);
            cmd.Parameters.AddWithValue("@Rua", animals.StreetAnimal);
            cmd.Parameters.AddWithValue("@Distancia", animals.Distance);


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

        public int Update(Animals animals)
        {
            var wasUpdated = 1;

            cmd.CommandText = "update tb_animais set endereco_Id = @Id, endereco_cliente_Id = @IdCliente, endereco_Cidade = @Cidade, endereco_UF = @UF, endereco_Pais = @Pais, endereco_Rua = @Rua, endereco_Numero = @Numero";

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

        public List<Animals> GetAnimals()
        {
            Animals animals = new Animals();
            List<Animals> lst = new List<Animals>();

            cmd.CommandText = "select * from tb_animais";

            try
            {
                cmd.Connection = connection.Connect();
                NpgsqlDataReader cmdR = cmd.ExecuteReader();

                while (cmdR.Read())
                {
                    animals.Id = (int)Convert.ToInt64(cmdR["animais_Id"].ToString());
                    animals.Name = cmdR["animais_Nome"].ToString();
                    animals.FoundAndLostFlag = cmdR["animais_FlagAchadoPerdido"].ToString();
                    animals.CustomerId = (int)Convert.ToInt64(cmdR["animais_cliente_Id"].ToString());

                    lst.Add(animals);
                }
                cmdR.Close();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

            return lst;
        }

        public List<Animals> CompativeAnimals(Animals animals)
        {
            List<Animals> lst = new List<Animals>();

            cmd.CommandText = "select * from tb_animais where @Tipo = animals_Tipo and @Raca = animals_Raca";

            try
            {
                cmd.Connection = connection.Connect();
                NpgsqlDataReader cmdR = cmd.ExecuteReader();

                while (cmdR.Read())
                {
                    animals.Id = (int)Convert.ToInt64(cmdR["animais_Id"].ToString());
                    animals.Name = cmdR["animais_Nome"].ToString();
                    animals.Type = cmdR["animais_Tipo"].ToString();
                    animals.Breed = cmdR["animais_Raca"].ToString();

                    lst.Add(animals);
                }
                cmdR.Close();
            }
            catch (Exception e)
            {
                this.message = "Erro: " + e;
            }
            finally
            {
                connection.Close();
            }

            return lst;
        }
    }
}
