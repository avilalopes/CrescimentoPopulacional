using System; 

class minhaClasse {

    static void Main(string[] args) { 

            Console.WriteLine("Informe o número de casos de teste: ");
            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                Console.WriteLine();
                Console.WriteLine("Informe, respectivamente, a população de A e B, e o crescimento populacional de cada: ");
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);
                cpa = double.Parse(valores[2]);
                cpb =  double.Parse(valores[3]);

                while (pa <= pb)
                {

                  pa += (int)  (pa * cpa/100);
                  pb += (int)  (pb * cpb/100);
                  anos++;

                    if (anos > 100)
                    {
                       Console.WriteLine("Mais de 1 seculo.");
                       break;
                    }
                }
                if (anos <= 100)
                {
                   Console.WriteLine(anos + " anos.");
                }
            }
    }
}
