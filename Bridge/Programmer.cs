using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Programmer
    {
        private readonly ILanguage _language;

        public Programmer(ILanguage language)
        {
            _language = language;
        }

        public virtual void DoWork()
        {
            _language.Build();
            _language.Execute();
        }

        public abstract void EarnMoney();
    }
}
