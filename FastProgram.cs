/*
 * This was the first optimized script I made, which cut the time nearly in half.
 * 
 * Sadly, it did this by cutting the sims short when it became impossible to get to 177, which took away the
 * programs original purpose (finding the closest value it got to)

Random rand = new Random();
int[] rolledNumbers = new int[4];

int maxSims = 3000000;
int currentSim = 0;
int highestValue = 0;

while (currentSim < maxSims)
{
    rolledNumbers = new int[4];

    for (int i = 0; i < 231; i++)
    {
        rolledNumbers[rand.Next() % 4] += 1;

        if (rolledNumbers.Max() + (231 - i) < 177)
        {
            break;
        }
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
*/