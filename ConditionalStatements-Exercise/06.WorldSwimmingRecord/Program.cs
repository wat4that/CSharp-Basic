double recordInSeconds = double.Parse(Console.ReadLine());
double meters = double.Parse(Console.ReadLine());
double secondsInMeters = double.Parse(Console.ReadLine());

double secondsToBeatRecord = meters * secondsInMeters;
double timeSlowDown = Math.Floor(meters / 15);

secondsToBeatRecord += timeSlowDown * 12.5;

if (secondsToBeatRecord < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {secondsToBeatRecord:f2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {secondsToBeatRecord - recordInSeconds:f2} seconds slower.");
}