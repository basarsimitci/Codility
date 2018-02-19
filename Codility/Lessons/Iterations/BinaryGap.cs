namespace Codility.Lessons.Iterations
{
    public class BinaryGap
    {
        public static int Solution(int N)
        {
            int value = N;
            int gapLength = 0;
            int maxGapLength = 0;
            bool inGap = false;
            
            while (value > 0)
            {
                if ((value & 1) == 1)
                {
                    if (inGap)
                    {
                        //end of gap
                        if (gapLength > maxGapLength)
                        {
                            maxGapLength = gapLength;
                        }
                    }

                    //this is also possible start of next gap
                    inGap = true;
                    gapLength = 0;
                }
                else
                {
                    if (inGap)
                    {
                        gapLength++;
                    }
                }

                value >>= 1;
            }

            return maxGapLength;
        }
    }
}