var todoList = new List<string>();

Console.WriteLine("Hello!");

bool isRunning = true;
while (isRunning)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice.ToUpper())
    {
        case "E":
            isRunning = false;
            break;
        case "S":
            PrintTodoList();
            break;
        case "R":
            RemoveTodo();
            break;
        case "A":
            AddTodo();
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}

void PrintTodoList()
{
    if (todoList.Count == 0)
    {
        PrintEmptyListMessage();
        return;
    }

    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}; {todoList[i]}");
    }
}

void AddTodo()
{
    string todo;

    do
    {
        Console.WriteLine("Enter the TODO description:");
        todo = Console.ReadLine();
    }
    while (!IsTodoValid(todo));
    todoList.Add(todo);
}

bool IsTodoValid(string todo)
{
    if (todo == "")
    {
        Console.WriteLine("The description cannot be empty");
        return false;
    }

    if (todoList.Contains(todo))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }
    return true;
}

void RemoveTodo()
{
    if (todoList.Count == 0)
    {
        PrintEmptyListMessage();
        return;
    }

    int index;
    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        PrintTodoList();
    } while (IsIndexValid(out index));

    RemoveTodoAtIndex(index);
}

bool IsIndexValid(out int index)
{
    var userInput = Console.ReadLine();
    
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty");
        return false;
    }
    
    if (int.TryParse(userInput, out index) && index >= 1 && index <= todoList.Count)
    {
        return true;
    }

    Console.WriteLine("Selected index is not valid");
    return false;
}

void RemoveTodoAtIndex(int index)
{
    var target = todoList[index];
    todoList.RemoveAt(index);
    Console.WriteLine("TODO removed: " + target);
}

void PrintEmptyListMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}