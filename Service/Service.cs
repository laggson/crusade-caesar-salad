using System.Collections.Generic;

namespace WCFChat.Service
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class Service : IService
    {
        public string[] GetData()
        {
            return DbHelper.GetAllValues();
        }

        public void AddData(string value)
        {
            DbHelper.InsertTest(value);
        }
    }
}
