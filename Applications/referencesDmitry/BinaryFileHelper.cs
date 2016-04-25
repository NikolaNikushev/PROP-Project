using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                    //because of FileStream
using System.Runtime.Serialization.Formatters.Binary; //because of BinaryFormatter
using System.Runtime.Serialization; //because of SerializationException

namespace AnimalShelterManager
{
    class BinaryFileHelper
    {

        // ----------------FIELDS AND PROPERTIES-------------
        // Default bin file name
        private static String defFilePath = "../../ANIMSHELTBinFile.txt";
        public static String DefFilePath
        {
            get { return defFilePath; }
        }


        // ----------------METHODS-------------
        /// <summary>
        /// Gives an output showing whether the load was sucessful, 
        /// outputs a list of objects
        /// </summary>
        /// <param name="Res"></param>
        /// <returns></returns>
        public static bool OpenBinFile(out List<Animal> Res) 
        {
            bool MethodRes = false;
            FileStream fs = null;
            BinaryFormatter bf = null;
            Res = null;
            try
            {
                fs = new FileStream(DefFilePath, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                Res = (List<Animal>)(bf.Deserialize(fs));
                MethodRes = true;
            }
            catch (SerializationException)
            { MessageBox.Show("something wrong with Serialization"); }
            catch (IOException)
            { MessageBox.Show("something wrong with IO"); }
            catch
            {
                MessageBox.Show("something is wrong");
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            return MethodRes;
        }

        /// <summary>
        /// Opens a file from specified path
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="Res"></param>
        /// <returns></returns>
        public static bool OpenBinFile(String FileName,out List<object> Res)
        {
            bool MethodRes = false;
            FileStream fs = null;
            BinaryFormatter bf = null;
            Res = null;
            try
            {
                fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                bf = new BinaryFormatter();
                Res = (List<Object>)(bf.Deserialize(fs));
                MethodRes = true;
                SetDefaultFilePath(FileName);
            }
            catch (SerializationException)
            {
                MessageBox.Show("something wrong with Serialization", "SERIALIZE ERROR");
            }
            catch (IOException)
            {
                MessageBox.Show("something wrong with IO", "IO ERROR");
            }
            catch
            {
                MessageBox.Show("something is wrong");
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            return MethodRes;
        }


        /// <summary>
        /// Save a binary file to the default file. 
        /// Takes a list of objects as a parameter
        /// </summary>
        /// <param name="ListToSave"></param>
        /// <returns></returns>
        public static bool SaveBinFile(List<Animal> AnShToSave)
        {
            bool MethodRes = false;
            /// byte cracker
            /// helper
            FileStream fs = null;
            BinaryFormatter bf = null;
            /// 
            try
            {
                fs = new FileStream(DefFilePath, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, AnShToSave);
                //bf.Serialize(fs, t);
                MethodRes = true;
            }
            catch (SerializationException)
            { MessageBox.Show("something wrong with Serialization", "SERIALIZE ERROR"); }
            catch (IOException)
            { MessageBox.Show("something wrong with IO","IO ERROR"); }
            catch
            {
                MessageBox.Show("something is wrong");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Save a binary file to the default file. 
        /// Takes a list of objects to save as a parameter
        /// And a specific File Name - where to save
        /// </summary>
        /// <param name="FileName"></param>
        /// <param name="ListToSave"></param>
        /// <returns></returns>
        public static bool SaveBinFile(String FileName, AnimalShelter ListToSave)
        {
            bool MethodRes = false;
            /// byte cracker
            /// helper
            FileStream fs = null;
            BinaryFormatter bf = null;
            /// 
            try
            {
                fs = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();
                bf.Serialize(fs, ListToSave);
                //bf.Serialize(fs, t);
                MethodRes = true;
                SetDefaultFilePath(FileName);
            }
            catch (SerializationException)
            { MessageBox.Show("something wrong with Serialization", "SERIALIZE ERROR"); }
            catch (IOException)
            { MessageBox.Show("something wrong with IO", "IO ERROR"); }
            catch
            {
                MessageBox.Show("something is wrong");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
            return MethodRes;
        }

        /// <summary>
        /// Replaces a def file path with one spec by user
        /// </summary>
        /// <param name="newFilePath"></param>
        public static void SetDefaultFilePath(String newFilePath)
        {
            defFilePath = newFilePath;
        }


    }
}
