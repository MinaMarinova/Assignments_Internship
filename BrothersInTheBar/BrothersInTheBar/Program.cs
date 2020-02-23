using System;

namespace BrothersInTheBar
{
    class Program
    {
        static void Main(string[] args)
        {
            const string outputString = "brothersInTheBar(glasses) = ";
            const string errorInputMessage = "The input was not in a correct format!";
            int maxNumberOfRounds = 0;
            bool areThreeGlassesTheSame = false;

            string[] input = Console.ReadLine().Split(", ");
            int[] glasses = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                int currentGlassSize;
                if (int.TryParse(input[i], out currentGlassSize))
                {
                    glasses[i] = currentGlassSize;
                }
                else
                {
                    Console.WriteLine(errorInputMessage);
                    return;
                }
            }

            if (glasses.Length < 3)
            {
                Console.WriteLine($"{outputString}{maxNumberOfRounds}");
                return;
            }

            //Iterate through every single glass to make a comparison
            for (int i = 0; i <= glasses.Length - 3; i++)
            {
                //Loop to check if the given glass is the same size as the next two
                for (int j = 1; j < 3; j++)
                {
                    if (glasses[i] != glasses[i + j])
                    {
                        areThreeGlassesTheSame = false;
                        break;
                    }

                    areThreeGlassesTheSame = true;
                }

                if (areThreeGlassesTheSame)
                {
                    maxNumberOfRounds += 1;

                    //Loop 3 times to move the three empty glasses at the beginning of the array
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = i + 2; j >= 0; j--)
                        {
                            if (j > 0)
                            {
                                glasses[j] = glasses[j - 1];
                            }
                        }
                    }

                    //Set the value of the removed glasses to zero
                    glasses[0] = 0;
                    glasses[1] = 0;
                    glasses[2] = 0;
                }
            }

            Console.WriteLine($"{outputString}{maxNumberOfRounds}");
        }
    }
}
