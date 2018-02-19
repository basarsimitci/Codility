using System.Collections.Generic;

namespace Codility.Lessons.Demo
{
    public class MissingInteger
    {
        public static int Solution(int[] A)
        {
            int maxIntInArray = int.MinValue;
            foreach (int intValue in A)
            {
                if (intValue > maxIntInArray)
                {
                    maxIntInArray = intValue;
                }
            }
            
            Dictionary<int, bool> intIsInArray = new Dictionary<int, bool>();
            foreach (int intValue in A)
            {
                if (intValue > 0)
                {
                    intIsInArray[intValue] = true;
                }
            }
        
            for (int intValue = 1; intValue <= 100000; intValue++)
            {
                if (intIsInArray.ContainsKey(intValue) == false)
                {
                    return intValue;
                }
            }

            return maxIntInArray <= 0 ? 1 : maxIntInArray + 1;
        }
    }
}
