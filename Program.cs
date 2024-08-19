Random rand = new Random();
int[] rolledNumbers = new int[4];

int maxSims = 1000000000;
int currentSim = 0;
int highestValue = 0;

while (currentSim < maxSims)
{
    rolledNumbers = new int[4];

    for (int i = 0; i < 231; i++)
    {
        rolledNumbers[rand.Next(0, 4)] += 1;
    }

    int highest = rolledNumbers.Max();

    if (highestValue < highest)
    {
        highestValue = highest;
    }

    currentSim++;
}

Console.WriteLine("Highest Value : " + highestValue);
Console.WriteLine("Simulations : " + maxSims);