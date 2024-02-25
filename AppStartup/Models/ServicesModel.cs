namespace AppStartup.Models
{
    public class ServicesModel
    {
        public string Titre { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public static List<ServicesModel> GetServices()
        {
            List<ServicesModel> serviceList = new List<ServicesModel>
            {
                new ServicesModel { Titre = "Analyste de Données", Type = "Data Analysis", Description = "Nous fournnissons des solutions d'analyse de données basées sur l'intelligence artificielle pour aider votre entreprise à prendre des décisions éclairées." },
                new ServicesModel { Titre = "Traitement du langage Naturel", Type = "Natural Language Processing", Description = "Notre expertise en traitement du langage naturel permet de transformer vos données textuelles en informations exploitable." },
                new ServicesModel { Titre = "Vision par Ordinateur", Type = "Computer Vision", Description = "Nos solutions de vision par ordinateur utilisent l'intelligence artificielle pour analyser et interpéter des images et vidéos." },
            };

            return serviceList;
        }
    }
}
