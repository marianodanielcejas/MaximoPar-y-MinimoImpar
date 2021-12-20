using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximoPar_y_MinimoImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int MaxPar = 0;
            int MinImpar = 0;
            int BanderaPar = 0;
            int BanderaImpar = 0;
            for(int i = 1; i <= 20; i++)
            {
                Console.Write("Ingrese un número positivo por favor: ");
                Num = int.Parse(Console.ReadLine());
                if(Num % 2 == 0)
                {
                    if(BanderaPar == 0)
                    {
                        MaxPar = Num;
                        BanderaPar = 1;
                    }
                    else
                    {
                        if(Num >= MaxPar)
                        {
                            MaxPar = Num;
                        }
                    }
                }
                else
                {
                    if(BanderaImpar == 0)
                    {
                        MinImpar = Num;
                        BanderaImpar = 1;
                    }
                    else
                    {
                        if(Num <= MinImpar)
                        {
                            MinImpar = Num;
                        }
                    }
                }
            }
            Console.WriteLine("El maximo de los Números pares es: {0}", MaxPar);
            Console.WriteLine("El minimo de los Números pares es: {0}", MinImpar);
            Console.Read();
        }
    }
}
