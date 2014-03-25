using System.Collections.Generic;

namespace HavelHakimi
{
    public static class HavelHakimi
    {
        /*
        ** http://coddicted.com/the-havel-hakimi-algorithm/
        */
        public static bool isGraphical(List<int> vertices)
        {
            int verticesCount = vertices.Count;

            // First Step
            foreach (var vertice in vertices)
                if (vertice >= verticesCount)
                    return false;

            // Second Step
            int totalOddNumbers = 0;
            foreach (var vertice in vertices)
                if (vertice % 2 == 1)
                    totalOddNumbers++;
            if (totalOddNumbers % 2 == 1)
                return false;

            while (true)
            {
                // Third Step 
                foreach (var vertice in vertices)
                    if (vertice < 0)
                        return false;

                // Fourth Step
                int zeroCount = 0;
                foreach (var vertice in vertices)
                    if (vertice == 0)
                        zeroCount++;
                if (zeroCount == vertices.Count)
                    return true;

                // Fifth Step
                vertices = SelectionSort(vertices);

                // Sixth Step
                int k = vertices[0];

                // Seventh Step
                vertices.RemoveAt(0);

                // Eighth Step
                for (int i = 0; i < k; i++)
                    vertices[i]--;

                // Ninth step
                // go to 3
            }
        }

        private static List<int> SelectionSort(List<int> vertices)
        {
            for (int i = 0; i < vertices.Count - 1; i++)
            {
                int greatest = i;
                for (int j = i + 1; j < vertices.Count; j++)
                    if (vertices[j] > vertices[greatest])
                        greatest = j;
                if (greatest != i)
                {
                    int tmp = vertices[i]; // just for fun http://stackoverflow.com/q/804706/1248177
                    vertices[i] = vertices[greatest];
                    vertices[greatest] = tmp;
                }
            }
            return vertices;
        }
    }
}
