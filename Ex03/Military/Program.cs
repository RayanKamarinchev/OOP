using System;
using System.Collections.Generic;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Private> privates = new List<Private>();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Private":
                        Private priv = new Private(command[1], command[2], command[3], decimal.Parse(command[4]));
                        privates.Add(priv);
                        Console.WriteLine(priv.ToString());
                        break;
                    case "LieutenantGeneral":
                        List<Private> lowerPrivates = new List<Private>();
                        for (int i = 5; i < command.Length; i++)
                        {
                            foreach (var soldier in privates)
                            {
                                if (soldier.Id == command[i])
                                {
                                    lowerPrivates.Add(soldier);
                                    break;
                                }
                            }
                        }
                        LieutenantGeneral lientenantGeneral = new LieutenantGeneral
                            (command[1], command[2], command[3], decimal.Parse(command[4]), lowerPrivates);
                        Console.WriteLine(lientenantGeneral.ToString());
                        break;
                    case "Engineer":
                        if (command[5] == "Airforces" || command[5] == "Marines")
                        {
                            List<Repairs> repairs = new List<Repairs>();
                            for (int i = 6; i < command.Length; i += 2)
                            {
                                repairs.Add(new Repairs(command[i], int.Parse(command[i + 1])));
                            }
                            Engineer engineer = new Engineer
                                (command[1], command[2], command[3], decimal.Parse(command[4]), command[5], repairs);
                            Console.WriteLine(engineer.ToString());
                        }
                        break;
                    case "Commando":
                        if (command[5] == "Airforces" || command[5] == "Marines")
                        {
                            List<Mission> missions = new List<Mission>();
                            for (int i = 6; i < command.Length; i += 2)
                            {
                                if (command[i + 1] == "inProgress" || command[i + 1] == "Finished")
                                {
                                    missions.Add(new Mission(command[i], command[i + 1]));
                                }
                            }
                            Commando commando = new Commando
                                (command[1], command[2], command[3], decimal.Parse(command[4]), command[5], missions);
                            Console.WriteLine(commando.ToString());
                        }
                        break;
                    case "Spy":
                        Spy spy = new Spy(command[1], command[2], command[3], int.Parse(command[4]));
                        Console.WriteLine(spy.ToString());
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
