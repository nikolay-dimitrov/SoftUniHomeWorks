using StudentSystem.Data;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. Using c0de first approach, create database for student system with the following tables:
//Students(with Id, Name, Number, etc.)
//Courses(Name, Description, Materials, etc.)
//StudentsInCourses(many-to-many relationship)
//Homework(one-to-many relationship with students and courses), fields: Content, TimeSent
//Annotate the data models with the appropriate attributes and enable code first migrations

//2. Write a console application that uses the data
//3. Seed the data with random values


namespace StudentSystem.Console
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var dataBase = new StudentSystemContext();

            var course = new Courses { Parent = null, Name = "Database course", Description = "A course that all junior develepers need to pass", Materials  = "Google.com"};
            dataBase.Courses.Add(course);


            var studentOnDataBaseCourse = new Students { Name = "Bill Gates", Number = 1 };

            var homeWorkForDataBases = new Homework { Content = "Introduction in SQL" };

            dataBase.SaveChanges();
        }
    }
}
