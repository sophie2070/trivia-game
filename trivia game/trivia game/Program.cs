using System;

string[] vragenarray = {"hoe heet de game waarbij je ritmisch gitaar speelt\nop een gitaar met verschillende kleuren knoppen?","hoe heet de twitch streamer die populair is geworden door\nhet spelen van winston in profesioneel overwatch?","welke codeer taal heeft een soort slang als icon?","hoe heet de youtuber die zijn vis het heeft laten opnemen\ntegen wallstreetbets om te zien wie meer winst\nzou maken met het traden van stocks?","waar staat de afkorting PP voor dat wordt gebruikt in rhythm games\n om te zien hoeveel punten een song waard is?","hoe heet de band met onder andere de nummers:\nparadise, the scientist en atlas?","benoem het volgende element:\nXe","in welke game speel je als een NB cat persoon\nen is je taak on een lamp naar de be top\nvan een toren te brengen?","wat is de zo gehete powerhouse van een cel?","hoe heet de ziekte waarbij een persoon\nlastig de handen stil kan houden tremoren heeft\nen te weinig dopamine aanmaakt?" };
List<string> vragenlijst = new List<string>();
string[] vragenantwoordarray = {"guitar hero","xqc","python","michael reeves","performance points","coldplay","xenon","oneshot","mitochondria","parkinson" };
List<string> antwoordlijst = new List<string>();
int tries = 3;
string username;

string[] topUi = { "--------------------------------------------------------------", "|░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓▓██░░░░░░░░░░░░░░░░░░░░██▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓████░░░░░░░░░░░░░░░░░░████▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓███████░░░░░░░░░░░░░░░░███████▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░███████░░░░░░░░░░███████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░███████░░░░░░░░███████░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░░████████████████████░░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░██████░░████████░░██████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░██████▓▓░░████████░░▓▓██████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░███████▓▓░░████████░░▓▓███████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░▒▒▒███████████▒▒███████████▒▒▒░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▒▒▒▒▒██████████████████████▒▒▒▒▒░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░█▒▒▒████████████████████████▒▒▒█░░░░░░░░░░░░░░|", "--------------------------------------------------------------"};
string[] bad = { "--------------------------------------------------------------", "|░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓▓██░░░░░░░░░░░░░░░░░░░░██▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓████░░░░░░░░░░░░░░░░░░████▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓███████░░░░░░░░░░░░░░░░███████▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░███████░░░░░░░░░░███████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░███████░░░░░░░░███████░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░░████████████████████░░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░████████████████████████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░████████████████████████████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░██████░░░░░░██████░░░░░░██████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░▒▒▒███████████▒▒███████████▒▒▒░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▒▒▒▒▒██████████████████████▒▒▒▒▒░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░█▒▒▒████████████████████████▒▒▒█░░░░░░░░░░░░░░|", "--------------------------------------------------------------" };
string[] good = { "--------------------------------------------------------------", "|░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓▓██░░░░░░░░░░░░░░░░░░░░██▓▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓▓▓████░░░░░░░░░░░░░░░░░░████▓▓▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▓███████░░░░░░░░░░░░░░░░███████▓░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░████████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░███████░░░░░░░░░░░░███████░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░███████░░░░░░░░░░███████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░███████░░░░░░░░███████░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░░░████████████████████░░░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░░░████████████████████████░░░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░░██████░░████████████░░██████░░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░█████░░██░░████████░░██░░█████░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░░▒▒▒███████████▒▒███████████▒▒▒░░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░▒▒▒▒▒██████████████████████▒▒▒▒▒░░░░░░░░░░░░░░|", "|░░░░░░░░░░░░░░█▒▒▒████████████████████████▒▒▒█░░░░░░░░░░░░░░|", "--------------------------------------------------------------" };

string currentText;

Console.WindowHeight = 24;
Console.WindowWidth = 62;
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.ForegroundColor = ConsoleColor.Blue;
Console.Clear();

StartGame();
    
void StartGame()
{
    vragenlijst = new List<string>(vragenarray);
    antwoordlijst = new List<string>(vragenantwoordarray);
    tries = 3;
    currentText = ("welcome to this little game, may i ask for your name?");
    DisplayText();
    username = Console.ReadLine();
    currentText = ("hello " + username + " after this text you will be presented with a few\nquestions and it is up to you to guess the awnser correct.\nfailing to do so will result in your inpending doom.\nGL! <3");
    DisplayText();
    Console.ReadLine();
    Console.Clear();
    while(tries > 0 && vragenlijst.Count > 0)
    {
        AskQuestion();
        Console.Clear();
    }
    if(tries == 0)
    {
        currentText = ("helaas heb je gefaald\ndit is onacceptabel en vrijwel\nerg teleurstellend van hoe dom je bent\nik hoop dat je de volgende keer het beter doet.\ndruk op enter om opnieuw te spelen");
        DisplayText();
        Console.ReadLine();
        Console.Clear();
        StartGame();
    }
    Console.WriteLine("dat waren alle vragen van deze triva game, goed gedaan");
    Console.ReadLine();

    void AskQuestion()
    {
        Random rnd = new Random();
        int vraagIndex = rnd.Next(0, vragenlijst.Count);
        currentText = (vragenlijst[vraagIndex]);
        for(int i =0; i < topUi.Length; i++ )
        {
            Console.WriteLine(topUi[i]);
        }
        
        DisplayText();
        Console.WriteLine($"\n\nuser: {username}\t\t\tremaining lives: {tries}");
        string antwoord = Console.ReadLine();
        if (antwoord.ToLower().Equals(antwoordlijst[vraagIndex].ToLower()))
        {
            Console.Clear();
            for (int i = 0; i < good.Length; i++)
            {
                Console.WriteLine(good[i]);
            }
            Console.WriteLine("dat is juist");
            Thread.Sleep(2500);
        }
        else
        {
            Console.Clear();
            for (int i = 0; i < bad.Length; i++)
            {
                Console.WriteLine(bad[i]);
            }
            Console.WriteLine("dat is fout");
            tries --;
            Thread.Sleep(2500);
        }
        vragenlijst.RemoveAt(vraagIndex);
        antwoordlijst.RemoveAt(vraagIndex);
    }

    void DisplayText()
    {
        string str = currentText;
        char[] chartext = new char[str.Length];

        for (int i = 0; i < chartext.Length; i++)
        {
            chartext[i] = str[i];
        }

        for (int j = 0; j < chartext.Length; j++)
        {
            Console.Write(chartext[j]);
            Thread.Sleep(25);
        }
    }
}