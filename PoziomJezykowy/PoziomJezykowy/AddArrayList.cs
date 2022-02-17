using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoziomJezykowy
{
    class AddArrayList
    {
        public void Add_Word(string Word)
        {
            ArrayList newWord = new ArrayList();
            newWord.Add(Word);
        }

        public void Add_Definition(string Definition)
        {
            ArrayList newDefinition = new ArrayList();
            newDefinition.Add(Definition);
        }

        

    }
}
