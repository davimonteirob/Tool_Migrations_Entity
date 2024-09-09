
using Connection_To_DataBaseCSharpe.DataBase;
using Connection_To_DataBaseCSharpe.Models;

internal class Program
{ 
    private static void Main(string[] args)
    {
        new MenuUser(new GerenciadorContext()).Menu_();
    }
}