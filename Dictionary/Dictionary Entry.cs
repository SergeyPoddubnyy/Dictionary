using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class DictionaryEntryVerbs
    {
        private string Form1 { get; }
        private string Form2 { get; }
        private string Form3 { get; }
        private string Translation { get; }
        public DictionaryEntryVerbs(string _form1, string _form2, string _form3, string _translation)
        {
            Form1 = _form1;
            Form2 = _form2;
            Form3 = _form3;
            Translation = _translation;
        }
        public override string ToString()
        {
            return $"{Form1}\t{Form2}\t{Form3}\t{Translation}";
        }
    }
}
