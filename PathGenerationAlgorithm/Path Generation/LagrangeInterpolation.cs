namespace Path_Generation
{
    internal class LagrangeInterpolation
    {
        public static T Interpolate<T>(float[] A, float[] B, T x)
        {
            T result = default(T);
            if (typeof(T) == typeof(float))
            {
                float a = (float)(object)x;
                result = (T)(object)Calculate(A, B, a);
            }
            return result;
        }

        public static T[] InterpolateAll<T>(float[] A, float[] B, T[] x)
        {
            T[] result = new T[x.Length];
            if (typeof(T) == typeof(float))
            {
                for (int i = 0; i < x.Length; i++)
                {
                    float a = (float)(object)x[i];
                    result[i] = (T)(object)Calculate(A, B, a);
                }
                return (T[])(object)result;
            }
            return default(T[]);
        }

        private static float Calculate(float[] A, float[] B, float x)
        {
            int N = A.Length;
            float result = 0.0f;
            for (int i = 0; i < N; i++)
            {
                float p = 1;
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        p *= ((x - A[j]) / (A[i] - A[j]));
                    }
                }
                result += p * B[i];
            }
            return result;
        }
    }
}
