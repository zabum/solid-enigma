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
        // Anpassungen für C# 6.0 
        Data.ProjektMappe m_cCurrentMappe { get; set; }
        Views.MainViewModel m_cMain { get; set; }
        BindingSource m_cProj { get; set; }
        BindingSource m_cEle { get; set; }
        ContextMenu m_cMenu { get; set; }

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
            //m_cMenu = new ContextMenu(new MenuItem[]
            //{
            //        new MenuItem("Neues Projekt", neuesProjektToolStripMenuItem_Click),
            //        new MenuItem("Löschen", Löschen_Click)
            //});
            //m_cMenu.Popup += OnAufgehen;
            //lbProjekte.ContextMenu = m_cMenu;
        }

        private void AddElementToList(eElementType l_eType)
        {
            try
            {
                if (m_cCurrentMappe == null)
                    return;

                var l_cElement = m_cMain.AddElementDlg(l_eType);

                if (l_cElement == null)
                    return;

                m_cCurrentMappe.m_acInhalt.Add(l_cElement);

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
            if (m_cCurrentMappe != null &&
                m_cCurrentMappe.m_acInhalt != null)
            {
                var notes = m_cCurrentMappe.m_acInhalt.
                    Where(x => x.GetType() == typeof(Data.Notiz)).ToList();
                lbNotizen.DataSource = notes;

                var appointments = m_cCurrentMappe.m_acInhalt.
                    Where(x => x.GetType() == typeof(Data.Termin)).ToList();
                lbTermine.DataSource = appointments;

                var todos = m_cCurrentMappe.m_acInhalt.
                    Where(x => x.GetType() == typeof(Data.Aufgabe)).ToList();
                lbAufgaben.DataSource = todos;
            }
            lbProjekte.DataSource = m_cProj;
            m_cProj.ResetBindings(false);
            m_cEle.ResetBindings(false);
        }

        private void OnAufgehen(object sender, EventArgs e)
        {
            if (lbProjekte.SelectedIndex == -1)
                m_cMenu.MenuItems[1].Enabled = false;
            else
                m_cMenu.MenuItems[1].Enabled = true;
        }

        private void Löschen_Click(object sender, EventArgs e)
        {
            m_cProj.RemoveAt(lbProjekte.SelectedIndex);
            UpdateView();
        }

        private void neuesProjektToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProjectToList();
        }

        private void neueNotizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Notiz);
            tcElemente.SelectedTab = tpNotiz;
        }

        private void neuerTerminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Termin);
            tcElemente.SelectedTab = tpTermin;
        }

        private void neueAufgabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddElementToList(eElementType.Aufgabe);
            tcElemente.SelectedTab = tpAufgabe;
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
                m_cMain.Serialize(m_cCurrentMappe);
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
                //var l_cMappe = m_cMain.Deserialize();
                //m_cMain.AddProject(l_cMappe);
                //m_cCurrentMappe = l_cMappe;
                var m_cCurrentMappe = m_cMain.Deserialize();
                if (m_cCurrentMappe == null)
                    return;
                m_cMain.AddProject(m_cCurrentMappe);
                lbProjekte.SelectedItem = m_cCurrentMappe;
                UpdateView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
