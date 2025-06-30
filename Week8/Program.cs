// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

Console.WriteLine("Hello, World!");

List<Character> gameobjects = new List<Character>();
gameobjects.Add(new BoxCharacter());
gameobjects.Add(new SphereCharacter());

// a demo of Polymorphism
foreach  (Character character in gameobjects)
{
    character.Move();
}