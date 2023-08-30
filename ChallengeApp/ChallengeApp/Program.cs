using ChallengeApp;

Employee employee1 = new Employee("Jan", "As",30);
Employee employee2 = new Employee("Monika", "Czyszka",22);
Employee employee3 = new Employee("Zuzia", "Sandał", 15);


employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(1);

employee2.AddScore(2);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(2);
employee3.AddScore(3);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;



foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;

    }

}

Console.WriteLine("Największą ilość punktów posiada użytkownik " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surrname + " wiek " + employeeWithMaxResult.Age + " z ilością punktów " + employeeWithMaxResult.Result);

