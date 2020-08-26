using System; 

public class BusinessLogic
{
    Logger logger = new Logger(); 
    DataAccess dataAccess = new DataAccess();

    Logger.Log("Starting to process data.");
    Console.WriteLine("Processing the data.");

    dataAccess.LoadData(); 
    dataAccess.SavedData("ProcessedInfo");

    logger.Log("Finished processing data.");
}