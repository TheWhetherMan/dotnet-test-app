using static Helpers.StaticHelperMethods;

void Main() {
    Console.WriteLine("STARTING...");

    PrintSomeNumbers();
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    Console.WriteLine(" -> " + keyInfo.Key);

    Console.WriteLine("ENDED!");
}

Main();