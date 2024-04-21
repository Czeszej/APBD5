using System.Runtime.CompilerServices;
using WebApplication1.Controllers;

namespace WebApplication1.Models
{
    public class Visit
    {
        public int animalId { get; set; }
        public DateTime date { get; set; }
        public Animal animal { get; set; }
        public string treatment {  get; set; }
        public float cost { get; set; }

        public Visit(int animalId, DateTime date, string treatment, float cost)
        {
            this.animalId = animalId;
            this.date = date;
            this.animal = AnimalsControllers._animals.First(animal => animal.id == animalId);
            this.treatment = treatment;
            this.cost = cost;
        }

    }

  
}
