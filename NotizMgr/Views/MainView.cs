using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NotizMgr.Data.Element;

namespace NotizMgr
{
    public partial class MainView : Form
    {
        // Schulrechner unterstützen C# 6.0 nicht:
        // -> keine auto-initialisierer
        // -> keine getter-only props
        List<Data.Element> m_acElemente { get; set; }
        Data.ProjektMappe m_cCurrentMappe { get; set; }
        Views.MainViewModel m_cMain { get; set; }

        BindingSource m_cProj { get; set; }
        BindingSource m_cEle { get; set; }

        public MainView()
        {
            InitializeComponent();

            m_cMain = new Views.MainViewModel();
            InitBindings();
        }

        private void InitBindings()
        {
            m_cProj = new BindingSource();
            m_cEle = new BindingSource();
            m_cProj.DataSource = m_cMain.m_acProjekte;
        }
        
        private void neuesProjektToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProjectToList();
        }

        private void neueNotizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Notiz);
        }

        private void neuerTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Termin);
        }

        private void neueAufgabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Aufgabe);
        }
        
        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void lbProjekte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_cCurrentMappe = m_cMain.GetSelectedProject(lbProjekte.SelectedIndex);
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projektSpeichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                m_cMain.DoSerialize(m_cCurrentMappe);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void projektLadenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var l_cMappe = m_cMain.DoDeserialize();
                m_cMain.AddProject(l_cMappe);
                m_cCurrentMappe = l_cMappe;
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void AddElementToList(eElementType l_eType)
        {
            try
            {
                if (m_cCurrentMappe == null)
                    return;

                var element = m_cMain.AddElementDlg(l_eType);
                m_cCurrentMappe.m_acInhalt.Add(element);

                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProjectToList()
        {
            try
            {
                m_cMain.NewProject();
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void UpdateView()
        {
            if (m_cCurrentMappe != null && m_cCurrentMappe.m_acInhalt != null)
                m_cEle.DataSource = m_cCurrentMappe.m_acInhalt;

            lbProjekte.DataSource = m_cProj;
            lbNotizen.DataSource = m_cEle;

            m_cProj.ResetBindings(false);
            m_cEle.ResetBindings(false);
        }
    }
}
