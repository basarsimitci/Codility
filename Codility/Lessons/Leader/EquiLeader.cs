namespace Codility.Lessons.Leader
{
    public class EquiLeader
    {
        public static int Solution(int[] A)
        {
            //equi leaders can't be different than the overall leader
            //-> find leader in O(n)
            //iterate over the array again and find slices in which leader is still leader
            int numberOfEquiLeaders = 0;
        
            ArrayLeader arrayLeader = new ArrayLeader(A);
            if (arrayLeader.Leader != -1)
            {
                int leadersInLeftSlice = 0;
                for (int index = 0; index < A.Length; index++)
                {
                    if (A[index] == arrayLeader.Leader)
                    {
                        leadersInLeftSlice++;
                    }
                    if ((leadersInLeftSlice > ((index + 1) / 2)) &&
                        ((arrayLeader.LeaderCount - leadersInLeftSlice) > ((A.Length - (index + 1)) / 2)))
                    {
                        numberOfEquiLeaders++;
                    }
                }
            }
        
            return numberOfEquiLeaders;
        }
    }        
}
