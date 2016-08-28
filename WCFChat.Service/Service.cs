namespace WCFChat.Service
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service1" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class Service : IService
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
        }
    }
}
