using Generics;

Store<Student> students = new Store<Student>();
students.Add(new Student { Id = 1, Name = "Malak" });
students.Add(new Student { Id = 2, Name = "Ahmed" });
students.Add(new Student { Id = 3, Name = "Menna" });
students.Add(new Student { Id = 4, Name = "Sama" });
students.Add(new Student { Id = 5, Name = "Jana" });

Store<Course> courses = new Store<Course>();
courses.Add(new Course { Id = 1, Title = "C#", Price = 1000 });
courses.Add(new Course { Id = 2, Title = "Python", Price = 900 });
courses.Add(new Course { Id = 3, Title = "Java", Price = 700 });

var student = students.GetById(1);
Console.WriteLine($"Student: {student?.Name}");

var course  = courses.GetById(2);
Console.WriteLine($"Course: {course?.Title}");

try
{
    students.Add(new Student { Id = 1, Name = "Hana" });
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Page 2:");

foreach (var item in students.GetAll().Page(2,2))
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}

var courseList = new List<Course>
{
    new Course { Id = 10, Title = "ASP.NET", Price = 1500 },
    new Course { Id = 20, Title = "Docker", Price = 900 },
    new Course { Id = 30, Title = "Git", Price = 500 }
};

var foundCourse = courseList.FindById(20);

Console.WriteLine($"Found course: {foundCourse?.Title}");

// var invalidStore = new Store<string>(); // must NOT compile