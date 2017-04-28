using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotizMgr.Data
{
    public class Aufgabe : Element
    {   
        public Aufgabe() { }

        public Aufgabe(eElementType l_eType, string l_szInhalt) : base(l_eType, l_szInhalt)
        {
        }

        public override string ToString()
        {
            return "todo: " + m_szInhalt;
        }
    }
}
