using System;
using System.Collections.Generic;

namespace VB_TheOneAndOnly.BusinessLogic
{
    public class Stream
    {
        public string ReadStream()
        {
            try
            {
                
                // return  System.IO.File.ReadAllText(@"C:\Users\yoeri\RiderProjects\VB-TheOneAndOnly\VB-TheOneAndOnly\DataLayer\stream.txt");
            
            
                // Use a absolute path instead
                return  System.IO.File.ReadAllText(@".\..\stream.txt");
            }
            catch (Exception e)
            {
                //TODO 
                // Implement custom exception 
                // Implement logging
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            
           


            return null;
        }


       
        
        public int CalculateScore(string stream)
        {
            int score = 0;
            int diepte = 0;
            bool onzin = false;

            for (int i = 0; i < stream.Length; i++) {
                if (onzin) {
                    if (stream[i] == '!') {
                        i++;
                    } else if (stream[i] == '>') {
                        onzin = false;
                    }
                } else {
                    if (stream[i] == '{') {
                        diepte++;
                    } else if (stream[i] == '}') {
                        score += diepte;
                        diepte--;
                    } else if (stream[i] == '<') {
                        onzin = true;
                    }
                }
            }

            return score;
        }
        
        

        public int CalculateScoreOnzin(string stream)
        {
            //TODO
            // add extra onzin score
            throw new NotImplementedException();
        }
        
        
        
        
    }
    }
