// See https://aka.ms/new-console-template for more information
using LINQStudy;
using System;
using System.Collections;

Console.WriteLine("Hello, World!");

//What is LINQ
//full form :-Language Integrated Query.
//library we need - System.LINQ
//with linq we can use with Linq to xml ,Linq to JASON,Linq to objects
//
//select sc from scores where sc > 90
#region LinqIntro
//int[] scores = { 97, 92, 81, 60 };

////Query Experesion
//IEnumerable<int> scoresQuery = from sc in scores where sc > 90 select sc;

////LINQ Methods
//var queryResult = scores.Where(x => x > 90);

//foreach(int score in queryResult)
//{
//    Console.WriteLine(score);
//}
#endregion
//Home Work annonymous function and Lamda experesion in c# we have to read

//1: Where
//2: Select and Select Many
//3: First , FirstOrDefault
//4: Last, LastorDefault
//5: Single and SingleOrDefault
//6: Iquerable and IEnumarable
//7: Lazy loading

#region MasterData
Course obj = new Course()
{
    Id = 1,
    CourseName = "DotNet"

};
Course obj2 = new Course()
{
    Id = 2,
    CourseName = "Java"
};
Course obj3 = new Course()
{
    Id = 3,
    CourseName = "Python"
};
Course obj4 = new Course()
{
    Id = 4,
    CourseName = "React"
};
Course obj5 = new Course()
{
    Id = 5,
    CourseName = "MERN"
};
Course obj6 = new Course()
{
    Id = 6,
    CourseName = "MEAN"
};

Student nil = new Student()
{
    Id = 1,
    Name = "Niles",
    Marks= 95

};
nil.EnrolledCourses.Add(obj);
nil.EnrolledCourses.Add(obj2);


Student rah = new Student()
{
    Id = 2,
    Name = "Rahul",
    Marks = 95
};
rah.EnrolledCourses.Add(obj3);
rah.EnrolledCourses.Add(obj);
Student ak = new Student()
{
    Id = 3,
    Name = "Akash",
    Marks = 95
};
ak.EnrolledCourses.Add(obj4);
ak.EnrolledCourses.Add(obj2);

Student hk = new Student()
{
    Id = 4,
    Name = "Harish",
    Marks = 92
};
hk.EnrolledCourses.Add(obj);
hk.EnrolledCourses.Add(obj5);

Student rk = new Student()
{
    Id = 5,
    Name = "Suraj",
    Marks = 92
};
rk.EnrolledCourses.Add(obj6);
rk.EnrolledCourses.Add(obj4);

Student sk = new Student()
{
    Id = 6,
    Name = "Suraj",
    Marks = 90
};
sk.EnrolledCourses.Add(obj3);
sk.EnrolledCourses.Add(obj5);



List<Student> lstStudent = new List<Student>();
lstStudent.Add(rah);
lstStudent.Add(nil);
lstStudent.Add(ak);
lstStudent.Add(sk);
lstStudent.Add(rk);
lstStudent.Add(hk);


#endregion

#region Where

//var result = lstStudent.Where(x => x.Name.StartsWith('R'));
//foreach (var item in result)
//{

//Console.WriteLine(item.Name);
//}


#endregion


#region Select

//var result = lstStudent.Select(x => x.Name);
//var result1 = lstStudent.Select(x => new {x.Name,x.Id});
//var result = lstStudent.Select(x => x.EnrolledCourses);
//var resultMany = lstStudent.SelectMany(x => x.EnrolledCourses);



//foreach (var item in result)
//{
//    foreach (var cr in item)
//    {
//        Console.WriteLine(cr.CourseName);
//    }
//}
//foreach (var item in resultMany)
//{
//    Console.WriteLine(item.CourseName);
//}

#endregion

#region First
//var result = lstStudent.First(x => x.Name =="Surya");
//var resultFirstOrDefault = lstStudent.FirstOrDefault(x => x.Name == "Surya");
//Last and LastorDefault will bring Last record
//if (resultFirstOrDefault != null)
//{

//Console.WriteLine(resultFirstOrDefault.Name);
//}

#endregion

#region Single
//var result = lstStudent.Single(x => x.Name == "Suraj");
//var resultSingleOrDefault = lstStudent.Single(x => x.Name == "Suraj");


//Console.WriteLine(result.Name);
//Console.WriteLine(resultSingleOrDefault.Name);


#endregion


#region ElementAt
//var result = lstStudent.ElementAt(3);

//Console.WriteLine(result.Name);
#endregion

#region GroupByAndOrderedBy

//var result = lstStudent.GroupBy(x => x.Marks);
var resultOrderById = lstStudent.OrderBy(x => x.Id);

Console.WriteLine();

#endregion

//Home work 
//All or Any
//orderby desending
