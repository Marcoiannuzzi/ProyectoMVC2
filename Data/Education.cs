namespace ProyectoMVC2.Data
{
    public class Education:BaseEntity
    {
        public string Name { get; set; }
        public string Institution { get; set; }
        public string Description { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}
