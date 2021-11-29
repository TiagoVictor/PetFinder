using PetDiscovery.IDAO;
using PetDiscovery.Model;
using System;
using System.Collections.Generic;
using Npgsql;

namespace PetDiscovery.DAO
{
    class CustomerDao : ICustomer
    {

        DaoFactory connection = new DaoFactory();
        NpgsqlCommand cmd = new NpgsqlCommand();
        String message = "";

        public int DeleteCustomer(Customer customer)
        {
            var wasDeleted = 1;

            cmd.CommandText = "delete from tb_Cliente where cliente_Id = @Id";

            cmd.Parameters.AddWithValue("@Id", customer.Id);

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

        public Customer GetCustomer(string email, string password)
        {
            Customer customer = new Customer();

            cmd.CommandText = "select * from tb_Cliente where cliente_Email = @Email and cliente_Password = @Senha";
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Senha", password);

            try
            {
                cmd.Connection = connection.Connect();
                NpgsqlDataReader cmdR = cmd.ExecuteReader();

                while (cmdR.Read())
                {
                    customer.Id = (int)Convert.ToInt64(cmdR["cliente_Id"].ToString());
                    customer.Name = cmdR["cliente_Nome"].ToString();
                    customer.Email = cmdR["cliente_Email"].ToString();
                    customer.Password = cmdR["cliente_Password"].ToString();
                }
                cmdR.Close();
            }
            catch(Exception e)
            {
                this.message = "Erro " + e;
            }

            finally
            {
                connection.Close();
            }

            return customer;
        }

        public int InsertCustomer(Customer customer)
        {
            var wasInsert = 1;
            cmd.CommandText = "insert into tb_Cliente (cliente_Id, cliente_Nome, cliente_Email, cliente_Password) values (@Id, @Nome, @Email, @Senha)";

            cmd.Parameters.AddWithValue("@Id", customer.Id);
            cmd.Parameters.AddWithValue("@Nome", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Senha", customer.Password);

            try
            {
                cmd.Connection = connection.Connect();
                wasInsert = cmd.ExecuteNonQuery();
                this.message = "Cadastrado com sucesso";
            }
            catch(Exception e)
            {
                wasInsert = 0;
                this.message = "Deu ruim campeão! " + e;
            }
            finally
            {
                connection.Close();
            }

            return wasInsert;
            
        }

        public int UpdateCustomer(Customer customer)
        {
            var wasUpdated = 1;

            cmd.CommandText = "update tb_Cliente set cliente_Nome = @Nome, cliente_email = @Email where cliente_id = @Id";

            if(customer.Email != null)
            {
                cmd.Parameters.AddWithValue("@Email", customer.Email);
            }

            if(customer.Name != null)
            {
                cmd.Parameters.AddWithValue("@Nome", customer.Name);
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
