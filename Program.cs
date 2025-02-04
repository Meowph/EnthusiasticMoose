﻿//invoking/calling 
using System.Runtime.CompilerServices;

Main();

void Main()
{

//WriteLine specifically allows for the strings to be printed on separate lines
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

// Let the moose speak!
MooseSays("H I, I'M  E N T H U S I A S T I C !");
MooseSays("I really am enthusiastic");

// Ask a question
//invoking/calling the functions
//a ; MUST be added at the end to inform the console (Hey, that's the end of that line of code!)
CanadaQuestion();
EnthusiasticQuestion();
LoveCSharpQuestion();
SecretQuestion();
//  MooseResponse();
}


void CanadaQuestion()
{
  bool isTrue = MooseAsks("Is Canada real?");
  //if true, print this response
  if (isTrue)
  {
    MooseSays("Really? It seems very unlikely.");
  }
  else
  //if false, print this response
  {
    MooseSays("I  K N E W  I T !!!");
  }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}

//bool meaning boolean (the (Y/N))
//MooseAsks is the proposed string question above
//(string question) defines the text being printed as a string. Let/const is NOT used in C# 
bool MooseAsks(string question)
{
  //string interpolation for the proposed question with (Y/N) being one of the answer
    Console.Write($"{question} (Y/N): ");

    //string is used instead of let in C# (shows that the answer will be a string)
    string answer = Console.ReadLine().ToLower();

    //while loop = loop will run until it gets a response

    while (answer != "y" && answer != "n") //if answer is != (not) y or no, the loop will keep running until y or n is entered (cannot be 1, yes, no, I don't know, etc.)
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }
    //if answer == y, print y to console
    if (answer == "y")
    {
        return true;
    }
    else
    //if not answer == y, print n to console
    {
        return false;
    }
}


void MooseSays(string message)
{
  //$ is added in front of @ to enable string interpolation
  //@ was added in front of the string to allow for multi-line string
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

//if question comes back as true, give a yes answer
//if question comes back as false, give a no answer

//Re-factored code to work on later
// void MooseResponse( string question, string yesAnswer, string noAnswer) //We're looking for 3 strings upon execution
// {
//     bool isQuestionTrue = MooseAsks(question);

//     string answer = isQuestionTrue ? yesAnswer : noAnswer;

//     MooseSays(answer);
// }