using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {

        private string empName;
        private int empID;
        private double currPay;
        private int empAge;
        private int empSSN;
        /*   nested class 
     public class BenefitPacakage
            {
            public enum BenefitPacakgeLevel
            {standared, gold, platinum}
           
      public void ComputePayDeduction()
            {
                Console.WriteLine("the grant is {0}",  400.0);
           }
            } */
        // Property 

        public string Name
        {
            get { return empName; }
            set { //if (Name.Length > 15)
                   // Console.WriteLine("the characters are more than necessary for name so reduce it");
                //else
                    empName = value;
            }
        }


        public int Id
        {
            get { return empID; }
            set { empID = value; }
        }

        public double Pay
        {
            get { return currPay; }
            set { currPay = value; }

        }

        public int Age
        {
            get { return empAge;}
            set { empAge = value;}

        }
        
        public int SSN
        {
            get { return empSSN; } // read-only getter method social security number
        }

         protected BenefitPacakge empbenefits = new BenefitPacakge();  

        /// the above idea is called the aggregation or delegation model , the delegation model
        /// implies that you have an object (here empbenefits) contains in the class employee to
        /// use the functionalities (methods and attributes of the object empbenefits ) you need
        /// delegation which is adding public methods to containing class (here Employee) 
        
        public Employee() { }
        public Employee(string name, int id, double pay, int age, int ssn)
            
            { 
              empName = name;
              empID = id;
              currPay = pay;
              empAge = age;
              empSSN = ssn; 
            }
         
         // There is 2 constructors first constructor is without any parameters and the 
         // second constructor is with paremeters and which is assigned to the attribuites 
         // of the class inside the constructor . 
        
        // Methods

       public virtual void GiveBonous(double amount)

        {
            currPay += amount;

        }

        // This mehtod is polymorhisam to overload the method above by adding it with the keyword virtual

        
        public void DispalyDentalHealthAllowance()
           {
            empbenefits.Dentalallowance();
            }
            //Console.WriteLine("the employee denatl health allowance is {0}", empbenefits);
            // has a relationship is spotted(inheritance) this part is called as delegation a method which is created as to delegate the
            // object (empbenefits) created in the class Employee.  delegation is the idea of
            // creating a public method to use the object (empbenefits) which have methods and
            // attributes . 
            
            

        
        public void DisplayStatus()
        {
            Console.WriteLine("name of the employee is {0}", empName);
            Console.WriteLine("id of the employee is {0}", empID);
            Console.WriteLine(" current pay of the employee is {0}", currPay);
            Console.WriteLine("age of the employee is {0}", empAge);

        }

    }

     class Manager :Employee
        {
          public int stockoptions{get; set;}
         
        // where is the private varibale for the 
       
         
          public Manager(string name, int id, double currentpay, int age, int ssn, int stocknumber)
             :base(name, id, currentpay, age, ssn)
        {
               stockoptions = stocknumber;

           }
        }
     class SalesPerson :Employee
        {
          public int salesnumber{get; set;}
           
          public SalesPerson(string name, int id, double currentpay, int age, int ssn, int sales)
            :base(name, id, currentpay, age, ssn)
            {
                salesnumber = sales;
             }

        public override void GiveBonous(double amount)
        {
            double SalesBonus = 0;
            if(salesnumber <=100)
                {
                SalesBonus = 5;
                
            }
               
               else { 
                    SalesBonus = 20;
                
            }
               
            base.GiveBonous(amount * SalesBonus); 
        }
    }
        
             class BenefitPacakge 
               {
                private int dentalhealth;
                public int Dental
                {
                 get{return dentalhealth;} 
                 set{dentalhealth = value;}

                 }
                public BenefitPacakge()
                {
                  dentalhealth = 500; 
                }
                 
                public void Dentalallowance()
                 {
                   Console.WriteLine("The dental health benefit for an year is {0}", dentalhealth);
                 }
      sealed class PTsalesperson :SalesPerson
            {
             
             //public string workingtime{get; set;}
             private string workingtime;
             public string Wtime
               {
              get{return workingtime;}
              set{workingtime = value;}
                }
             public PTsalesperson(string name, int id, double currentpay, int age, int ssn, int sales, string time)
                    :base(name, id, currentpay, age, ssn, sales)
               {
                  workingtime = time;
               } 
        
            
               
        static void Main(string[] args)
        {
            Employee emp = new Employee("nit", 1, 2000, 29, 11);
            emp.DisplayStatus();
            emp.GiveBonous(1000.12);
            emp.DisplayStatus();
            //Employee.BenefitPacakage mypacakage ;  nested class .
               // mypacakage = new Employee.BenefitPacakage();
               // mypacakage.ComputePayDeduction();
                //emp.mypacakage.ComputePayDeduction();
            //Employee.BenefitPacakage.BenefitPacakgeLevel.myBenefitlevel = Employee.BenefitPacakage.BenefitPacakgeLevel.gold;
                  
                    /// 
            emp.Name = "NitM";
            emp.Id = 0;
            emp.Pay = 4000;
            emp.DisplayStatus();
           
            ///

            Manager manager = new Manager("eddy", 1, 3000, 42, 14, 18);
             manager.DisplayStatus();
             manager.DispalyDentalHealthAllowance(); 
            Console.WriteLine("the stock options is {0}", manager.stockoptions);
            
            ///

            Manager manager1 = new Manager("felix", 2, 3500, 36, 17, 45);
               manager1.DisplayStatus();
               manager1.DispalyDentalHealthAllowance();  
            Console.WriteLine("the stock option for felix is {0}", manager1.stockoptions);

            ///  
            
            SalesPerson salesman = new SalesPerson("jenson", 3, 2200, 40, 09, 100);
            salesman.DisplayStatus();
            Console.WriteLine("the number of stock options is ", salesman.salesnumber);

            ///
            PTsalesperson timesalesperson = new PTsalesperson("selven", 4, 1000, 25, 08, 15, "4 hours");
            timesalesperson.DisplayStatus();
            Console.WriteLine("the work time for part time sales person is", timesalesperson.workingtime);

           
            

            /*
            Manager HeadManager = new Manager();
            HeadManager.Name = "Athul";
            HeadManager.Id = 1;
            HeadManager.Pay = 3000;
            HeadManager.Age = 41;
            HeadManager.stockoptions = 12;


            HeadManager.DisplayStatus();
            Console.WriteLine("The number of stockoptions {0}", HeadManager.stockoptions);
            */



           ///



            


            Console.ReadLine();
        }
    }
  }
}
