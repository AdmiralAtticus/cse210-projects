using System;
<<<<<<< HEAD
=======

class Program{

    static void Main(string[] args)
    {
        
        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 10;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Console.Write("\b");
        // }

        int count = duration;
        while(DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            if(count >= 9)
                Console.Write("\b\b \b\b");
            else
                Console.Write("\b");
            
            

        }
}
}
>>>>>>> 4acb7ba44b389c8508b7e49f3e8f49b4fbd9b7b0
