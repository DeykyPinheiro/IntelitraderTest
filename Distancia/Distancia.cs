namespace IntelitraderTest.Distancia
{
    public class Distancia
    {
        public int MenorDistancia(int[] arrayA, int[] arrayB)
        {
            int menor = int.MaxValue;

            for (int i = 0; i < arrayA.Length; i++)
            {
                for (int j = 0; j < arrayB.Length; j++)
                {
                    int distancia = Math.Abs(arrayA[i] - arrayB[j]);
                    if (distancia < menor)
                    {
                        menor = distancia;
                    }
                }
            }
            return menor;
        }
    }
}