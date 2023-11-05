// See https://aka.ms/new-console-template for more information
using CollectionStudy;
using System.Collections;

//Console.WriteLine("Hello, World!");

//ArrayList myArrylist = new ArrayList(); 
//myArrylist.Add(1);
//myArrylist.Add("Ranveer");

Student obj = new Student();
obj.Name = "Akash";
obj.Course = "Python";
obj.RollNo = 1;
//myArrylist.Add(obj);


Student obj2 = new Student();
obj2.Name = "Deepak";
obj2.Course = "Java";
obj2.RollNo = 2;

//List<Student> students = new List<Student>();  

//students.Add(obj);
//students.Add(obj2);

//foreach (Student student in students)
//{
//    Console.WriteLine(student.Name);
//}

//Dictionary Study
Dictionary<int , string> myDictionary= new Dictionary<int , string>();
myDictionary.Add(1, "Ranveer");
myDictionary.Add(2, "Akash");
myDictionary.Add(3, "Anshu");
myDictionary.Add(4, "Nilesh");
myDictionary.Add(5, "Rahul");
//foreach (int key in myDictionary.Keys)
//{
//    Console.WriteLine(key);
//}

//Console.WriteLine(myDictionary);

Dictionary<string, Student> myStudentDictionary= new Dictionary<string, Student>();
myStudentDictionary.Add("Key1", obj);
myStudentDictionary.Add("Key2", obj2);

//Console.WriteLine(myStudentDictionary["Key1"].);

Student s1 = myStudentDictionary["Key2"];
Console.WriteLine(s1.Name);
