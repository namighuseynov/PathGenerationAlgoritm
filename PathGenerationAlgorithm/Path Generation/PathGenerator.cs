using System.Diagnostics;

namespace Path_Generation
{
    internal class PathGenerator
    {
        public float maxDistance = 100f;
        public float bias = 30f;
        public float minDistanceBetweenPoint = 15f;

        public PathGenerator(float maxDistance, float bias, float minDistanceBetweenPoint)
        {
            this.maxDistance = maxDistance;
            this.bias = bias;
            this.minDistanceBetweenPoint = minDistanceBetweenPoint;
        }

        public float[] GenerateRandomPoints(int N, float S, float d)  //N: Count, S: Sum of these points, d distance between points 
        {
            while(true)
            {
                bool check = true;
                Random random = new Random();
                float[] randomNumbers = new float[N];
                for (var i = 0; i < N; i++)
                {
                    randomNumbers[i] = random.Next();
                }
                float magnitude = 0;
                for (var i = 0; i < N; i++)
                {
                    magnitude += randomNumbers[i];
                }
                for (int i = 0; i < N; i++)
                {
                    randomNumbers[i] = (randomNumbers[i] / magnitude) * maxDistance;
                }
                Array.Sort(randomNumbers);
                for (int i = 0; i < N - 1; i++)
                {
                    if ((randomNumbers[i+1] - randomNumbers[i]) < d) { 
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    return randomNumbers;
                }
            }
        }

        public void DrawPath()
        {

        }
    }
}
