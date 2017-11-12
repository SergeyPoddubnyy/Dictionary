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
        }
    }
}
