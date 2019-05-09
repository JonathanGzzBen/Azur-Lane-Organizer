using System;
using System.Windows.Forms;

using System.Drawing;
using System.Reflection;
using AzurLane_Organizer.Business;

namespace AzurLane_Organizer.Presentation
{
    public partial class frmCharactersList : Form
    {
        public frmCharactersList()
        {
            InitializeComponent();
        }

        private bCharacter _bCharacter = new bCharacter();

        public void UpdateGrid()
        {
            //Refreshes grid
            this.dgdCharactersList.DataSource = null;
            this.dgdCharactersList.DataSource = _bCharacter.GetCharacterNames();
            if(this.dgdCharactersList.DataSource == null)
            {
                MessageBox.Show("Could not get characters list", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(DataGridViewColumn column in dgdCharactersList.Columns)
            {
                if (column.Name == "Name")
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                else
                    column.Visible = false;
            }
            dgdCharactersList.Select();
        }

        private void NewCharacter()
        {
            frmCharacter newCharacter = new frmCharacter(this);
            newCharacter.Show();
        }

        private void EditCharacter()
        {
            if(dgdCharactersList.SelectedRows.Count == 1)
            {
                //Gets Id
                int selectedCharacterId = Convert.ToInt32(dgdCharactersList.CurrentRow.Cells[0].Value);
                frmCharacter selectedCharacter = new frmCharacter(this, selectedCharacterId);
                selectedCharacter.Show();
            }
        }

        private void DeleteCharacter()
        {
            int selectedCharacterId = -1;
            try
            {
                if (dgdCharactersList.SelectedRows.Count == 1 && dgdCharactersList.CurrentRow.Index >= 0)
                    selectedCharacterId = Convert.ToInt32(dgdCharactersList.CurrentRow.Cells[0].Value);
            }
            catch
            {
                dgdCharactersList.Select();
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this character?", "Delete character",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }
            if (_bCharacter.CharacterDelete(selectedCharacterId) == 0)
            {
                MessageBox.Show("Character could not be deleted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateGrid();
                MessageBox.Show("Character has been deleted", "Character Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCharactersList_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            UpdateGrid();
        }

        private void btnNewCharacter_Click(object sender, EventArgs e)
        {
            NewCharacter();
        }

        private void mnuFileNewCharacter_Click(object sender, EventArgs e)
        {
            NewCharacter();
        }

        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            EditCharacter();
        }

        private void mnuEditEditCharacter_Click(object sender, EventArgs e)
        {
            EditCharacter();
        }

        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            DeleteCharacter();
        }

        private void mnuFileDeleteCharacter_Click(object sender, EventArgs e)
        {
            DeleteCharacter();
        }
    }
}
