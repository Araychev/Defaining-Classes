using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var triners = new List<Trainer>();

            while (true)
            {
                var cmdArgs = Console.ReadLine();
                if (cmdArgs == "Tournament")
                {
                    break;
                }

                var info = cmdArgs.Split(" ");
                if (!triners.Any(x => x.Name == info[0]))
                {
                    triners.Add(new Trainer(info[0]));
                }
                var currTrainer = triners.Find(t => t.Name == info[0]);
                currTrainer.Pokemon.Add(new Pokemon(info[1], info[2]
                    , int.Parse(info[3])));
            }

            while (true)
            {
                var elements = Console.ReadLine();
                if (elements == "End")
                {
                    break;
                }

                foreach (Trainer trainer in triners)
                {
                    if (trainer.Pokemon.Any(p => p.Element == elements))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemon.Count; i++)
                        {
                            trainer.Pokemon[i].Health -= 10;

                            if (trainer.Pokemon[i].Health <= 0)
                            {
                                trainer.Pokemon.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }

            foreach (Trainer triner in triners
                .OrderByDescending(t=>t.Badges))
            {
                Console.WriteLine($"{triner.Name} {triner.Badges} {triner.Pokemon.Count}");
            }
        }
    }
}
