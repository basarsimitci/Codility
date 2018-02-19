namespace Codility.Lessons.Leader
{
    public class Dominator
    {
        //https://codility.com/demo/results/trainingG95HMN-RWV/
        
        public static int Solution(int[] A)
        {
            int N = A.Length;
            int candidateIndex = -1;
            int candidateCount = 0;
            for (int index = 0; index < N; index++)
            {
                if (candidateIndex == -1)
                {
                    candidateIndex = index;
                    candidateCount = 1;
                }
                else
                {
                    if (A[index] == A[candidateIndex])
                    {
                        candidateCount++;
                    }
                    else
                    {
                        candidateCount--;
                        if (candidateCount == 0)
                        {
                            candidateIndex = -1;
                        }
                    }
                }
            }
        
            if (candidateIndex == -1)
            {
                return -1;
            }
        
            candidateCount = 0;
            for (int index = 0; index < N; index++)
            {
                if (A[index] == A[candidateIndex])
                {
                    candidateCount++;
                }
            }
            if (candidateCount > (N / 2))
            {
                return candidateIndex;
            }
        
            return -1;
        }
    }
}
