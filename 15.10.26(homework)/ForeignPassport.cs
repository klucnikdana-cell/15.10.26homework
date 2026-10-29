using System;
using System.Collections.Generic;
using System.Text;

namespace _15._10._26_homework_
{
    internal class ForeignPassport
    {
        private string _passportNumber;
        private string _firstName;
        private string _lastName;
        private DateTime _issueDate;

        public ForeignPassport(string  passportNumber, string firstName, string lastName, DateTime issueDate)
        {
            PassportNumber = passportNumber;
            FirstName = firstName;
            LastName = lastName;
            IssueDate = issueDate;
        }

        public string PassportNumber
        {
            get{ return _passportNumber; }
            set
            {
                if(value != "")
                {
                    _passportNumber = value;
                }
                else
                {
                    Console.WriteLine("Eror with passprot number");
                }
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (value != " ")
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("Eror with name");
                }
            }
        }
        public string LastName
        {
            get{  return _lastName; }
            set
            {
                if( value != " ")
                {
                    _lastName = value;
                }
                else
                {
                    Console.WriteLine("Error with lastname");
                }
            }
        }
        public DateTime IssueDate
        {
            get { return _issueDate; }
            set
            {
                if (value <= DateTime.Now)
                {
                    _issueDate = value;
                }
                else
                {
                    Console.WriteLine("Wrong issue date!");
                }
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"\nPassport number: {PassportNumber}\nFirst name: {FirstName}\nLast name: {LastName}\nIssue date: {IssueDate}");
        }
    }
}
