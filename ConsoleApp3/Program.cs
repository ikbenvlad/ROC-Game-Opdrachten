using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        private static Dictionary<string, string> usersAdmin = new Dictionary<string, string>();
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welkom bij het administratie programma!");
                Console.WriteLine("Wat wilt u doen?");
                Console.WriteLine("1. Inloggen");
                Console.WriteLine("2. Registreren");
                Console.WriteLine("3. Afsluiten");
                Console.Write("Typ hier jouw keuze in: ");
                string keuzeMenu = Console.ReadLine()?.ToLower();
                Console.Clear();
                switch (keuzeMenu)
                {
                    case "1":
                        if (Login())
                        {
                            Console.Clear();
                            MainMenu();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Register();
                        break;
                    case "3":
                        Console.Clear();
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Kies tussen 1, 2 en 3");
                        break;
                }
            }
        }

        private static void MainMenu()
        {
            Console.WriteLine("Je zit nu in het main menu.");
            Console.WriteLine("Wat wil je nu doen?");
            Console.WriteLine("1. Klanten Beheren");
            Console.WriteLine("2. Klanten Informatie");
            Console.WriteLine("3. Order Beheer");
            Console.WriteLine("4. Factuur Beheer");
            Console.WriteLine("5. Terug");
            string mainMenuKeuze = Console.ReadLine()?.ToLower();
            Console.Clear();
            switch (mainMenuKeuze)
            {
                case "1":
                    ManageClients();
                    break;
                case "2":
                    ClientInfo();
                    break;
                case "3":
                    OrderManagement();
                    break;
                case "4":
                    InvoiceManagement();
                    break;
                case "5":
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Kies tussen 1 van de bestaande opties.");
                    return;
            }
        }
        private static bool Login()
        {
            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();
            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Inloggen...");
            Thread.Sleep(5000);

            if (usersAdmin.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("Inloggen succesvol!");
                Thread.Sleep(2000);
                Console.Clear();
                return true;

            }
            else
            {
                Console.WriteLine("Username/password incorrect");
                Thread.Sleep(2000);
                Console.Clear();
                return false;
            }
        }

        private static void Register()
        {
            Console.WriteLine("Registreren:");
            Thread.Sleep(2000);
            Console.Clear();
            Console.Write("Gebruikersnaam: ");
            string username = Console.ReadLine();
            Console.Write("Wachtwoord: ");
            string password = Console.ReadLine();
            Console.Write("Wachtwoord herhalen: ");
            string passwordRepeat = Console.ReadLine();
            Thread.Sleep(500);
            Console.WriteLine("Registratie opslaan...");
            Thread.Sleep(4000);
            if (password == passwordRepeat)
            {
                if (!usersAdmin.ContainsKey(username))
                {
                    usersAdmin.Add(username, password);
                    Console.WriteLine("Registreren succesvol!");

                }
                else
                {
                    Console.WriteLine("Gebruikersnaam bestaat al.");
                }
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Wachtwoorden komen niet overeen.");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        private static void InvoiceManagement()
        {
            throw new NotImplementedException();
        }
        private static void OrderManagement()
        {
            throw new NotImplementedException();
        }
        private static void ClientInfo()
        {
            throw new NotImplementedException();
        }
        private static void ManageClients()
        {
            if (true)
            {
                Console.Clear();
                Console.WriteLine("Klanten beheren:");
                Thread.Sleep(2000);
                Console.WriteLine("1. Klanten toevoegen");
                Console.WriteLine("2. Klanten verwijderen");
                Console.WriteLine("3. terug");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        
                        Console.Clear();
                        Console.WriteLine("Voornaam (typ 'exit' om terug te gaan): ");
                        string firstName = Console.ReadLine();
                        if (firstName == "exit")
                        {
                            Console.Clear();
                            ManageClients();
                        }
                        Console.WriteLine("Achternaam: ");
                        string lastName = Console.ReadLine();
                        users.Add(firstName, lastName);
                        Console.WriteLine("Klant" + " " + firstName + " " + lastName + " is toegevoegd");
                        Thread.Sleep(1000);
                        Console.Write("Wil je nog een klant toevoegen? (y/n): ");
                        string addAnother = Console.ReadLine();

                        if (addAnother == "y")
                        {
                            Console.Clear();
                            Console.Write("Voornaam (typ 'exit' om terug te gaan): ");
                            string firstName2 = Console.ReadLine();
                            if (firstName2 == "exit")
                            {
                                Console.Clear();
                                ManageClients();
                            }
                            Console.Write("Achternaam: ");
                            string lastName2 = Console.ReadLine();
                            users.Add(firstName2, lastName2);
                            Console.WriteLine("Klant" + " " + firstName2 + " " + lastName2 + " is toegevoegd.");
                            Thread.Sleep(1000);
                            Console.Write("Wil je nog een gebruiker toevoegen? (y/n): ");
                            string addAnother2 = Console.ReadLine();

                            if (addAnother2 == "y")
                            {
                                Console.Clear();
                                Console.Write("Voornaam (typ 'exit' om terug te gaan): ");
                                string firstName3 = Console.ReadLine();
                                if (firstName3 == "exit")
                                {
                                    Console.Clear();
                                    ManageClients();
                                }
                                Console.Write("Achternaam: ");
                                string lastName3 = Console.ReadLine();
                                users.Add(firstName3, lastName3);
                                Console.WriteLine(firstName3 + " " + lastName3 + " is toegevoegd.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Maximum aantal klanten bereikt.");
                                Thread.Sleep(2500);
                                Console.Clear();
                                ManageClients();
                            }
                            else if (addAnother2 == "n")
                            {
                                Console.Clear();
                                ManageClients();
                            }
                        }
                        else if (addAnother == "n")
                        {
                            Console.Clear();
                            ManageClients();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Geregistreerde klanten:");
                        foreach (var user in users)
                        {
                            Console.WriteLine($"Gebruiker: {user.Key} {user.Value}");
                        }
                        Console.Write("Welke gebruiker wil je verwijderen (typ 'exit' om terug te gaan): ");
                        string userDelete = Console.ReadLine();
                            if (userDelete == "exit")
                            {
                                Console.Clear();
                                ManageClients();
                            }
                        users.Remove(userDelete);
                        Console.WriteLine("Klant" + " " + userDelete + " is verwijderd.");
                        Thread.Sleep(5000);
                        Console.Clear();
                        ManageClients();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}