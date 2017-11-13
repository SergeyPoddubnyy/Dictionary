using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример использования репозитария
            IrregularVerbsRepository repo = new IrregularVerbsRepository();
            var verbs = repo.GetWords();
            Dictionary<string, DictionaryEntryVerbs> DictionVerbs =
              new Dictionary<string, DictionaryEntryVerbs>();
            for(int i=0; i < verbs.Length-1; i++)
            DictionVerbs.Add(verbs[i][0], new DictionaryEntryVerbs(verbs[i][0], verbs[i][1], verbs[i][2], verbs[i][3]));
            do
            {
                Console.WriteLine("Enter the verb");
                bool Found = DictionVerbs.TryGetValue(Console.ReadLine(), out DictionaryEntryVerbs value);
                if(!Found) Console.WriteLine("Not found verb!");
                else
                Console.WriteLine(value.ToString());
                Console.WriteLine("Set esc for exit");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
