
namespace EmployeeApp
{ 



      
       partial class Employee
    {
        public void DisplayStatus()
        {
            Console.WriteLine("name of the employee is {0}", empName);
            Console.WriteLine("id of the employee is {0}", empID);
            Console.WriteLine(" current pay of the employee is {0}", currPay);
            Console.WriteLine("age of the employee is {0}", empAge);

        }

        /*
        // Accessor method get method

        public string GetName()
        {
            return empName;
        }

        // Mutetor method set method 
          
        public void SetName(string name)

        {
            if (name.Length > 15)
                Console.WriteLine("the name should be less than 15 characters");
            else
                empName = name;
        }
        public int GetId()
        {
           return empID;
        }
        public void SetID(int id)
        {
           empID = id;
        }
        public double GetPay()
        {
           return currPay;
        }
        public void SetPay(double pay)
        {
          currPay = Pay;
        }
        

        public int GetAge()
        {
          return empAge;
        }
        public void SetAge(int age)
        {
          empAge = age;
        }
        public int GetSSN()
            {
                return empSSN;

            } 
        */

        //Console.WriteLine("the employee details are name {0} id {1} pay {2} and age {3} ", emp.Name, emp.Id, emp.Pay);
        // emp.Age ++;
        //Console.WriteLine("the new age of the employee shall be {0} and social num {1}", emp.empAge, emp.empSSN);
        // emp.SetAge(emp.GetAge() + 1);
        // Console.WriteLine("the age caller with getter is {0}", emp.GetAge());


        //Console.WriteLine("the name of the current employee is {0}", emp.GetName());
        //////

    }
}
