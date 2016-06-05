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
    MySqlDataReader reader;

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

    public string Entrance(string braceletID)
    {
        try
        {
            connection.Open();
            reader = BraceletDataCommand(braceletID).ExecuteReader();
            if (reader.Read())
            {
                string userID = reader["USER_ID"].ToString();

                reader.Close();
                reader = VerifyData(userID).ExecuteReader();
                if (reader.Read())
                {
                    queryOutput = reader["BRACELET_ID"].ToString();
                }
                else
                {
                    queryOutput = "Visitor's data is not consistent";
                }

                reader.Close();
            }
            else
            {
                reader = DecreasePlaces().ExecuteReader();
                reader.Close();
                //reader = PlacesInfo().ExecuteReader();
                if (reader.Read())
                {
                    queryOutput = "Total places " + reader["TOTALPLACES"].ToString() + " Open places taken " + reader["OPENPLACESTAKEN"].ToString();
                }
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            connection.Close();
        }
        return queryOutput;
    }


    public List<string> RetrieveActivityDetails(string activityName)
    {
        List<string> activityData = new List<string>();
        try
        {
            connection.Open();
            reader = ActivityDetailsCommand(activityName).ExecuteReader();
            if (reader.Read())
            {
                activityData.Add(reader["ACTIVITYNAME"].ToString());
                activityData.Add(reader["DATE"].ToString());
            }
        }

        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            connection.Close();
        }
        return activityData;

    }
    public List<string> RetrieveActivityNames()
    {
        List<string> activityNames = new List<string>();
        try
        {
            connection.Open();
            reader = ActivityNamesCommand().ExecuteReader();
            while (reader.Read())
            {
                activityNames.Add(reader["ACTIVITYNAME"].ToString());
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            connection.Close();
        }
        return activityNames;
    }
    public string RetrieveBraceletData(string braceletID)
    {
        connection.Open();
        reader = BraceletDataCommand(braceletID).ExecuteReader();
        if (reader.Read())
        {
            return "Reserved";
        }
        else
        {
            return "Free to go places";
        }
    }

    private MySqlCommand DecreasePlaces()
    {
        string decreasePlacesQuery = "UPDATE activities " +
                                     "SET OPENPLACESTAKEN = OPENPLACESTAKEN + 1 " +
                                     "WHERE ACTIVITY_ID = 3;";
        MySqlCommand decreasePlacesCommand = new MySqlCommand(decreasePlacesQuery, connection);
        return decreasePlacesCommand;

    }
    private MySqlCommand InsertIntoHistory()
    {
        string insertQuery = "";



        MySqlCommand isertCommand = new MySqlCommand(insertQuery, connection);
        return isertCommand;
    }
    private MySqlCommand PlacesDetailsCommand(string activityID)
    {
        string placesDetailsQuery = "SELECT TOTALPLACES, RESERVEDPLACES, FREEPLACES " +
                                    "FROM  activityplaces_view " +
                                    "WHERE ACTIVITY_ID = " + "\"" + activityID + "\";";
        MySqlCommand placesDetailsCommand = new MySqlCommand(placesDetailsQuery, connection);
        return placesDetailsCommand;
    }
    private MySqlCommand ActivityDetailsCommand(string activityName)
    {
        string activityDetailsQuery = "SELECT * " +
                                      "FROM activities " +
                                      "WHERE ACTIVITYNAME = " + "\"" + activityName + "\";";
        MySqlCommand activityNameCommand = new MySqlCommand(activityDetailsQuery, connection);
        return activityNameCommand;
    }
    private MySqlCommand ActivityNamesCommand()
    {
        string activityNameQuery = "SELECT ACTIVITYNAME " +
                                   "FROM activities;";
        MySqlCommand activityNameCommand = new MySqlCommand(activityNameQuery, connection);
        return activityNameCommand;
    }
    private MySqlCommand BraceletDataCommand(string braceletID)
    {
        string isReservedQuery = "SELECT v.BRACELET_ID AS \'BRACELET_ID\',USER_ID " +
                         "FROM visitors v left join rfids r " +
                         "ON v.BRACELET_ID = r.BRACELET_ID left join activityreservations ar " +
                         "ON v.USER_ID = ar.USER_ID " +
                         "WHERE v.BRACELET_ID = " + "\"" + braceletID + "\";";


        MySqlCommand isReservedCommand = new MySqlCommand(isReservedQuery, connection);
        return isReservedCommand;
    }

    private MySqlCommand VerifyData(string braceletID)
    {
        string verifyQuery = "SELECT lh.USER_ID * " +
                             "FROM location_history lh " +
                             "JOIN location_history lh " +
                             "WHERE lh.USER_ID = 1124 " +
                             "HAVING NOW() > MAX(lh.TIME_ENTRANCE) " +
                             "AND NOW() > IFNULL(MAX(lh.TIME_EXIT), 0);";

        MySqlCommand verifyQueryCommand = new MySqlCommand(verifyQuery, connection);
        return verifyQueryCommand;
    }

}

