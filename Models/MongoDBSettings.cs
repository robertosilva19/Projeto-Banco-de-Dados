namespace Projeto_Banco_de_Dados.Models
{
    public class MongoDBSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }

        public MongoDBSettings()
        {
            this.ConnectionString = "mongodb+srv://robertosilvacomercial:<ruhG8Raly11yOsQc>@cluster0.tpjyrrj.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"; // Default MongoDB connection string
            this.DatabaseName = "Airports"; // Default database name
            this.CollectionName = "BR"; // Default collection name
        }
    }
}
