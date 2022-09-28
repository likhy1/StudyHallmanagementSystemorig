using System;
using System.Data;
using Aspose.Cells;
using System.Io;
using Newtonsoft.Json;

namespace StudyHallmanagementSystem
{ 
    [serializable]
    class Program
    { 

    public static void Main(string[] args)
    {
    StudyHallFile studyHallFile = new StudyHallFile();
    TrackRepository trackRepository = new TrackRepository();
    StudyHallRepository studyHallRepository = new StudyHallRepository();
    Console.WriteLine("Add StudyHall Enter 1 ");
    Console.WriteLine("Delete StudyHall Enter 2 ");
    Console.WriteLine("Serialize All StudyHalls Enter 3 ");
    Console.WriteLine("Display StudyHall in Ascending order Enter 4 ");
    Console.WriteLine("Enter poll ");
    int poll = Convert.ToInt32(Console.ReadLine());
    if (poll == 1)
    {
        Console.WriteLine("Enter StudyHall Details");
        int StudyHallid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter StudyHall Name");
        var StudyHallName = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter No'of StudyHall ");
        int NooftudyHalls = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter StudyHall Location");
        string Location = Console.ReadLine();
    }
    else if (poll == 2)
    {
        Console.WriteLine("Enter Id of StudyHall ");
        int id = Convert.ToInt32(Console.ReadLine());
        string str = studyHallRepository.DeletestudyHall(id);

        Console.WriteLine(str);


    }
    else if (poll == 3)
    {
        List<StudyHallFile> studyHals = trackRepository.sortStudyHallByName(studyHallRepository.AllstudyHallsList());
        Console.WriteLine(studyHalls);

    }
}








}
}
