using System;

namespace lab4ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n
            m, respectiv m,n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la
            tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I
            rezultatul.
             */

            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m");
            int m = int.Parse(Console.ReadLine());

            int[,] A = ReadMatrix(n, m);
            int[,] B = ReadMatrix(m, n);


            ShowMatrix(MultiplyArrays(A, B));



        }

        static int[,] ReadMatrix(int n, int m)
        {
            Console.WriteLine("introduceti elementele arrayului");
            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;
        }

        static void ShowMatrix(int[,] arr)
        {
            foreach (int mat in arr)
            {
                Console.Write(mat + " ");
            }
        }
        //inmultim rand din A cu coloana din B si adunam rezultatele intre ele
        // C[0][0] = A[0][0] * B[0][0] + A[0][1] * B[1][0] + A[0][2] * B[2][0]

        static int[,] MultiplyArrays(int[,] A, int[,] B)
        {
            int nrRanduriA = A.GetLength(0);
            int nrColoaneA = A.GetLength(1);
            int nrRanduriB = B.GetLength(0);
            int nrColoaneB = B.GetLength(1);
            int[,] result = new int[nrRanduriA, nrColoaneB];

            if (nrColoaneA != nrRanduriB)
            {
                Console.WriteLine("Matricele nu se pot inmulti");
                return null;
            }
            else
            {
                //iteram prin randurile A si coloanele B

                for (int i = 0; i < nrRanduriA; i++) //2
                {
                    for (int j = 0; j < nrColoaneB; j++) //2
                    {
                        for (int k = 0; k < nrColoaneA; k++)
                        {
                            result[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }
                return result;
            }

        }
    }
}
