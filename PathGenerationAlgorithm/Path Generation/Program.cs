// See https://aka.ms/new-console-template for more information
using Path_Generation;

PathGenerator pathGenerator = new PathGenerator(100, 30, 10);

    var randomNumbers = pathGenerator.GenerateRandomPoints(4, 100, 15);
    //Console.WriteLine(randomNumbers);
    foreach (var randomNumber in randomNumbers) Console.WriteLine(randomNumber);


