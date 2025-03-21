using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

string[] students = ["Caio", "Maria", "Gabriel", "Olivia"];
int examAssignments = 5;
Random random = new Random();

Console.WriteLine("Student \tGrade ");
foreach (var student in students)
{
    double resultExam1 = random.Next(0, 101);
    double resultExam2 = random.Next(0, 101);    
    double resultExam3 = random.Next(0, 101);
    double resultExam4 = random.Next(0, 101);    
    double resultExam5 = random.Next(0, 101);


    //Console.WriteLine($"{resultExam1} {resultExam2} {resultExam3} {resultExam4} {resultExam5}");

    double sumResultExam = resultExam1 + resultExam2 + resultExam3 + resultExam4 + resultExam5;
    double creditStudent = sumResultExam * 0.1;
    double sumResultTotal = sumResultExam + creditStudent;
    /*Console.WriteLine(sumResultExam);
    Console.WriteLine(creditStudent);
    Console.WriteLine(sumResultTotal);*/

    var calcAverage = sumResultTotal/examAssignments;

    string nota;
    if (calcAverage >= 97.0){
        nota ="A+";
    }
    else if (calcAverage >= 93.0){
        nota = "A";
    }
    else if (calcAverage >= 90.0){
        nota = "A-";
    }
    else if (calcAverage >= 87.0){
        nota = "B+";
    }
    else if (calcAverage >= 83.0 ){
        nota = "B";
    }
    else if (calcAverage >= 80.0){
        nota = "B-";
    }
    else if (calcAverage >= 77.0){
        nota = "C+";
    }
    else if (calcAverage >= 73.0){
        nota = "C";
    }
    else if (calcAverage >= 70.0){
        nota = "C-";
    }
    else if (calcAverage >= 67.0){
        nota = "D+";
    }
    else if (calcAverage >= 63.0){
        nota = "D";
    }
    else if (calcAverage >= 60.0){
        nota = "D-";
    }
    else 
        nota = "F";

    Console.WriteLine($"{student}\t\t{calcAverage:F2}\t{nota}");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();


