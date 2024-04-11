using System.IO;
using System.Xml;

namespace WarehouseSystem
{
    public static class SQLData
    {
        public static string server = "";
        public static string user = "";
        public static string password = "";
        public static string database = "";

        public static string ConnectionString = $"server={SQLData.server};user={SQLData.user};database={SQLData.database};password={SQLData.password};";

        public const string pathSQLConConfig = "SQLConnectionConfig.xml";
        public static bool LoadSqlData()
        {
            if (!File.Exists(pathSQLConConfig)) return false;

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(pathSQLConConfig);
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            if (xRoot != null)
            {
                foreach (XmlNode childnode in xRoot.ChildNodes)
                {
                    if (childnode.Name == "server") server = childnode.InnerText;
                    if (childnode.Name == "user") user = childnode.InnerText;
                    if (childnode.Name == "password") password = childnode.InnerText;
                    if (childnode.Name == "database") database = childnode.InnerText;
                }
            }

            ConnectionString = $"server={SQLData.server};user={SQLData.user};database={SQLData.database};password={SQLData.password};";
            return true;
        }
    }
}