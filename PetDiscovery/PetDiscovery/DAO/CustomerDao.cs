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

        public void DeleteCustomer(Customer customer)
        {
            cmd.CommandText = "delete from tb_Cliente where cliente_Id = @Id";

            cmd.Parameters.AddWithValue("@Id", customer.Id);

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

        public List<Customer> GetAllCustomer()
        {
            throw new Exception();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Customer customer)
        {
            cmd.CommandText = "insert into tb_Cliente (cliente_Id, cliente_Nome, cliente_Email) values (@Id, @Nome, @Email)";

            cmd.Parameters.AddWithValue("@Id", customer.Id);
            cmd.Parameters.AddWithValue("@Nome", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);

            try
            {
                cmd.Connection = connection.Connect();
                cmd.ExecuteNonQuery();
                this.message = "Cadastrado com sucesso";
            }
            catch
            {
                this.message = "Deu ruim campeão!";
            }
            finally
            {
                connection.Close();
            }
            
        }

        public void UpdateCustomer(Customer customer)
        {
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
