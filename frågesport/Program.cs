int points = 0;
int questionNum = 0;
string answer1;


string[][] questions = {
    new string[] {"\nFråga 1.\nWhat is Wiggo's name \na) mario \nb) Wiggo \nc) wigo \nd) pytor dragetovich idi nahui", "b"},
    new string[] {"\nFråga 2.\n2+2? \na) 1 \nb) 2 \nc) 8 \nd) 4", "d"},
    new string[] {"\nFråga 3.\näta bajs? \na) nej \nb) på måndagar \nc) ja \nd) hej", "b"}
};

Console.WriteLine("velkomen frågesporrt. Vad ska du heta?");
string name = Console.ReadLine();

Console.WriteLine($"Mina damer och herrar, här har vi {name}!!!! Han svara fråga! Svara genom att skriva a, b, c eller d");
Console.ReadLine();

void askQuestion(string question, string correct){
    answer1 = null;

    do {
    Console.WriteLine(question);
    answer1 = Console.ReadLine().Trim();
    } while (answer1 != "a" && answer1 != "b" && answer1 != "c" && answer1 != "d");

    if (answer1 == correct){
        Console.WriteLine("waow du så smart:)))()");
        points += 1;
    }
    else{
        Console.WriteLine("fel du dålig");
    }

    questionNum += 1;

    if (questionNum >= questions.Count()){
        Console.WriteLine($"\nok får se om du vann eller inte... \n\n{points}");

        if (points == 0){
            Console.WriteLine("wow 0 poäng? du är fan bajs");
        }
        else if (points == questions.Count()){
            Console.WriteLine("full poäng?? bara lite bra");
        }
        else if (points <= questions.Count() / 2 && points >= 1){
            Console.WriteLine($"mindre än hälften? du dålig");
        }
        else if (points >= questions.Count() / 2 && points <= questions.Count()){
            Console.WriteLine("Mer än hälften? helt ok bror tack");
        }

    }
    else {
        askQuestion(questions[questionNum][0], questions[questionNum][1]);
    }
}

askQuestion(questions[questionNum][0], questions[questionNum][1]);


Console.ReadLine();
