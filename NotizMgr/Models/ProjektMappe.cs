using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotizMgr.Data
{
    public class ProjektMappe
    {
        public string m_szName { get; set; }
        
        public List<Element> m_acInhalt { get; set; }

        public ProjektMappe(string l_szName)
        {
            m_szName = l_szName;
            m_acInhalt = new List<Element>();
        }

        public override string ToString()
        {
            return m_szName;
        }
    }
}
