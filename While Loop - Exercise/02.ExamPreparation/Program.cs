int poorGradesCount = int.Parse(Console.ReadLine());
string lastProblem = "";
int totalProblems = 0;
double totalScore = 0;
int poorGrades = 0;

while (poorGrades < poorGradesCount)
{
    string problemName = Console.ReadLine();

    if (problemName == "Enough")
    {
        break;
    }

    int grade = int.Parse(Console.ReadLine());

    totalProblems++;
    totalScore += grade;
    lastProblem = problemName;

    if (grade <= 4)
    {
        poorGrades++;
    }
}

if (poorGrades == poorGradesCount)
{
    Console.WriteLine($"You need a break, {poorGrades} poor grades.");
}
else
{
    double averageScore = totalScore / totalProblems;
    Console.WriteLine($"Average score: {averageScore:f2}");
    Console.WriteLine($"Number of problems: {totalProblems}");
    Console.WriteLine($"Last problem: {lastProblem}");
}