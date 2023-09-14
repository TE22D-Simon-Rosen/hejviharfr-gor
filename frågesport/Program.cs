int points = 0;
string answer1;
string answer2;
string answer3;

Console.WriteLine("velkomen frågesporrt. Vad ska du heta?");
string name = Console.ReadLine();

Console.WriteLine($"Mina damer och herrar, här har vi {name}!!!! Han svara fråga! Svara genom att skriva a, b, c eller d");
Console.ReadLine();

do {
    Console.WriteLine("\nFråga 1.\nWhat is Wiggo's name \na) mario \nb) Wiggo \nc) wigo \nd) pytor dragetovich idi nahui");
    answer1 = Console.ReadLine().Trim();
} while (answer1 = );


if (answer1 == "a"){
    Console.WriteLine("fel du dålig :)");
}
else if (answer1 == "b"){
    Console.WriteLine("waow du bra helt rätt");
    points += 1;
}
else if (answer1 == "c"){
    Console.WriteLine("fel du dålig :)");
}
else if (answer1 == "d"){
    Console.WriteLine("fel du dålig :)");
}



Console.ReadLine();
