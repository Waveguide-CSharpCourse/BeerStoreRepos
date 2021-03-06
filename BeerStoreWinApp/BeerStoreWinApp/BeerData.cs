﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;


namespace BeerStoreWinApp
{
    class BeerData
    {
        string DBPath;
        string connection_string_BeerTable;

        /// <summary>
        /// Default constructor
        /// </summary>
        public BeerData()
        {
            DBPath = @"C:\Users\jcerezo\Documents\Visual Studio 2015\Projects\BeerStoreRepos\BeerStoreWinApp\BeerStoreWinApp\Data\ItemData.accdb";
            //DBPath = @"C:\Users\tlyde\Documents\C# Course\CodeSamples\BeerStoreRepos\BeerStoreWinApp\BeerStoreWinApp\Data\ItemData.accdb";
            connection_string_BeerTable = @"Provider=Microsoft.ACE.OLEDB.12.0; Persist Security Info=False; Data Source= " + DBPath;
        }


        /// <summary>
        /// Connects to the Access database, queries the Beer table to get everything and returns a datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getBeerData()
        {
            DataTable beerData = new DataTable();
            using (OleDbConnection connection = new OleDbConnection(connection_string_BeerTable))
            {
                string cmdText_Beers = @"SELECT * FROM [Beers]";
                using (OleDbDataAdapter tempAdapter = new OleDbDataAdapter(cmdText_Beers, connection))
                using (new OleDbCommandBuilder(tempAdapter))
                {
                    try
                    {
                        connection.Open();
                        tempAdapter.Fill(beerData);  //fills adapter with values from table
                    }
                    catch (Exception sqlexc)
                    {
                        Console.WriteLine("Error reading Beers Table: " + sqlexc.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        tempAdapter.Dispose();
                    }
                }
            }

            return beerData;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataTable getMunchiesData()
        {
            DataTable munchiesData = new DataTable();
            /*
                Codes that handles query from database
            */
            using (OleDbConnection connection = new OleDbConnection(connection_string_BeerTable))
            {
                string cmdText = @"SELECT * FROM [JunkFood]";
                using (OleDbDataAdapter tempAdapter = new OleDbDataAdapter(cmdText, connection))
                using (new OleDbCommandBuilder(tempAdapter))
                {
                    try
                    {
                        connection.Open();
                        tempAdapter.Fill(munchiesData);  //fills adapter with values from table
                    }
                    catch (Exception sqlexc)
                    {
                        Console.WriteLine("Error reading Beers Table: " + sqlexc.ToString());
                    }
                    finally
                    {
                        connection.Close();
                        tempAdapter.Dispose();
                    }
                }
            }
            
            return munchiesData;
        }

    }
}
