using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshNotes();
        }

        private void RefreshNotes()
        {
            var notes = Notes.GetNotes();
            lbNotes.Items.Clear();
            foreach (var note in notes)
            {
                lbNotes.Items.Add(note);
            }
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            string naziv = tbNewNote.Text.Trim();
            if (!string.IsNullOrEmpty(naziv))
            {
                Notes.AddNote(new Note("", naziv));
                tbNewNote.Clear();
                RefreshNotes();
            }
            else
            {
                MessageBox.Show("Unesi naziv bilješke!");
            }
        }

        private void lbNotes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbNotes.SelectedItem != null)
            {
                var note = Notes.GetNote(((Note)lbNotes.SelectedItem).Id);
                tbNote.Text = note.Content;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbNotes.SelectedItem != null)
            {
                bool result = Notes.UpdateNote((Note)lbNotes.SelectedItem, tbNote.Text);
                if (!result)
                {
                    MessageBox.Show("Greška prilikom pohrane!");
                }
                else
                {
                    MessageBox.Show("Bilješka spremljena.");
                }
            }
            else
            {
                MessageBox.Show("Odaberi bilješku!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbNotes.SelectedItem != null)
            {
                var note = (Note)lbNotes.SelectedItem;
                var confirm = MessageBox.Show("Sigurno želiš obrisati ovu bilješku?", "Potvrda", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Notes.DeleteNote(note.Id);
                    tbNote.Clear();
                    RefreshNotes();
                }
            }
            else
            {
                MessageBox.Show("Odaberi bilješku za brisanje!");
            }
        }
    }
}
