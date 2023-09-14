int points = 0;
int questionNum = 0;
string answer;

string[][] questions = {
    new string[] {"\nWhat is Wiggo's name \na) mario \nb) Wiggo \nc) wigo \nd) pytor dragetovich idi nahui", "b"},
    new string[] {"\n2+2? \na) 1 \nb) 2 \nc) 8 \nd) 4", "d"},
    new string[] {"\näta bajs? \na) nej \nb) på måndagar \nc) ja \nd) hej", "b"},
    new string[] {"\nhur kommer man till odenplan?? \na)gå hem \nb) man gör det inte \nc) det är omöjligt \nd) fråga nån annan", "c"}
};

Console.WriteLine("Svara genom att skriva a, b, c eller d");
Console.ReadLine();

void askQuestion(string question, string correct){
    answer = null;

    do {
    Console.WriteLine($"\nFråga {questionNum + 1}. {question}");
    answer = Console.ReadLine().Trim();
    } while (answer != "a" && answer != "b" && answer != "c" && answer != "d");

    if (answer == correct){
        Console.WriteLine("rätt! waow du så smart:)))()");
        points += 1;
    }
    else{
        Console.WriteLine("fel du dålig");
    }

    questionNum += 1;

    if (questionNum >= questions.Count()){
        Console.WriteLine($"\nok får se om du är bra eller inte... \n\n{points} poäng!");

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
