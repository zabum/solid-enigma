using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace NotizMgr
{
    class Serialization
    {
        public static void SerializeMappe(Data.ProjektMappe l_cMappe)
        {
            try
            {
                var ser = new XmlSerializer(typeof(List<Data.Element>));
                using (StreamWriter writer = new StreamWriter(l_cMappe.m_szName+".xml"))
                {
                    ser.Serialize(writer, l_cMappe.m_acInhalt);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Data.Element> DeserializeMappe(string l_szFile)
        {
            try
            {
                var deser = new XmlSerializer(typeof(List<Data.Element>));
                using (StreamReader reader = new StreamReader(l_szFile))
                {
                    return deser.Deserialize(reader) as List<Data.Element>;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
