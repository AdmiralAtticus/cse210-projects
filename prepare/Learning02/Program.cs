using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("REColorado", "Software Developer", 2017, 2033);



        Job job2 = new Job("Melaleuca", "Computer Engineer", 2015, 2022);


        Resume myResume = new Resume();
        myResume._name = "J Dee";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}