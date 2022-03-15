using SOLIDPrinciples.DependencyInversion.NonDIP;
using SOLIDPrinciples.DependencyInversion.DIP;
using SOLIDPrinciples.InterfaceSegregation.ISP;
using SOLIDPrinciples.InterfaceSegregation.NonISP;
using SOLIDPrinciples.LiskovSubstitution;
using SOLIDPrinciples.LiskovSubstitution.LSP;
using SOLIDPrinciples.LiskovSubstitution.NonLSP;
using SOLIDPrinciples.OpenClose.NonOCP;
using SOLIDPrinciples.OpenClose.OCP;
using SOLIDPrinciples.SingleResponsibility;
using SOLIDPrinciples.SingleResponsibility.NonSRP;
using SOLIDPrinciples.SingleResponsibility.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single Responibility
            //PresentationNonSRP presentationNonSRP = new PresentationNonSRP();
            //presentationNonSRP.RegisterEmployee();

            //PresentationSRP presentationSRP = new PresentationSRP();
            //presentationSRP.RegisterEmployee();
            #endregion

            #region Open Close
            //PresentationNonOCP presentationNonOCP = new PresentationNonOCP();
            //presentationNonOCP.GetSalaryEmployeeByLevel();

            //PresentationOCP presentationOCP = new PresentationOCP();
            //presentationOCP.GetSalaryEmployeeByLevel();
            #endregion

            #region Liskov Substitution

            /*BaseSalary object(base class) is storing SeniorDeveloperSalary reference (derived class)

             * if BaseSalary object (base class) is storing SeniorDeveloperSalary reference (derived class), then behaviour of base class will be replaced with derived class
             */

            //BaseSalaryNonLSP seniorDevSalary = new SeniorDeveloperSalaryNonLSP(8000000);
            //Console.WriteLine($"Senior Developer Salary : {seniorDevSalary.GetSalary()}");


            //BaseSalaryLSP seniorDevSalary = new SeniorDeveloperSalaryLSP(8000000);
            //Console.WriteLine($"Senior Developer Salary : {seniorDevSalary.GetSalary()}");
            #endregion

            #region Interface Segregation
            //EmployeeServiceNonISP empNonISP = new EmployeeServiceNonISP();
            //empNonISP.InsertData();

            //EmployeeServiceISP empISP = new EmployeeServiceISP();
            //empISP.DeleteData();
            #endregion

            #region Dependency Inversion
            //CustomerBusinessLogic cust = new CustomerBusinessLogic();
            //cust.SelectCustomer();

            //CustomerBusinessLogicDIP cust = new CustomerBusinessLogicDIP();
            //cust.SelectCustomer();
            #endregion

            Console.ReadKey();
        }
    }
}
