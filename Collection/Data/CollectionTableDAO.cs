using Collection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Collection.Data
{
    internal class CollectionTableDAO
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OGTIKEColletionDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        //performs all operations on the database. Get all, delete, create, get one, search etc.

        public List<CollectionModel> FetchAll()
        {
            List<CollectionModel> returnList = new List<CollectionModel>();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from [dbo].[CollectionTable]";

                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new collection object. Add it to the list to return
                        CollectionModel collection = new CollectionModel();
                        collection.Id = reader.GetInt32(0);
                        collection.Category = reader.GetString(1);
                        collection.Description = reader.GetString(2);
                        collection.Model = reader.GetString(3);
                        collection.WithThisActor = reader.GetString(4);
                        collection.Price = reader.GetDecimal(5);


                        returnList.Add(collection);



                    }
                }


            }


            return returnList;
        }

        internal int Delete(int id)
        {
            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.CollectionTable WHERE Id = @Id";


                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar, 1000).Value = id;


                connection.Open();
                int deletedID = command.ExecuteNonQuery();


                return deletedID;
            }
        }

        internal List<CollectionModel> SearchForName(string searchPhrase)
        {
            List<CollectionModel> returnList = new List<CollectionModel>();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from [dbo].[CollectionTable] WHERE CATEGORY LIKE @searchForMe";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@searchForMe", System.Data.SqlDbType.NVarChar).Value = "%" + searchPhrase + "%";

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new collection object. Add it to the list to return
                        CollectionModel collection = new CollectionModel();
                        collection.Id = reader.GetInt32(0);
                        collection.Category = reader.GetString(1);
                        collection.Description = reader.GetString(2);
                        collection.Model = reader.GetString(3);
                        collection.WithThisActor = reader.GetString(4);
                        //collection.Price = reader.GetDecimal(5);


                        returnList.Add(collection);



                    }
                }

                return returnList;
            }


        }

        public CollectionModel FetchOne(int Id)
        {
            CollectionModel collection = new CollectionModel();

            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string sqlQuery = "SELECT * from [dbo].[CollectionTable] WHERE Id = @id";

                //associate @id with Id parameter


                SqlCommand command = new SqlCommand(sqlQuery, connection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = Id;

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //create a new collection object. Add it to the list to return
                        
                        collection.Id = reader.GetInt32(0);
                        collection.Category = reader.GetString(1);
                        collection.Description = reader.GetString(2);
                        collection.Model = reader.GetString(3);
                        collection.WithThisActor = reader.GetString(4);
                        collection.Price = reader.GetDecimal(5);
                    }
                }


            }


            return collection;
        }


        //create one

        
        public int CreateOrUpdate(CollectionModel collectionModel)
        {
            // if collectionModel.id <= 1 then create

            // if collectionModel.id > 1 then update is meant



            //acces the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";

                if (collectionModel.Id <= 1)
                {
                   sqlQuery =  "INSERT INTO dbo.CollectionTable Values(@Category, @Description, @Model, @AppearsIn, @Price)";

                }
                else
                {
                    //update
                    sqlQuery = "UPDATE dbo.CollectionTable SET Category = @Category, Description = @Description, Model = @Model, WithThisActor= @WithThisActor, Price = @Price WHERE Id = @Id";
                }



                SqlCommand command = new SqlCommand(sqlQuery, connection);
                
                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar, 1000).Value = collectionModel.Id;
                command.Parameters.Add("@Category", System.Data.SqlDbType.VarChar,1000).Value = collectionModel.Category;
                command.Parameters.Add("@Description", System.Data.SqlDbType.VarChar, 1000).Value = collectionModel.Description;
                command.Parameters.Add("@Model", System.Data.SqlDbType.VarChar, 1000).Value = collectionModel.Model;
                command.Parameters.Add("@WithThisActor", System.Data.SqlDbType.VarChar, 1000).Value = collectionModel.WithThisActor;
                command.Parameters.Add("@Price", System.Data.SqlDbType.Decimal).Value = collectionModel.Price;

                connection.Open();
                int newID =  command.ExecuteNonQuery();


                return newID;
            }


            
        }
        // delete one

        //update one

        //search for name

        //search for description
    }
}