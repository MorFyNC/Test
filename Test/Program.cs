using FunctionalitySpace;

string input = Console.ReadLine();
string output = "";

foreach (char s in input)
{
    if (s == '(' || s == ')' || s == '[' || s == ']' || s == '{' || s == '}')
    {
        output += s;
    }

}

if (Functionality.CheckOrder(input))
{
    
    Console.WriteLine($"Правильный порядок: {output}");
} 
else
{
    Console.WriteLine($"Неправильный порядок: {output}");
}