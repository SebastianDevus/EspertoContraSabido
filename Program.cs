int alimentos;
int distribuidos = 0;
int loops = 1;

Console.WriteLine("----- Esperto contra sabido -----\n");
Console.Write("Quantos alimentos serão distribuídos? ");
alimentos = Convert.ToInt32(Console.ReadLine());

while (alimentos > distribuidos)
{
    Console.Write($"{loops} para você, ");
    distribuidos++;

    Console.Write($"1");
    distribuidos++;

    if (loops > 1)
    {
        for (int i = 2; i <= loops && distribuidos < alimentos; i++)
        {
            Console.Write($", {i}");
            distribuidos++;
        }
    }

    Console.WriteLine(" para mim.");

    loops++;
}