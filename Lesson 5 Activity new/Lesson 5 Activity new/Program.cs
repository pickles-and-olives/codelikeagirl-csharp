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
    Console.WriteLine("Students - View student names");
    Console.WriteLine("Courses - View courses available");
    Console.WriteLine("Current Enrollment - View what students are currently enrolled in courses");
    Console.WriteLine("Enrol - Enrol student in a course");
    Console.WriteLine("Unenrol - Unenrol student from a course");
    Console.WriteLine("Cancel - Type Cancel to exit this menu");

var userInput = Console.ReadLine();

if (userInput == "Cancel")
{
    break;
}
{
    switch (userInput)

    {
        case "Students":
            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
            break;

        case "Courses":
            foreach(var course in courses)
            {
                Console.WriteLine(course);
            }
            break;

        case "Current Enrollment":
            Console.WriteLine("Current student enrollment in courses: ");

            Console.WriteLine("Melissa: ");
            foreach(var course in coursesOfMelissa)
            {
                Console.WriteLine(course);
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
            
        case "Enrol":
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
            break;

        default:
			Console.WriteLine("I didn't recognise that command");
			break;

        }
    }
}


