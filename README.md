# Tool useful for determining number of thread pool tasks available on your system. 

## DESCRIPTION
```
Simple tool for determining the max number of tasks on your system that you can use for knowing how many thread pool tasks you can create on your system. 
```

## BUILDING CODE
```
Created in C# .NET using Visual Studio 2015
```

## FILE STRUCTURE 

### Application Files
```
Application Files folder has a setup.exe file that you can use to install the program. 
Otherwise you can just drag and drop the files contained inside the bin\debug or bin\release folder to your pc and run it from there. 
```
### Code files

### Source Code 
This is the code that is ran by running this program. 
```
AutoResetEvent mainEvent = new AutoResetEvent(false);
int workerThreads;
int portThreads;

ThreadPool.GetMaxThreads(out workerThreads, out portThreads);
Console.WriteLine("\nMaximum worker threads: \t{0}" +
	"\nMaximum completion port threads: {1}",
	workerThreads, portThreads);

ThreadPool.GetAvailableThreads(out workerThreads,
	out portThreads);
Console.WriteLine("\nAvailable worker threads: \t{0}" +
	"\nAvailable completion port threads: {1}\n",
	workerThreads, portThreads);

Console.WriteLine("Press any key to exit");
Console.Read();
```