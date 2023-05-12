using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VB_TheOneAndOnly.BusinessLogic
{
    public class SegmentedDisplay
    {
        public string[] SplitSignal(string signal)
        {
            
            
            string[] parts = signal.Split(('|'));
            string[] signalCombinations = parts[0].Split(' ');
            string[] testSignals = parts[1].Split(' ');

            return signalCombinations;
        }
        
        public string[] SplitSignalInInputSubString(string signal)
        {
            
            
            
            string[] seperated = signal.Split('|');
            return seperated.Take(10).ToArray();


        }
        
        

        public Dictionary<string, int> MapInputSignal(string [] signalInputs)
        {
            Dictionary<string, int> signalMapping = new Dictionary<string, int>();
            
            foreach (string signal in signalInputs)
            {
                int oneSignal = signal.Length;

                if (oneSignal == 2)
                {
                    signalMapping[signal] = 1;
                }
                else if (oneSignal == 3)
                {
                    signalMapping[signal] = 7;
                }
                else if (oneSignal == 4)
                {
                    signalMapping[signal] = 4;
                }
                else if (oneSignal == 5)
                {
                    if (!signalMapping.ContainsValue(2))
                    {
                        signalMapping[signal] = 2;
                    }
                    else if (!signalMapping.ContainsValue(3))
                    {
                        signalMapping[signal] = 3;
                    }
                    else
                    {
                        signalMapping[signal] = 5;
                    }
                }
                else if (oneSignal == 6)
                {
                    if (!signalMapping.ContainsValue(6))
                    {
                        signalMapping[signal] = 6;
                    }
                    else if (!signalMapping.ContainsValue(9))
                    {
                        signalMapping[signal] = 9;
                    }
                    else
                    {
                        signalMapping[signal] = 0;
                    }
                }
                else if (oneSignal == 7)
                {
                    signalMapping[signal] = 8;
                }
            }

            return signalMapping;
        }
            
            
            
            
            
            
            
        

        

        public string CalculateEndNumber(Dictionary<string, int> map, string[] outputSignal)
        {
            StringBuilder sb = new StringBuilder();
            
            
            foreach (string key in outputSignal)
            {
                if (map.ContainsKey(key))
                {
                    string value = map[key].ToString();
                    sb.Append(value);
                }
                else
                {
                    //TODO
                    //LOGGER
                    Console.WriteLine("Invalid Input");
                }
            }


            return sb.ToString();
        }
    }
}     