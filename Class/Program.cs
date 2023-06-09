using System;
using System.Data;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Widyan Irwadi";
            firstPerson.Age = 29;

            Person secondPerson = new Person
            {
                Name = "Arum Widyanti",
                Age = 22
            };

            // Person.Hello(firstPerson.Name, firstPerson.Age);
            // Person.Hello(secondPerson.Name, secondPerson.Age);

            Rectangle firstRectangle = new Rectangle();
            firstRectangle.height = 10;
            firstRectangle.width = 30;
            // Rectangle.Area(firstRectangle.height, firstRectangle.width);

            BankAccount firstBankAccount = new BankAccount();
            firstBankAccount.AccountNumber = 123;
            firstBankAccount.Balance = 5000;

            // BankAccount.Withdraw(firstBankAccount.Balance, 2000);
            // BankAccount.Deposit(firstBankAccount.Balance, 90000);

            Student firstStudent = new Student();
            firstStudent.Name = "Widyan Irwadi";
            firstStudent.Age = 29;
            double[] Grades = new double[3];
            Grades[0] = 8.5;
            Grades[1] = 9.2;
            Grades[2] = 8.2;

            // Student.AverageGrades(Grades[0], Grades[1], Grades[2]);
            
            Product firstProduct = new Product();
            firstProduct.Name = "01010";
            firstProduct.Price = 100;
            firstProduct.Quantity = 2000;

            double extendedPrice = Product.ExtendedPrice(firstProduct.Price, firstProduct.Quantity);

            // Console.WriteLine("Product Name {0} have Extended Price {1}", firstProduct.Name, extendedPrice);

            Employee firstEmployee = new Employee();
            firstEmployee.Name = "Widyan Irwadi";
            firstEmployee.Position = "Regional System Development Specialist";
            firstEmployee.Salary = 20000000;
            // Employee.NewSalary(firstEmployee.Salary, 20);

            Circle firstCircle = new Circle();
            firstCircle.Radius = 10;

            double circleArea = firstCircle.CalculateArea();
            double circleCircumference = firstCircle.CalculateCircumference();

            // Console.WriteLine(circleArea);

            MathUtils mathUtils = new MathUtils();

            // Metode tanpa static
            int result1 = mathUtils.Multiply(5, 3);
            Console.WriteLine("Multiply Result: " + result1);

            // Metode dengan static
            int result2 = MathUtils.Add(5, 3);
            Console.WriteLine("Add Result: " + result2);
        }
    }
}