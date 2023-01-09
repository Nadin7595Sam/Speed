Console.Clear();

int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int distance = 100;
int friend = 2;
int count = 0;

Console.WriteLine();

while (distance > 10)
{
    int time = 0;
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        Console.Write("time = ");
        Console.WriteLine(time);
    }
    else
        time = distance / (secondFriendSpeed + dogSpeed);
        Console.Write("time = ");
        Console.WriteLine(time);

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    Console.Write("distance = ");
    Console.WriteLine(distance);
    Console.WriteLine();
    count++;
}

Console.Write("count = ");
Console.WriteLine(count);
Console.WriteLine();