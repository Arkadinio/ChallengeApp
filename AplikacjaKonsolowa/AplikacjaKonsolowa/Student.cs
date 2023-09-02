using AplikacjaKonsolowa;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKonsolowa
{
    public class Student
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int Age { get; private set; }

        public Student(int id, string Name, string Surname, int Age)
        {
            this.Id = id;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }
    }
}
