using System;

public class Progran
{
    
public static void Main(string[] args) 
{
    int userInput = GetNumberInput(); // metoden getNumberInput och ger resultatet för variabeln userInput
    Console.WriteLine(" Du skrev talet" + userInput);
}
public static int GetNumberInput() // metod hämtar tal från användare
{
    int number; // lagrar talet som en  variabel
    bool isCorrectInput = false; // kod för att kolla om de inmatade är fel alltså inte ett tal 
    do
    {
        Console.WriteLine("Skriv in ett tal"); 
        string input = Console.ReadLine(); // läsaer användaren inmatning som en string
        isCorrectInput = int.TryParse(input, out number); // försöka konvertera det inmatade till ett heltal och lagra de i variablen number
    } while (!isCorrectInput); // upprepar koden tills en korrekt inmatning har angetts alltså ett tal
    return number; // ge tillbaks de användaren inmatade om det var ett tal
}
  
}