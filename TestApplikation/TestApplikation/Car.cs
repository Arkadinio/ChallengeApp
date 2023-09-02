
namespace TestApplikation
{
    public class Car
    {
        public string Marka { get; private set; }

        public string Model { get; private set; }

        public float Price { get; private set; }


        public Car(string marka, string model, float price)
        {
            this.Marka = marka;
            this.Model = model;
            this.Price = price;
        }
        
         
        
    }
}

