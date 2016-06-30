using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
public class DBHelper
{
    private MySqlConnection connection ;
    private MySqlDataReader reader;
    private string userID;
    public DBHelper()
    {
        //    String connectionInfo = "server=localhost;" +
        //                            "database=propdbtest;" +
        //                            "user id=root;" +
        //                            "password=;" +
        //                            "connect timeout=30;" +
        //                            "convert zero datetime=True";

        connection = new MySqlConnection(DBConnectionDll.Connection.connectionInfo);
    }

    public void IncreasePlaces(string activityName)
    {
        try
        {
            connection.Open();
            reader = IncreacePlacesCommand(activityName).ExecuteReader();
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            connection.Close();
        }

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
                //adding activity names to list and returning them after
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

    public string InsertIntoHistory(string braceletID)
    {
        try
        {
            connection.Open();
            //retrieve data to use in the update history query
            reader = RetrieveUserData(braceletID).ExecuteReader();
            if(reader.Read())
            {
                userID = reader["USER_ID"].ToString();
                reader.Close();
                reader = InsertIntoHistoryCommand(userID).ExecuteReader();
            }
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            connection.Close();
        }
        return "Successfully updated";
    }
    //commands
    private MySqlCommand IncreacePlacesCommand(string activityName)
    {
        string increasePlacesQuery = "UPDATE activities " +
                                     "SET OPENPLACESTAKEN = OPENPLACESTAKEN - 1 " +
                                     "WHERE ACTIVITYNAME = " + "\"" + activityName + "\";";
        MySqlCommand increasePlacesCommand = new MySqlCommand(increasePlacesQuery, connection);
        return increasePlacesCommand;

    }
    private MySqlCommand ActivityNamesCommand()
    {
        string activityNameQuery = "SELECT ACTIVITYNAME " +
                                   "FROM activities;";
        MySqlCommand activityNameCommand = new MySqlCommand(activityNameQuery, connection);
        return activityNameCommand;
    }
    private MySqlCommand RetrieveUserData(string braceletID)
    {
        string userDataQuery = "SELECT DISTINCT v.USER_ID AS \'USER_ID\' "+
                                "FROM visitors v LEFT JOIN activityreservations a "+
                                "ON(v.USER_ID = a.USER_ID) "+
                                "WHERE v.BRACELET_ID = " + "\"" + braceletID + "\";";

        MySqlCommand userDataCommand = new MySqlCommand(userDataQuery, connection);
        return userDataCommand;
    }
    private MySqlCommand InsertIntoHistoryCommand(string userID)
    {
        string insertQuery = "UPDATE location_history " +
                             "SET TIME_EXIT = NOW() " +
                             "WHERE TIME_ENTRANCE = (SELECT * " +
                                                    "FROM(SELECT MAX(TIME_ENTRANCE) " +
                                                         "FROM location_history) timeMax) "+
                             "AND USER_ID = " + "\"" + userID + "\";"; 

        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
        return insertCommand;
    }
    
}

