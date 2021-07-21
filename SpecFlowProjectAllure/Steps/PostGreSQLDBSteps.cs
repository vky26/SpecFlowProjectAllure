using Npgsql;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProjectAllure.Steps
{
    [Binding]
    public class PostGreSQLDBSteps
    {

        private static string Host = "localhost";
        private static string User = "postgres";
        private static string DBname = "postgres";
        private static string Password = "admin";
        private static string Port = "5432";

        [Given(@"I made a connection to db")]
        public void GivenIMadeAConnectionToDb()
        {


            var cs = "Host=localhost;Username=postgres;Password=admin;Database=postgres";

            using (var con = new NpgsqlConnection(cs))
            {
                con.Open();
                var sql = "SELECT name from links where id=1";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    String result = cmd.ExecuteScalar().ToString();
                    Console.WriteLine("result -> " + result);
                }
            }
           

        }

            [Then(@"I fetch a value from table")]
            public void ThenIFetchAValueFromTable()
            {
                Console.WriteLine($"PostgreSQL version:");
            }
        }
    }
