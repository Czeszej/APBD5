namespace WebApplication1.Models
{
    public class Animal 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float mass { get; set; }
        public string color { get; set; }

        public List<Visit> _visits = new List<Visit>();

       

        public Animal() { }
        public Animal(int id, string name, string description, float mass, string color)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.mass = mass;
            this.color = color;
        }

     
      
    }


}
