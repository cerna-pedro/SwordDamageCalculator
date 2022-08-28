namespace SwordDamageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            SwordDamage swordDamage = new SwordDamage();

            while (true)
            {


                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                char key = Console.ReadKey(false).KeyChar;
                char[] acceptableChar = { '0', '1', '2', '3' };
                if (!acceptableChar.Contains(key))
                {
                    return;
                }
                else
                {
                    swordDamage.Roll = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        swordDamage.Roll+= random.Next(1, 7);
                    }

                    swordDamage.SetMagic(key == '1' || key == '3');
                    swordDamage.SetFlaming(key == '2' || key == '3');
                }
                Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP\n");
            }

        }
    }
}