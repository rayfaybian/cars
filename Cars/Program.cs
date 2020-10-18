using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            Boolean isRunning = true;


            Console.WriteLine(" ------------------------- \n" +
                              "|   Herzlich willkommen   |\n" +
                              "|          bei            |\n" +
                              "|      Autoliste.com      |\n" +
                              " -------------------------");

            while (isRunning)
            {
                Console.WriteLine("\nWas möchtest du tun?\n" +
                                  "--------------------\n" +
                                  "1) Auto in die Liste eintragen\n" +
                                  "2) Liste ansehen\n" +
                                  "3) Ich will hier raus\n");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nSuper, dann lass uns loslegen.");
                        //Type festlegen
                        Console.WriteLine("\nWähle als erstes einen Autotyp:\n\n1) Sportauto\n2) Normales Auto\n");
                        
                        Boolean inputCorrect = false;
                        while (!inputCorrect)
                        {
                            input = Console.ReadLine();
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("\nYeah, ein Sportauto. Du scheinst ein cooler Mensch zu sein.");
                                    cars.Add(ConfigureSportscar());
                                    inputCorrect = true;
                                    break;

                                case "2":
                                    Console.WriteLine("\nEin normaler PKW also. Du Langweiler.");
                                    cars.Add(ConfigureCar());
                                    inputCorrect = true;
                                    break;

                                default:
                                    Console.WriteLine("\nDas klappt so nicht Bro.");
                                    Console.WriteLine("Wähle einen dieser Autotypen\n\n1) Sportauto\n2) Normales Auto\n");
                                    break;
                            }
                        }



                        break;
                    case "2":
                        Console.WriteLine("\n\nIn deiner Liste befinden sich derzeit" +
                                       "\n           " + cars.Count + " Fahrzeuge.\n");
                        Console.WriteLine(" -----------------------------\n" +
                                          "|  Hier ist deine Autoliste)  |\n" +
                                          " -----------------------------\n");
                        int counter = 1;
                        foreach (Car car in cars)
                        {
                            Console.WriteLine("----------------------" +
                                            "\n     Fahrzeug " + counter + 
                                            "\n----------------------" + car.ToString());
                            counter++;
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n --------------------------------------------" +
                                          "\n|   Okay, dann bis zum nächsten mal. Bye.    |" +
                                          "\n --------------------------------------------");
                        isRunning = false;
                        break;
                }
            }
        }

        public static Car ConfigureCar()
        {
            String input;
            Car car = new Car();

            car._type = Type.PKW;

            //Marke
            Console.WriteLine("\nAls nächstes muss ich wissen womit wir es zu tun haben.\nBitte tippe die Marke deines langweiligen Autos ein.\n");
            input = Console.ReadLine();
            car._producer = input;
            Console.WriteLine("\nOha, ein " + car._producer + ". Wird der Schrott noch immer produziert?");

            //Modell
            Console.WriteLine("Der hat doch bestimmt auch eine Modelbezeichnung. Bitte tippe diese ein.\n");
            input = Console.ReadLine();
            car._name = input;
            Console.WriteLine("\nDu hast also einen " + car._producer + " " + car._name + ". Mein Beileid.");

            //Baujahr
            Console.WriteLine("Baujahr?\n");
            input = Console.ReadLine();
            car._year = input;
            Console.WriteLine("\n" + car._year + "? Das wird langsam peinlich.");

            //Farbe
            Console.WriteLine("Verrat mir bitte noch welche Farbe dein " + car._type + " hat\n");
            input = Console.ReadLine();
            car._color = input;
            Console.WriteLine("\nUnd mit der Farbe traust du dich auf die Straße? Mutig.\n");

            //Zusammenfassung
            Console.WriteLine("\nIch habe die Schrottmühle der Liste hinzugefügt." +
                              "\n------------------------------------------------\n");

            return car;
        }

        public static Sportscar ConfigureSportscar()
        {
            String input;
            Sportscar sportscar = new Sportscar();

            sportscar._type = Type.Sportauto;


            //Marke
            Console.WriteLine("\nAls nächstes muss ich wissen womit wir es zu tun haben.\nBitte tippe die Marke deines krassen Sportwagens ein.\n");
            input = Console.ReadLine();
            sportscar._producer = input;
            Console.WriteLine("\nKrass, ein " + sportscar._producer + ". So einen wollte ich schon immer mal sehen.");

            //Modell
            Console.WriteLine("Der hat doch bestimmt auch eine Modelbezeichnung. Bitte tippe diese ein.\n");
            input = Console.ReadLine();
            sportscar._name = input;
            Console.WriteLine("\nDu hast also einen " + sportscar._producer + " " + sportscar._name + ". Krass, ich bin neidisch.");

            //Baujahr
            Console.WriteLine("Baujahr?\n");
            input = Console.ReadLine();
            sportscar._year = input;
            Console.WriteLine("\n" + sportscar._year + "? Hab gehört das sei das beste Baujahr bei diesem Model.");

            //Farbe
            Console.WriteLine("Verrat mir bitte noch welche Farbe dein " + sportscar._type + " hat\n");
            input = Console.ReadLine();
            sportscar._color = input;
            Console.WriteLine("\n" + sportscar._color + " passt halt auch perfekt für einen " + sportscar._producer + " " + sportscar._name + ".\n");

            //Zusammenfassung
            Console.WriteLine("\nIch habe das Sportauto der Liste hinzugefügt." +
                              "\n---------------------------------------------\n");



            return sportscar;
        }

    }
}
