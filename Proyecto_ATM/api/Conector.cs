using Npgsql;
using System;
using System.Data;

public class Conector
{
    public readonly NpgsqlConnection conector;
    private static readonly string password = "password";
    private static readonly string port = "5432";
    private static readonly string db = "ATM";
    private static readonly string username = "atm";
    private static readonly string host = "localhost";

    public Conector()
    {
        conector = new NpgsqlConnection($"server={host};port={port};user id={username};password={password};database={db};");
    }

    public NpgsqlConnection ConectorConnection => conector;

    public void Open()
    {
        if (conector.State != ConnectionState.Open)
        {
            conector.Open();
        }
    }

    public void Close()
    {
        if (conector.State != ConnectionState.Closed)
        {
            conector.Close();
        }
    }
}
