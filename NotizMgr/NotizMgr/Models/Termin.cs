using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotizMgr.Data
{
    public class Termin : Element
    {
        [XmlElement("Datum")]
        public string m_szDate { get; set; }

        public Termin() { }

        public Termin(eElementType l_eType, string l_szInhalt, string l_szDate) : base(l_eType, l_szInhalt)
        {
            m_szDate = l_szDate;
        }

        public override string ToString()
        {
            return m_szDate + ": " + m_szInhalt;
        }
    }
}
