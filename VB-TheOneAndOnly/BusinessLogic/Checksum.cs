using System;
using System.Linq;
using System.Text;
namespace VB_TheOneAndOnly.BusinessLogic
{
    public class Checksum
    {
        public string returnData()
        {
            return "test";
        }

        public int sum(int a, int b)
        {
            return a + b;
        }



        public int CalculateChecksum(int[] input)
        {
            
            int checkum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[(i + 1) % input.Length])
                {
                    checkum += input[i];
                   
                   
                }
            }
            return checkum;
        }
        
        public int[] FromStringToIntArray(string input)
        {
            return input.Select(c => int.Parse(c.ToString())).ToArray();
        }
        
        public int CalculateChecksumByHalf(int[] input)
        {
            
            int checkum = 0;
            int half = input.Length / 2;
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[(i + half) % input.Length])
                {
                    checkum += input[i];
                    
                }
            }
            return checkum;
        }
    }
}