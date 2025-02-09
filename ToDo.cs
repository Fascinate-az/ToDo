ist<string> toDo = new List<string>();

Console.WriteLine("Hello!");
Start();

void Start()
{
    string userInput;
    do
    {
        Console.WriteLine("Cosa vuoi fare?\n[S]ee all todos\n[A]dd a todo\n[R]emove a todo\n[E]xit");
        userInput = Console.ReadLine().ToUpper();
        switch (userInput)
        {
            case "S":
                SeeToDo();
                break;
            case "A":
                AddToDo();
                break;
            case "R":
                Remove();
                break;
            case "E":
                Exit();
                break;
            default:
                Console.WriteLine("invalid input");
                break;
        }
    } while (userInput != "E");//userInput != "S" && userInput != "R" && userInput != "E"

}

void Exit()
{
    Environment.Exit(0);
}

void AddToDo()
{
    string add;
    bool loop = true;
    do {
        Console.WriteLine("Enter a ToDo description");
        add = Console.ReadLine().ToLower();
        
        if (string.IsNullOrEmpty(add))
        {
            Console.WriteLine("The list cannot be empty");
        }

        if (toDo.Contains(add))
        {
            Console.WriteLine("toDo gia inserito");
            
        }
        else
        {
            toDo.Add(add);
            loop = false;
        }
        
        
    } while (loop);
    
    
}

void SeeToDo()
{
    int counter = 1;
    if (toDo.Count == 0)
    {
        Console.WriteLine("La lista è vuota");
        Start();
    }

    else
    {
        foreach (var item in toDo)
        {
            Console.WriteLine($"{counter}.{item}");
            counter++;
        }
    }
    
    
    
}
void Remove()
{
    Console.WriteLine("Selezionare il toDo da rimuovere");
    
    SeeToDo();
    string verificaInput = Console.ReadLine();
    if (string.IsNullOrEmpty(verificaInput))
    {
        Console.WriteLine("il campo non può essere vuoto");
        Start();
    }
    
        
    
    if ((int.TryParse(verificaInput, out int rimuovere) &&rimuovere > 0 && rimuovere -1 < toDo.Count))
    {                                 
        toDo.RemoveAt(rimuovere - 1);
        Console.WriteLine("rimozione completata");
        Start();
    }

    
    else
    {
        Console.WriteLine("Input non valido");
        Remove();
    }
        
}
