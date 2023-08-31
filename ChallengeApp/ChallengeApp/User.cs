namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }

        public string Surrname { get; private set; }

        public int Age { get; private set; }


        private List<int> score = new List<int>();

        public Employee(string name, string surrname, int age)
        {
            this.Name = name;
            this.Surrname = surrname;
            this.Age = age;

        }

        public void AddScore(int number)
        {

            this.score.Add(number);

        }

        public int Result
        {
            get
            {
                return this.score.Sum();

            }
        }
    }
}
