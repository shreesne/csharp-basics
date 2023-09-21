// See https://aka.ms/new-console-template for more information
using MethodNew.Assignments;

Console.WriteLine("Hello, World!");
Console.WriteLine();
Assignment1.GetUserInput1();
Assignment2.GetUserInput2();
Assignment3.startAssignment3();
Assignment4.startAssignment4();
//Assignment5.startAssignment5();
string firstName = "Thomas";
string lastName = "Payne";
Assignment5 assignment5 = new Assignment5();
string userText4 = assignment5.GetUserInputs(firstName, lastName);
//string userText4 = Assignment5.GetUserInputs(firstName, lastName);
Console.WriteLine("Expected outcome :" + userText4);