class Sample
{
    static void Main()
    {
        Employee employee1, employee2, employee3, employee4, 
        employee5, employee6, employee7, employee8, employee9, employee10 ;

        employee1 = new Employee();
        employee2 = new Employee();
        employee3 = new Employee();
        employee4 = new Employee();
        employee5 = new Employee();
        employee6 = new Employee();
        employee7 = new Employee();
        employee8 = new Employee();
        employee9 = new Employee();
        employee10 = new Employee();
        
        employee1.setEmpID(001);
        employee1.setEmpName("Bash");
        employee1.setSalaryPerhour(800);
        employee1.setNoOfWorkingHours(9);

        employee1.EmployeeCompany();
        employee1.EmployeeDetails();


        
        // Console.WriteLine("Employee ID "+ employee1.getEmpID());
        // Console.WriteLine("Employee "+ employee1.getEmpID()+ " name is "+ employee1.getEmpName());
        // Console.WriteLine("Employee"+ employee1.getEmpID()+ " salary per hour is "+employee1.getSalaryPerhour());
        // Console.WriteLine("Employee "+ employee1.getEmpID()+ " number of working hour is "+employee1.getNoOfWorkingHours());
        // Console.WriteLine("Employee "+ employee1.getEmpID()+ " net salary is "+employee1.NetSalary());
        // Console.WriteLine("Employee "+ employee1.getEmpID()+ " works at "+Employee.organizationName);
        // Console.WriteLine("Employee "+ employee1.getEmpID()+ " is a  "+Employee.typeOfEmployee);
        // Console.WriteLine(employee1.departmentName);

        string userInput = Console.ReadLine();
        

    }
}
