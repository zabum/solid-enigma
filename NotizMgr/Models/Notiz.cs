using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotizMgr.Data
{
    public class Notiz : Element
    {
        [XmlElement("Inhalt")]
        public string m_szInhalt { get; set; }

        public Notiz() { }  

        public Notiz(eElementType l_eType, string l_szInhalt) : base(l_eType)
        {
            m_szInhalt = l_szInhalt;
        }
        
        public override string ToString()
        {
            return m_szInhalt;
        }
    }
}
