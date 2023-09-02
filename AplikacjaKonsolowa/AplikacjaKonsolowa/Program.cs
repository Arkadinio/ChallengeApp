using AplikacjaKonsolowa;

Student student1 = new Student(1, "Jan", "As", 22);
Student student2 = new Student(2, "Zbyszek", "Brzoskwinia", 23);
Student student3 = new Student(3, "Dagmara", "Rajstopy", 25);

List<Student> students = new List<Student>()
{
    student1, student2, student3
};

int MaxResult = -1;
Student studentWithMaxAge = null;

foreach (var student in students)
{
	if (student.Age > MaxResult)
	{
		MaxResult = student.Age;
		studentWithMaxAge = student;
	}
}

Console.WriteLine("Najstarszy użytkownik to: " + studentWithMaxAge.Name + " " + studentWithMaxAge.Surname + " z wiekiem wynoszącym " + studentWithMaxAge.Age);