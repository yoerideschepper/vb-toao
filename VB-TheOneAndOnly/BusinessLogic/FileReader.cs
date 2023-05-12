using System;

namespace VB_TheOneAndOnly.BusinessLogic
{
    public class FileReader
    {
        public string ReadStreamByName(string filename)
        {
            try
            {
                
                // return  System.IO.File.ReadAllText(@"C:\Users\yoeri\RiderProjects\VB-TheOneAndOnly\VB-TheOneAndOnly\DataLayer\stream.txt");
            
            
                // Use a absolute path instead
                return  System.IO.File.ReadAllText($"./../{filename}.txt");
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
    }
}