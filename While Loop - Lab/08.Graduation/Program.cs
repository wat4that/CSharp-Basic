string name = Console.ReadLine();

int klass = 1;
int badGrades = 0;
double allGrades = 0;

while (klass <= 12)
{
    double currentGrade = double.Parse(Console.ReadLine());

    if (currentGrade < 4)
    {
        badGrades++;

        if (badGrades == 2)
        {
            Console.WriteLine($"{name} has been excluded at {klass} grade");
            break;
        }
        continue;
    }
    klass++;
    allGrades += currentGrade;
}
if (klass >= 12)
{
    double averageGrades = allGrades / 12;

    Console.WriteLine($"{name} graduated. Average grade: {averageGrades:f2}");
}