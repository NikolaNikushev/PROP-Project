using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;                    //because of FileStream
using System.Runtime.Serialization.Formatters.Binary; //because of BinaryFormatter
using System.Runtime.Serialization; //because of SerializationException

namespace StatsApp
{
    public class BinaryFileHelper
    {

        //IN THE BEGINNING CREATE myFile.txt in the folder with all the other classes!!!

        public void SaveToBinaryFile(List<string> List)
        {
            string filename = "../../DAY_" + Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
            FileStream fs = null;
            BinaryFormatter bf = null;

            try
            {
                fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, List);
            }
            catch (SerializationException)
            { MessageBox.Show("something wrong with Serialization"); }
            catch (IOException)
            { MessageBox.Show("No Data Available"); }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        //In the form you should assign: 'YOUR LIST NAME' = bfh.LoadFromBinaryFile();
        public List<string> LoadFromBinaryFile(string filepath)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            List <string> List = new List<string>();
            try
            {
                fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                List = (List <string>)(bf.Deserialize(fs));
            }
            catch (SerializationException)
            { MessageBox.Show("something wrong with Serialization or you don't have anything on it yet"); }
            catch (IOException)
            { MessageBox.Show("No Data Available"); }
            finally
            {
                if (fs != null) fs.Close();
            }
            return List;
        }

    }
}
