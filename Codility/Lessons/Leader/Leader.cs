using System.Collections.Generic;
using System.Linq;

namespace Codility.Lessons.Leader
{
    public class ArrayLeader
    {
        private readonly int[] attachedArray;
        
        public int Leader { get; private set; }
        public int LeaderCount { get; private set; }
    
        public ArrayLeader(int[] array)
        {
            attachedArray = array;
            Leader = -1;
            LeaderCount = 0;
            FindLeader();
        }
        
        private void FindLeader()
        {
            Leader = -1;
            LeaderCount = 0;

            if (attachedArray != null)
            {
                Stack<int> candidateStack = new Stack<int>();
                foreach (int element in attachedArray)
                {
                    if (candidateStack.Count == 0)
                    {
                        candidateStack.Push(element);
                    }
                    else
                    {
                        if (candidateStack.Peek() == element)
                        {
                            candidateStack.Push(element);
                        }
                        else
                        {
                            candidateStack.Pop();
                        }
                    }
                }
        
                if (candidateStack.Count > 0)
                {
                    int candidate = candidateStack.Peek();
                    int count = attachedArray.Count(element => element == candidate);
                    if (count > (attachedArray.Length / 2))
                    {
                        Leader = candidate;
                        LeaderCount = count;
                    }
                }
            }    
        }
    }
}