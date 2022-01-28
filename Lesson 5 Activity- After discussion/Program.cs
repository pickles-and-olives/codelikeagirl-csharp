// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

//initialise list of students
var students = new List<String>{"Melissa", "William", "Frances", "Mark", "Rebecca", "Catherine"};

//initialise list of courses
var courses = new List<String>{"HTML", "CSS", "Python", "C#", "JavaScript"};

//make array for current enrollment
var currentEnrollment = new List<String>{};

//list of courses students currently enrolled in (needs to be editable)
var coursesOfMelissa = new List<String>{"C#", "Python", "JavaScript"};

var coursesOfWilliam = new List<String>{"Python", "JavaScript"};

var coursesOfFrances = new List<String>{"HTML", "CSS", "Python"};

var coursesOfMark = new List<String>{"Python", "HTML"};

var coursesOfRebecca = new List<String>{"HTML"};

var coursesOfCatherine = new List<String>{"HTML", "CSS"};

var courseToEnroll = new List<String>{"HTML", "CSS", "Python", "C#", "JavaScript"};


while(true)
{   Console.WriteLine("What would you like to do using this program?");
    Console.WriteLine("Please type your answer from the following list: ");
    Console.WriteLine("1 - View student names");
    Console.WriteLine("2 - View courses available");
    Console.WriteLine("3 - View what students are currently enrolled in courses");
    Console.WriteLine("4 - Enrol a new student at the school");
    Console.WriteLine("5 - Unenrol a student from the school");
    /*Console.WriteLine("Enrol - Enrol student in a course");
    Console.WriteLine("Unenrol - Unenrol student from a course"); */

    Console.WriteLine("0 - To exit this menu");

var userInput = Console.ReadLine();

if (userInput == "0")
{
    break;
}
{
    switch (userInput)

    {
        case "1":
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            break;

        case "2":
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }
            break;

        case "3":
            Console.WriteLine("Current student enrollment in courses: ");

            Console.WriteLine("Melissa: ");
            foreach(var course in coursesOfMelissa)
            {
                Console.WriteLine(courses);
            }

            Console.WriteLine("William: ");
            foreach(var course in coursesOfWilliam)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Frances: ");
            foreach(var course in coursesOfFrances)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Mark: ");
            foreach(var course in coursesOfMark)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Rebecca: ");
            foreach(var course in coursesOfRebecca)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Catherine: ");
            foreach(var course in coursesOfCatherine)
            {
                Console.WriteLine(course);
            }
            break;

         case "4":
         Console.WriteLine("Please enter the name of the new student to enrol: ");
         var newStudent = Console.ReadLine();
         students.Add(newStudent!);
         break;

         case "5":
         Console.WriteLine("Please enter the name of the existing student you wish to unenrol from the school: ");
         var removeStudent = Console.ReadLine();
         students.Remove(removeStudent!);
         break;
            
        /* case "Enrol":
            Console.WriteLine("Which student would you like to enrol in a course? ");
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            var studentToEnrol = Console.ReadLine();

            Console.WriteLine("Which course would you like to enrol them in? ");
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }
            var courseToEnrol = Console.ReadLine();
            // coursesOf{studentToEnrol}.Add(courseToEnrol);
            break;


        case "Unenrol":
            Console.WriteLine("Which student would you like to unenrol from a course? ");
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            var studentToUnenrol = Console.ReadLine();

            Console.WriteLine("Which course would you like to unenrol them from? ");
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }
            var courseToUnenrol = Console.ReadLine();
            break; */

        default:
			Console.WriteLine("I didn't recognise that command");
			break;

        }
    }
}


