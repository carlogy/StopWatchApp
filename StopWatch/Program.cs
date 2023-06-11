
namespace StopWatchApp;
class Program
{
    static void Main(string[] args)
    {
        StopWatch.Start();        
        Console.WriteLine("Starting Stopwatch");
        Console.Write("Stopped stopwatch. Elapsed time: ");
        StopWatch.Stop();


        StopWatch.Start();
        Console.WriteLine("Starting Stopwatch");
        Console.Write("Stopped stopwatch. Elapsed time: ");
        StopWatch.Stop();
        Console.Read();


    }
}

public  class StopWatch
{

    public static bool _startCalled { get; set; }

    public static DateTime startingTime;
    public static DateTime endingTime;

    public static DateTime Start() {

        if (_startCalled) {         
            throw new InvalidOperationException("Stopwatch already initialized, Stop before trying to intiate again.");
        }

        startingTime = DateTime.Now;
        return startingTime;
        

    }


    public static  TimeSpan Stop() {

        endingTime = DateTime.Now;
        _startCalled = false;

       
        TimeSpan ellapsedTime = endingTime - startingTime; 


        Console.WriteLine(ellapsedTime.Milliseconds);
        return (ellapsedTime);
    }



}



