int alimentos = 0; 
int distribuidos = 0; 
int qntsPicaPau = 0;
int qntsRaposinha = 0;
int loops = 1;

Console.WriteLine("----- Esperto contra sabido -----\n");
Console.Write("Quantos alimentos serão distribuídos? ");
alimentos = Convert.ToInt32(Console.ReadLine());

while (distribuidos < alimentos)
{
    Console.Write($"{loops} para você");
    distribuidos++;
    qntsPicaPau++;

    if (distribuidos < alimentos) 
    {
        for (int i = 1; i <= loops && distribuidos < alimentos; i++)
        {
            Console.Write($", {i}");
            distribuidos++;
            qntsRaposinha++;
        }

        Console.WriteLine(" para mim.");

        loops++;
    }   
    else
    {
        Console.WriteLine(".\n");
    }
}

Console.WriteLine($"Pica-Pau recebeu {qntsPicaPau} alimento(s)");
Console.WriteLine($"Raposinha recebeu {qntsRaposinha} alimento(s)");