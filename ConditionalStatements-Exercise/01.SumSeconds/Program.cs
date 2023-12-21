int firstseconds = int.Parse(Console.ReadLine());
int secondseconds = int.Parse(Console.ReadLine());  
int thirdseconds =  int.Parse(Console.ReadLine());  

int totalseconds = firstseconds + secondseconds + thirdseconds;
int minutes = totalseconds / 60;
int remainseconds = totalseconds % 60;

if (remainseconds < 10)
{
  Console.WriteLine($"{minutes}:0{remainseconds}");
}

else
{
    Console.WriteLine($"{minutes}:{remainseconds}");
}