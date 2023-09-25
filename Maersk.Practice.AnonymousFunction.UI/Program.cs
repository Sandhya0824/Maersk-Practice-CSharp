namespace Maersk.Practice.AnonymousFunction.UI
{
    internal class Program
    {
        public delegate bool EmployeeDelegate<T>(T obj);

        static void Main(string[] args)
        {
            List<IEmployee> employeeList = new List<IEmployee>()
            {
                new Employee{Id = 101, Name="Nayanika",Salary=300000 },
                new Employee{Id = 201, Name="Rahul",Salary=400000 },
                new Employee{Id = 401, Name="Aish",Salary=7000 },
                new Employee{Id = 501, Name="Rohan",Salary=500000 },
                new Employee{Id = 601, Name="Natasha",Salary=400000 },
            };

            //Delegates
            EmployeeValidity employeeValidity = new EmployeeValidity();
            EmployeeDelegate<IEmployee> employeeDelegate = new EmployeeDelegate<IEmployee>(employeeValidity.IsEmployeeValid);
            List<IEmployee> employeeList1 = employeeList.FindAll(x => employeeDelegate(x));

                     
            //Anonymous Function
            List<IEmployee> employeeList2 = employeeList.FindAll(
                delegate(IEmployee employee){
                    return employee.Salary == 400000;
                }
            );

            //Lambda expression
            List<IEmployee> employeeList3 = employeeList.FindAll(employee => employee.Salary == 400000);


            foreach (IEmployee employee in employeeList2)
            {
                Console.WriteLine("Id: {0}, Name:{1}", employee.Id, employee.Name);
            }

        }

    }

    
}