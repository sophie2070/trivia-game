string[] vragenarray = { };
List<string> vragenlijst = new List<string>();
string[] vragenantwoordarray = { };
List<string> antwoordlijst = new List<string>();
int tries;
string username;

static void main(string[] args)
    {
        Console.ReadLine();
    }
void StartGame()
{
    vragenlijst = new List<string>(vragenarray);
    antwoordlijst = new List<string>(vragenantwoordarray);
    tries = 3;
    Console.WriteLine("welcome to this little game, may i ask for your name?");
    username = Console.ReadLine();
    while(tries > 0 && vragenlijst.Count > 0)
    {
        AskQuestion();
    }

    void AskQuestion()
    {
        Random rnd = new Random();
        int vraagIndex = rnd.Next(0, vragenlijst.Count);
        Console.WriteLine(vragenlijst[vraagIndex]);
        string antwoord = Console.ReadLine();
        if (antwoord.ToLower().Equals(antwoordlijst[vraagIndex].ToLower()))
        {
        
        }
        else
        {
   
        }
        vragenlijst.RemoveAt(vraagIndex);
        antwoordlijst.RemoveAt(vraagIndex);
    }
}