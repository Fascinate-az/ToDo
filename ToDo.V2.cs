public static class App
{
    public static void Run(List<string>listaTodo)
    {
        Menu.ShowMenu(listaTodo);
    }
}

public static class Menu
{
    public static void ShowMenu(List<string>listaTodo)
    {
        msg.Intro();
        while (true)
        {
            msg.ShowMenu();
            
             GestioneOpzioni.Switch(Input.readInput(), listaTodo);
             msg.Asterischi();
             
            
            
        }
        
    }
}

public static class Input
{
    public static string readInput()
    {
        string input = Console.ReadLine();
        return input;
    }

    public static int CheckIntTryParse(List<string> listaTodo)
    {
        int input;
        string stringaInserita = " ";
        while (!int.TryParse(stringaInserita = Console.ReadLine(), out input))
        {
            if (string.IsNullOrWhiteSpace(stringaInserita))
            {
                msg.EmptyRemove();
            }
            else
            {
                msg.SceltaNonValida();
                
            }
            GestioneToDo.PrintToDo(listaTodo); 
        }

        return input;
    }
}

public static class GestioneOpzioni
{
    public static void Switch(string input,List<string>listaTodo)
    {
        switch (input.ToUpper())
        {
            case "S":
                msg.PrintLista();
                GestioneToDo.PrintToDo(listaTodo);
                break;
            case "A":
                GestioneToDo.Add(listaTodo);
                break;
            case "R":
                GestioneToDo.MenuRemove(listaTodo);
                break;
            case "E":
                ExitApp.Exit();
                break;
            default:
                msg.SceltaNonValida();
                break;
            
        }
    }
}

public static class ExitApp
{
    public static void Exit()
    {
        msg.Exit();
        Environment.Exit(0);
    }
}

public static class GestioneToDo
{
    
    public static void Add(List<string>listaTodo)
    {
        msg.EnterToDo();
        string addToDo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(addToDo))
        {
            msg.Empty();
        }
        else if (listaTodo.Contains(addToDo.ToLower()))
        {
            msg.NonUnique();
        }
        else
        {
            listaTodo.Add(addToDo.ToLower());
            msg.ToDoAggiunto(addToDo);
        }
        
    }

    

    public static void PrintToDo(List<string> listaTodo)
    {
        if (listaTodo.Count < 1)
        {
            msg.ListaVuota();
        }
        else
        {

            for (int i = 0; i < listaTodo.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listaTodo[i]}");
            }
        }
    }

    public static void MenuRemove(List<string> listaTodo)
    {
        if (listaTodo.Count < 1)
        {
            msg.ListaVuota();
        }
        else
        {
            GestioneToDo.PrintToDo(listaTodo);
            msg.ToDoDaRimuovere();
            RemoveToDo(listaTodo);
        }
    }

    public static void RemoveToDo(List<string> listaTodo)
    {
        int input = Input.CheckIntTryParse(listaTodo);
       
        if (input < 1 || input > listaTodo.Count  )
        {
            msg.IndexNotValid();
            GestioneToDo.MenuRemove(listaTodo);
        }
        else
        {
            msg.RimozioneConSuccesso(listaTodo[input-1]);
            listaTodo.Remove(listaTodo[input-1]);
           
        }
        
        
    }
}
