using System;

namespace exercise;

class WishSimulator
{
    static Random random = new Random();
    private static int Wish_Count = 0;
    private static int fourstar_pity = 0;
    private static int fivestar_pity = 0;
    private static bool event_pity = false;
    private static string Event_Character = "Citlali";

    static void Main(string[] args)
    {
        Console.WriteLine("How Many Wishes: 1 = one wish, 2 = ten wishes, 3 = end program");
        bool isTerminated = false;

        while (!isTerminated)
        {
            try
            {
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Wish(1);
                        break;
                    case 2:
                        Wish(10);
                        break;
                    case 3:
                        isTerminated = true;
                        break;
                    default:
                        isTerminated = false;
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    private static void Wish(int wishes)
    {
        var pool = exercise.CharacterDictionary.Characters.Values.ToList();

        for (int i = 1; i <= wishes; i++)
        {
            int index = random.Next(pool.Count);
            double baseRate = 0.0006;
            int pity = fivestar_pity;
            ++fourstar_pity;
            ++fivestar_pity;
            ++Wish_Count;

            if (pity >= 74 && pity <= 89)
            {
                baseRate = 0.006 + 0.06 * (pity - 73);
            }
            else if (pity >= 90)
            {
                baseRate = 1.0;
            }

            if (TriggerEvent(baseRate))
            {
                if (TriggerEvent(0.5) || event_pity == true)
                {
                    Console.WriteLine("Wish #" + Wish_Count + " Event 5*: " + Event_Character);
                    fivestar_pity = 0;
                    event_pity = false;
                }
                else
                {
                    Console.WriteLine("Wish #" + Wish_Count + " " + pool[index].ToString());
                    fivestar_pity = 0;
                    event_pity = true;
                }
            }

            else if (TriggerEvent(0.051) || fourstar_pity >= 10)
            {
                Console.WriteLine("Wish #" + Wish_Count + " Random 4*");
                fourstar_pity = 0;
            }

            else
            {
                Console.WriteLine("Wish #" + Wish_Count);
            }
        }
    }

    private static bool TriggerEvent(double luck)
    {
        return random.NextDouble() < luck;
    }
}
