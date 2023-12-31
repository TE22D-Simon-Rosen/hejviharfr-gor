﻿int points = 0;
int questionNum = 0;
string answer;

var random = new Random();

//Creates an array of questions with their answers. Makes it much easier to use a question and to check if the player's answer is correct
//Also makes it a lot easier to add a question
string[][] questions = {
    new string[] {"\nWhat is Wiggo's name \na) mario \nb) Wiggo \nc) wigo \nd) pytor dragetovich idi nahui", "b"},
    new string[] {"\n2+2? \na) 1 \nb) 2 \nc) 8 \nd) 4", "d"},
    new string[] {"\ngå o lägg dig bror \na) nej \nb) bara på måndagar \nc) ja \nd) hej", "b"},
    new string[] {"\nhur kommer man till odenplan?? \na)gå hem \nb) man gör det inte \nc) det är omöjligt \nd) fråga nån annan", "c"}
};

//Randomizes the questions
questions = questions.OrderBy(x => random.Next()).ToArray();

Console.WriteLine("Svara genom att skriva a, b, c eller d");
Console.ReadLine();


//The actual quiz game. Uses an integer to select the question and the answer it should be checking for (question & correct)
void askQuestion(string question, string correct)
{
    answer = null;


    //Asks the question and reads the player's answer. Repeats if the player's input isn't a, b, c or d
    do
    {
        Console.WriteLine($"\nFråga {questionNum + 1}. {question}");
        answer = Console.ReadLine().Trim().ToLower(); //Saves the answer and removes whitespaces before and after the actual answer
    } while (answer != "a" && answer != "b" && answer != "c" && answer != "d");

    if (answer == correct)
    {
        Console.WriteLine("\nrätt! waow du så smart:)))()");
        points += 1;
    }
    else
    {
        Console.WriteLine("fel du dålig");
    }

    questionNum += 1;


    //Ends the game if questionNum is bigger than the amount of questions 
    if (questionNum >= questions.Count())
    {
        Console.WriteLine($"\nok får se om du är bra eller inte... \n\n{points} poäng!");

        if (points == 0)
        {
            Console.WriteLine("wow 0 poäng? du är fan bajs");
        }
        else if (points == questions.Count())
        {
            Console.WriteLine("full poäng?? bara lite bra");
        }
        else if (points <= questions.Count() / 2 && points >= 1)
        {
            Console.WriteLine($"mindre än hälften? du dålig");
        }
        else if (points >= questions.Count() / 2 && points <= questions.Count())
        {
            Console.WriteLine("Mer än hälften? helt ok bror tack");
        }
    }
    else
    {
        //Continues if it isn't
        askQuestion(questions[questionNum][0], questions[questionNum][1]);
    }
}

//Asks the first question
askQuestion(questions[questionNum][0], questions[questionNum][1]);


Console.ReadLine();
