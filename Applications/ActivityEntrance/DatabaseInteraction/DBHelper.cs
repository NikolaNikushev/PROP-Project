using System;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;
public class DBHelper
{
    private string queryOutput = "Not reserved";
    private List<string> activityData;
    private string activityID;
    private string selectedActivity;
    private string userID;
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
    public DBHelper(string selectedActivity)
    {
        this.selectedActivity = selectedActivity;
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
            reader = VerifyData(braceletID).ExecuteReader();
            if (reader.Read())
            {
                userID = reader["USER_ID"].ToString();
                reader.Close();
                reader = BraceletDataCommand(braceletID, activityID).ExecuteReader();
                if (reader.Read())
                {

                    queryOutput = reader["BRACELET_ID"].ToString();
                    reader.Close();
                    reader = InsertIntoHistory(userID).ExecuteReader();
                    reader.Close();
                }
                else
                {
                    reader = DecreasePlaces(selectedActivity).ExecuteReader();
                    if (reader.Read())
                    {
                        queryOutput = "You can enter";
                        reader.Close();
                        reader = InsertIntoHistory(userID).ExecuteReader();
                        reader.Close();
                    }
                }

            }
            else
            {
                reader.Close();
                queryOutput = "Visitor's data is not consistent";
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


    // methods for return the retrieved data
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
        try
        {
            connection.Open();
            reader = ActivityDetailsCommand(selectedActivity).ExecuteReader();
            if (reader.Read())
            {
                activityID = reader["ACTIVITY_ID"].ToString();
            }
            reader.Close();
            reader = BraceletDataCommand(braceletID, activityID).ExecuteReader();
            if (reader.Read())
            {
                return "Reserved";
            }
            else
            {
                return "Free to go places";
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
    }
    public List<string> RetrievePlacesDetails(string activityID)
    {
        List<string> placesList = new List<string>();
        try
        {
            connection.Open();
            reader = PlacesDetailsCommand(activityID).ExecuteReader();
            if (reader.Read())
            {
                placesList.Add(reader["TOTALPLACES"].ToString());
                placesList.Add(reader["RESERVEDPLACES"].ToString());
                placesList.Add(reader["FREEPLACES"].ToString());
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
        return placesList;
    }
    public List<string> RetrieveActivityDetails(string activityName)
    {
        activityData = new List<string>();
        try
        {
            connection.Open();
            reader = ActivityDetailsCommand(activityName).ExecuteReader();
            if (reader.Read())
            {
                activityData.Add(reader["ACTIVITYNAME"].ToString());
                activityData.Add(reader["DATE"].ToString());
                activityData.Add(reader["ACTIVITY_ID"].ToString());
                activityID = activityData[2];
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





    //Commands for retrieving data
    private MySqlCommand PlacesDetailsCommand(string activityID)
    {
        string placesDetailsQuery = "SELECT TOTALPLACES, RESERVEDPLACES, FREEPLACES " +
                                    "FROM  activityplaces_view " +
                                    "WHERE ACTIVITY_ID = " + "\"" + activityID + "\";";
        MySqlCommand placesDetailsCommand = new MySqlCommand(placesDetailsQuery, connection);
        return placesDetailsCommand;
    }
    private MySqlCommand ActivityNamesCommand()
    {
        string activityNameQuery = "SELECT ACTIVITYNAME " +
                                   "FROM activities;";
        MySqlCommand activityNameCommand = new MySqlCommand(activityNameQuery, connection);
        return activityNameCommand;
    }
    private MySqlCommand BraceletDataCommand(string braceletID, string activityID)
    {
        string isReservedQuery = "SELECT v.BRACELET_ID AS \'BRACELET_ID\', v.USER_ID " +
                         "FROM visitors v left join rfids r " +
                         "ON v.BRACELET_ID = r.BRACELET_ID left join activityreservations ar " +
                         "ON v.USER_ID = ar.USER_ID " +
                         "WHERE v.USER_ID = ar.USER_ID " +
                         "AND ar.ACTIVITY_ID = " + "\"" + activityID + "\" " +
                         "AND v.BRACELET_ID = " + "\"" + braceletID + "\";";


        MySqlCommand isReservedCommand = new MySqlCommand(isReservedQuery, connection);
        return isReservedCommand;
    }
    private MySqlCommand ActivityDetailsCommand(string activityName)
    {
        string activityDetailsQuery = "SELECT * " +
                                      "FROM activities " +
                                      "WHERE ACTIVITYNAME = " + "\"" + activityName + "\";";
        MySqlCommand activityNameCommand = new MySqlCommand(activityDetailsQuery, connection);
        return activityNameCommand;
    }

    //Update and isert data commands
    private MySqlCommand DecreasePlaces(string activityName)
    {
        string decreasePlacesQuery = "UPDATE activities " +
                                     "SET OPENPLACESTAKEN = OPENPLACESTAKEN + 1 " +
                                     "WHERE ACTIVITYNAME = " + "\"" + activityName + "\";";
        MySqlCommand decreasePlacesCommand = new MySqlCommand(decreasePlacesQuery, connection);
        return decreasePlacesCommand;

    }
    private MySqlCommand InsertIntoHistory(string userID)
    {
        string insertQuery = "INSERT INTO location_history (USER_ID,ACTIVITY_ID,TIME_ENTRANCE) " +
                             "VALUES (\"" + userID + "\",\"" + activityID + "\", NOW());";



        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
        return insertCommand;
    }

    private MySqlCommand VerifyData(string braceletID)
    {
        string verifyQuery = "SELECT v.USER_ID " +
                             "FROM visitors v " +
                             "WHERE v.BRACELET_ID = " + "\"" + braceletID + "\"; ";


        MySqlCommand verifyQueryCommand = new MySqlCommand(verifyQuery, connection);
        return verifyQueryCommand;
    }
}

