using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TetePizza.Model;

namespace TetePizza.Data
{
    public class PizzaSqlRepository : IPizzaRepository
    {
        private readonly string _connectionString;

        public PizzaSqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }



        public List<Pizza> GetAll()
        {
            var pizzas = new List<Pizza>();
            try
            {
               
            }

            catch (Exception ex)
            {
                throw new Exception("Error al obtener las pizzas e ingredientes: " + ex.Message, ex);
            }

            return pizzas;
        }



        public Pizza Get(int Id)
        {
            var pizza = new Pizza();
            try
            {
               
            }
            catch (Exception ex)
            {
                throw;
            }
            return pizza;
        }



        public void Add(Pizza pizza)
        {
            try
            {
               
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de SQL Server: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error general: " + ex.Message, ex);
            }

        }



        public void Delete(int Id)
        {
            try
            {
                
            }
            catch (SqlException ex)
            {

                throw;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Update(Pizza pizza)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }

    
}