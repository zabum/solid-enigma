using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NotizMgr.Data
{
    [XmlInclude(typeof(Notiz))]
    [XmlInclude(typeof(Termin))]
    [XmlInclude(typeof(Aufgabe))]
    public class Element
    {
        [XmlIgnore] //XmlSerializer erkennt den Typ
        public eElementType m_eType { get; set; }
        [XmlElement("Inhalt")]
        public string m_szInhalt { get; set; }

        public enum eElementType
        {
            Default = 0, //kein Typ
            Notiz,
            Termin,
            Aufgabe,
        };

        public Element() { }

        public Element(eElementType l_eType)
        {
            m_eType = l_eType;
        }

        public Element(eElementType l_eType, string l_szInhalt)
        {
            m_eType = l_eType;
            m_szInhalt = l_szInhalt;
        }
    }
}
