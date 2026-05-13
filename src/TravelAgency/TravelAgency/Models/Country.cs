namespace TravelAgency.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool VisaRequired { get; set; }

        public string VisaStatus => VisaRequired ? "Нужна виза" : "Без визы";
    }
}