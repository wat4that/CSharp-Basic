//Input
string nameOfShow = (Console.ReadLine());
int timeEpisode = int.Parse(Console.ReadLine());
int timeBreak =  int.Parse(Console.ReadLine());

//Calculations
double timeForLunch = timeBreak * 1.0/8;
double timeForRelax = timeBreak * 1.0/4;
double totalTime = timeForLunch + timeForRelax + timeEpisode;
double timeLeft = (timeBreak - totalTime);

//Output
if (timeLeft >= 0) 
{
    Console.WriteLine($"You have enough time to watch {nameOfShow} and left with {Math.Ceiling(timeLeft)} minutes free time.");
}
else 
{
    Console.WriteLine($"You don't have enough time to watch {nameOfShow}, you need {Math.Ceiling (-timeLeft)} more minutes.");
}