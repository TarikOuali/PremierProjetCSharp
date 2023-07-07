using System.Diagnostics;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sw = new Stopwatch();



void CountDown(int start, int step, int interval)
{
    for(int i = start; i != 0; i += step)
    {
        Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} - step {i}");
        Thread.Sleep(interval);
    }
}

//var t1 = Task.Run(() => CountDown(5, -1, 750));
//var t2 = Task.Run(() => CountDown(-15, 1, 250));


//await Task.WhenAll(t1, t2);



await Task.WhenAll(
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750)),
    Task.Run(() => CountDown(5, -1, 750))
    );
var x = 0;
var y = false;
await Task.WhenAll(
    Task.Run(()=> x=1),
    Task.Run(()=> y = true),
    Task.Run(()=> 1),
    Task.Run(()=> 1)
    );
Console.ReadLine();