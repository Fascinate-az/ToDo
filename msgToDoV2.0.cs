public static class msg
{
    public static void Intro()
    {
        Console.WriteLine("Hello!\nWhat do you want to do?");
    }

    public static void ShowMenu()
    {
        Console.WriteLine("[S]ee all TODOs\n[A]dd a TODO\n[R]emove a TODO\n[E]xit");
    }

    public static void SceltaNonValida()
    {
        Console.WriteLine("Scelta non valida, selezionare una delle opzioni disponibili :");
    }

    public static void Exit()
    {
        Console.WriteLine("Uscita in corso ....");
    }

    public static void EnterToDo()
    {
        Console.WriteLine("What do you want to do?");
    }

    public static void ToDoAggiunto(string inputToDo)
    {
        Console.WriteLine($"TODO successfully added : {inputToDo}");
    }

    public static void Empty()
    {
        Console.WriteLine("The description cannot be empty. No TODO is added. ");
    }

    public static void EmptyRemove()
    {
        Console.WriteLine("Selected index cannot be empty.");
    }
    
    public static void ListaVuota()
    {
        Console.WriteLine("“No TODOs have been added yet.");
    }

    public static void PrintLista()
    {
        Console.WriteLine("I ToDo aggiunti sono : ");
    }

    public static void Asterischi()
    {
        Console.WriteLine("****************************");
    }

    public static void NonUnique()
    {
        Console.WriteLine("The description must be unique.");
    }

    public static void ToDoDaRimuovere()
    {
        Console.WriteLine("Select the index of the Todo you want to remove:");
    }

    public static void IndexNotValid()
    {
        Console.WriteLine("The given index is not valid.");
    }

    public static void RimozioneConSuccesso(string itemRemove)
    {
        Console.WriteLine($"{itemRemove} è stato  rimosso con successo");
    }
