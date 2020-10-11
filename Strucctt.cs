using System;
struct Prikol
{
    public string funny_prikol;
    public string not_funny_prikol;
    public Prikol(string funny_prikol, string not_funny_prikol)
    {
        this.funny_prikol = funny_prikol;
        this.not_funny_prikol = not_funny_prikol;
    }
    public void info()
    {
        Console.WriteLine(funny_prikol + " "+ not_funny_prikol);
    }
}