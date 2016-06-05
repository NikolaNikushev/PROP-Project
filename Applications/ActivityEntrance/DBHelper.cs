using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

public class DBHelper
{
    private string queryOutput = "Not reserved";
    private MySqlConnection connection;


    public DBHelper()
    {
        String connectionInfo = "server=localhost;" +
                                "database=propdbtest;" +
                                "user id=root;" +
                                "password=;" +
                                "connect timeout=30;" +
                                "convert zero datetime=True";

        connection = new MySqlConnection(connectionInfo);
    }

    public string IsReserved(string bracelet_id)
    {
        string isReservedQuery = "SELECT v.BRACELET_ID AS \'BRACELET_ID\' " +
                        "FROM visitors v left join rfids r " +
                        "ON v.BRACELET_ID = r.BRACELET_ID left join activityreservations ar " +
                        "ON v.USER_ID = ar.USER_ID " +
                        "WHERE v.BRACELET_ID = " + "\"" + bracelet_id + "\";";


        MySqlCommand isReserved = new MySqlCommand(isReservedQuery, connection);

        try
        {
            connection.Open();
            MySqlDataReader reader = isReserved.ExecuteReader();
            if (reader.Read())
            {
                queryOutput = reader["BRACELET_ID"].ToString() + "  visitor has reserved place, you can enter";
            }
            else
            {
                reader.Close();

                reader = DecreasePlaces().ExecuteReader();
                reader.Close();
                reader = PlacesInfo().ExecuteReader();
                if (reader.Read())
                {
                    queryOutput = "Total places " + reader["TOTALPLACES"].ToString() + " Open places taken " + reader["OPENPLACESTAKEN"].ToString();
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
            //return ex.ToString();
        }
        finally
        {
            connection.Close();
        }
        return queryOutput;
    }
    public List<string> retrieveActivityNames()
    {
        List<string> activityNames = new List<string>();
        try
        {
            connection.Open();
            MySqlDataReader reader = RetrieveActivityNames().ExecuteReader();
            while (reader.Read())
            {
                activityNames.Add(reader["ACTIVITYNAME"].ToString());
            }
        }
        catch (Exception)
        {

            throw;
        }
        return activityNames;
    }


    private MySqlCommand DecreasePlaces()
    {
        string decreasePlacesQuery = "UPDATE activities " +
                                     "SET OPENPLACESTAKEN = OPENPLACESTAKEN + 1 " +
                                     "WHERE ACTIVITY_ID = 3;";
        MySqlCommand decreasePlacesCommand = new MySqlCommand(decreasePlacesQuery, connection);
        return decreasePlacesCommand;

    }
    private MySqlCommand PlacesInfo()
    {
        string placesInfoQuery = "SELECT TOTALPLACES, OPENPLACESTAKEN " +
                                 "FROM activities " +
                                 "WHERE ACTIVITY_ID = 3;";
        MySqlCommand placesInfoCommand = new MySqlCommand(placesInfoQuery, connection);
        return placesInfoCommand;
    }
    private MySqlCommand RetrieveActivityNames()
    {
        string activityNameQuery = "SELECT ACTIVITYNAME " +
                                   "FROM activities;";
        MySqlCommand activityNameCommand = new MySqlCommand(activityNameQuery, connection);
        return activityNameCommand;
    }
}

