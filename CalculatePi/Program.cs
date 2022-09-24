var factor = 1M;
decimal fourthOfPI = 0;

for (decimal denominator = 1; denominator < decimal.MaxValue - 2; denominator += 2)
{
    fourthOfPI = fourthOfPI + (factor * (1M / denominator));
    factor = factor * -1;

    Console.WriteLine(fourthOfPI*4);
}
