


using System.Numerics;
using System.Reflection.Metadata;

string[] Lanche = { "Cachorro Quente", "X Salada", "X Bacon", "Torrada", "Refrigerante" };

for (int i = 0; i < Lanche.Length; i++)
{
    Console.WriteLine($"{i + 1}. {Lanche[i]}");


}
Console.WriteLine("------------");

Console.WriteLine("Digite o número");
int  codigo = Convert.ToInt16( Console.ReadLine());

Console.WriteLine("Digite a quantidade");
int quantidade = Convert.ToInt16(Console.ReadLine());

Double Total;


if (codigo == 1)
{
    Total = quantidade * 4.00;
    Console.WriteLine("Total: R$ " + Total);

}


else if (codigo == 2)
{
    Total = quantidade * 5.00;
    Console.WriteLine("Total: R$ " + Total);
}


else if (codigo == 3)
{
    Total = quantidade * 5.00;
    Console.WriteLine("Total: R$ " + Total);
}

else if (codigo == 4)
{
    Total = quantidade * 2.00;
    Console.WriteLine("Total: R$ " + Total);
}

else if (codigo == 5)
{
    Total = quantidade * 1.50;
    Console.WriteLine("Total: R$ " + Total);
}





