using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NotizMgr.Data;
using static NotizMgr.Data.Element;

namespace NotizMgr.Views
{
    class MainViewModel
    {
        public List<ProjektMappe> m_acProjekte { get; set; }
        public List<Element> m_acElemente { get; set; }

        public ProjektMappe m_cCurrentMappe { get; set; }

        public MainViewModel()
        {
            m_acProjekte = new List<ProjektMappe>();
        }

        /// <summary>
        /// Öffnet Input-Dialog
        /// </summary>
        /// <param name="l_eType"></param>
        /// <returns></returns>
        public Element AddElementDlg(eElementType l_eType)
        {
            InputView l_cInputDlg = new InputView(l_eType);
            if (l_cInputDlg.ShowDialog() == DialogResult.OK)
            {
                return l_cInputDlg.m_cElement;
            }
            return null;
        }


        internal void DoSerialize(ProjektMappe m_cCurrentMappe)
        {
            SaveFileDialog l_cSave = new SaveFileDialog();
            l_cSave.InitialDirectory = Directory.GetCurrentDirectory();
            l_cSave.OverwritePrompt = true;
            l_cSave.FileName = m_cCurrentMappe.m_szName + ".xml";
            if (l_cSave.ShowDialog() == DialogResult.OK)
            {
                Serialization.SerializeMappe(m_cCurrentMappe);
            }

        }

        internal ProjektMappe DoDeserialize()
        {
            string l_szMappe = "";
            OpenFileDialog l_cOpen = new OpenFileDialog();
            l_cOpen.InitialDirectory = Directory.GetCurrentDirectory();

            if (l_cOpen.ShowDialog() == DialogResult.OK)
            {
                l_szMappe = l_cOpen.FileName;
            }

            if (string.IsNullOrEmpty(l_szMappe))
                return null;

            ProjektMappe l_cFromXml = new Data.ProjektMappe(Path.GetFileNameWithoutExtension(l_szMappe));
            l_cFromXml.m_acInhalt = Serialization.DeserializeMappe(l_szMappe);

            return MatchElementTypes(l_cFromXml);
        }

        internal ProjektMappe GetSelectedProject(int l_iSelectedIndex)
        {
            foreach (var item in m_acProjekte)
            {
                if (item.m_szName == m_acProjekte[l_iSelectedIndex].m_szName)
                    return item;
            }
            return null;
        }

        private ProjektMappe MatchElementTypes(ProjektMappe l_cMappe)
        {
            foreach (var item in l_cMappe.m_acInhalt)
            {
                if (item.GetType() == typeof(Notiz))
                {
                    item.m_eType = eElementType.Notiz;
                }
                if (item.GetType() == typeof(Termin))
                {
                    item.m_eType = eElementType.Termin;
                }
                if (item.GetType() == typeof(Aufgabe))
                {
                    item.m_eType = eElementType.Aufgabe;
                }
            }
            return l_cMappe;
        }

        internal void AddProject(ProjektMappe l_cMappe)
        {
            if (l_cMappe == null)
                return;

            if (!m_acProjekte.Any(o => o.m_szName == l_cMappe.m_szName))
            {
                m_acProjekte.Add(l_cMappe);
            }
        }

        internal void NewProject()
        {
            AddProjectView l_cAdd = new AddProjectView();
            if (l_cAdd.ShowDialog() == DialogResult.OK)
            {
                AddProject(new ProjektMappe(l_cAdd.m_szProjectName));
            }     
        }
    }
}
