using NotizMgr.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NotizMgr.Data.Element;

namespace NotizMgr.Views
{
    class InputViewModel
    {
        eElementType m_eType { get; set; }

        public InputViewModel(eElementType l_eType)
        {
            m_eType = l_eType;
        }

        internal string GetElementType()
        {
            switch (m_eType)
            {
                case eElementType.Notiz:
                    return "Notiz";
                case eElementType.Termin:
                    return "Termin";
                case eElementType.Aufgabe:
                    return "Aufgabe";
                default:
                    return "";
            }
        }

        internal Element CreateElement(string l_szContent)
        {
            switch (m_eType)
            {
                case eElementType.Notiz:
                    return new Data.Notiz(eElementType.Notiz, l_szContent);
                case eElementType.Termin:
                    return new Data.Termin(eElementType.Termin, l_szContent);;
                case eElementType.Aufgabe:
                    return new Data.Aufgabe(eElementType.Aufgabe, l_szContent);
                default:
                    return null;
            }
        }
    }
}
