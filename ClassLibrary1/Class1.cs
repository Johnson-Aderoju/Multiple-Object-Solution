public class Employee 
{
    public int empID;
    public string empName;
    public double salaryPerhour;
    public int noOfWorkingHours;
    public double netSalary;

	public int getEmpID() {
		return this.empID;
	}

	public void setEmpID(int empID) {
		this.empID = empID;
	}

	public string getEmpName() {
		return this.empName;
	}

	public void setEmpName(string empName) {
		this.empName = empName;
	}

	public double getSalaryPerhour() {
		return this.salaryPerhour;
	}

	public void setSalaryPerhour(double salaryPerhour) {
		this.salaryPerhour = salaryPerhour;
	}

	public int getNoOfWorkingHours() {
		return this.noOfWorkingHours;
	}

	public void setNoOfWorkingHours(int noOfWorkingHours) {
		this.noOfWorkingHours = noOfWorkingHours;
	}

    public static string organizationName = "Harsha Inc.";
    public const string typeOfEmployee = "Contract Based";
    public readonly string departmentName;
    
    public Employee()
    {
        departmentName = "Finance Department";
    }
    
    public double NetSalary ()
    {
        netSalary = salaryPerhour*noOfWorkingHours;
        return netSalary;
    }

	public void EmployeeCompany()
	{
		Console.WriteLine("*********"+organizationName+"********");
		Console.WriteLine("Department: "+departmentName);
		Console.WriteLine("Type of Employee: "+typeOfEmployee);
		Console.WriteLine();
	}

    public void EmployeeDetails()
    {
       Console.WriteLine(getEmpID());
	   Console.WriteLine(getEmpName());
	   Console.WriteLine(getNoOfWorkingHours());
	   Console.WriteLine(getSalaryPerhour());
	   Console.WriteLine(NetSalary());
    } 
    


}