using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Reflection;
using System.IO;
using AzurLane_Organizer.Entities;
using AzurLane_Organizer.Data;
using AzurLane_Organizer.Business;

namespace AzurLane_Organizer.Presentation
{
    public partial class frmCharacter : Form
    {
        private eCharacter _selectedCharacter;
        private bCharacter _bCharacter = new bCharacter();
        private bImageFiles _bImageFiles = new bImageFiles();
        private frmCharactersList _frmParent;
        private string _initialFormText;
        private bool _changesNotSaved;

        public frmCharacter(frmCharactersList frmParent)
        {
            InitializeComponent();
            this._frmParent = frmParent;
            ControlsSetReadOnly(false);
            _changesNotSaved = true;
        }

        public frmCharacter(frmCharactersList frmParent, int characterId)
        {
            InitializeComponent();
            this._frmParent = frmParent;
            this._selectedCharacter = _bCharacter.GetCharacters(characterId);
            if(_selectedCharacter == null)
            {
                MessageBox.Show("Could not retrieve character information", "Character not found",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ControlsSetReadOnly(true);
            ControlsUpdateInformation();
            _changesNotSaved = false;
        }

        private void frmCharacter_Load(object sender, EventArgs e)
        {
            UpdatePictureBoxes();
            this._initialFormText = this.Text;
            this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            UpdateFormText();
        }

        private void frmCharacter_Resize(object sender, EventArgs e)
        {
            this.picCharacter.Width = this.Width / 3;
            this.picCharacter.Height = this.Width / 3;
        }

        /// <summary>
        /// Updates this form's Text property, adding
        /// the _selectedCharacter's Name property.
        /// </summary>
        private void UpdateFormText()
        {
            if (_selectedCharacter != null && _selectedCharacter.Name != "")
            {
                //Adds character name to the form's text property
                this.Text = _initialFormText + " (" + _selectedCharacter.Name + ")";
            }
        }

        /// <summary>
        /// Sets the ReadOnly property of all controls in form.
        /// </summary>
        /// <param name="readOnly">
        /// The new value of all controls ReadOnly property.
        /// </param>
        private void ControlsSetReadOnly(bool readOnly)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control grpControl in control.Controls)
                    {
                        if (grpControl is TextBox)
                        {
                            TextBox txtInGrp = grpControl as TextBox;
                            txtInGrp.ReadOnly = readOnly;
                        }
                        if(grpControl is NumericUpDown)
                        {
                            NumericUpDown numInGrp = grpControl as NumericUpDown;
                            numInGrp.ReadOnly = readOnly;
                        }
                    }
                }
                if (control is TextBox)
                {
                    TextBox txtControl = control as TextBox;
                    txtControl.ReadOnly = readOnly;
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown numControl = control as NumericUpDown;
                    numControl.ReadOnly = readOnly;
                }
            }
        }

        private void ControlsTrimTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox)
                {
                    foreach (Control grpControl in control.Controls)
                    {
                        if (grpControl is TextBox)
                        {
                            TextBox txtInGrp = grpControl as TextBox;
                            txtInGrp.Text = txtInGrp.Text.Trim();
                        }
                    }
                }
                if (control is TextBox)
                {
                    TextBox txtControl = control as TextBox;
                    txtControl.Text = txtControl.Text.Trim();
                }
            }
        }

        private void ControlsEmpty(GroupBox grpBox)
        {
            foreach (Control control in grpBox.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is NumericUpDown)
                {
                    NumericUpDown numControl = control as NumericUpDown;
                    numControl.Value = 0;
                }
            }
            return;
        }

        /// <summary>
        /// Updates the information shown in all controls,
        /// with the properties of the _selectedCharacter object.
        /// </summary>
        private void ControlsUpdateInformation()
        {
            if(_selectedCharacter == null)
                return;

            this.txtName.Text = _selectedCharacter.Name;
            this.txtRarity.Text = _selectedCharacter.Rarity;
            this.txtIndex.Text = _selectedCharacter.Index;
            this.txtFaction.Text = _selectedCharacter.Faction;
            this.numIdNo.Value = _selectedCharacter.IdNo;
            this.numLevel.Value = _selectedCharacter.Level;
            this.numPower.Value = _selectedCharacter.Power;
            this.numStars.Value = _selectedCharacter.Stars;
            this.numAffinity.Value = _selectedCharacter.Affinity;
            this.numRanking.Value = _selectedCharacter.Ranking;
            this.txtSkill1.Text = _selectedCharacter.Skill1;
            this.txtSkill2.Text = _selectedCharacter.Skill2;
            this.txtSkill2.Text = _selectedCharacter.Skill3;
            this.txtSkill3.Text = _selectedCharacter.Skill4;
            this.numTier.Value = _selectedCharacter.Tier;
            this.txtBuffs.Text = _selectedCharacter.Buffs;
            this.txtSinergy.Text = _selectedCharacter.Sinergy;
            this.txtEquipment1.Text = _selectedCharacter.Equipment1;
            this.txtEquipment2.Text = _selectedCharacter.Equipment2;
            this.txtEquipment3.Text = _selectedCharacter.Equipment3;
            this.txtEquipment4.Text = _selectedCharacter.Equipment4;
        }

        /// <summary>
        /// Updates the _selectedCharacter object properties using the
        /// values in the textboxes.
        /// </summary>
        private void CharacterUpdateInformation()
        {
            if (_selectedCharacter == null)
                return;

            _selectedCharacter.Name = this.txtName.Text;
            _selectedCharacter.Rarity = this.txtRarity.Text;
            _selectedCharacter.Index = this.txtIndex.Text;
            _selectedCharacter.Faction = this.txtFaction.Text;
            _selectedCharacter.IdNo = Convert.ToInt32(this.numIdNo.Value);
            _selectedCharacter.Level = Convert.ToInt32(this.numLevel.Value);
            _selectedCharacter.Power = Convert.ToInt32(this.numPower.Value);
            _selectedCharacter.Stars = Convert.ToInt32(this.numStars.Value);
            _selectedCharacter.Affinity = Convert.ToInt32(this.numAffinity.Value);
            _selectedCharacter.Ranking = Convert.ToInt32(this.numRanking.Value);
            _selectedCharacter.Skill1 = this.txtSkill1.Text;
            _selectedCharacter.Skill2 = this.txtSkill2.Text;
            _selectedCharacter.Skill3 = this.txtSkill3.Text;
            _selectedCharacter.Skill4 = this.txtSkill4.Text;
            _selectedCharacter.Tier = Convert.ToInt32(this.numTier.Value);
            _selectedCharacter.Buffs = this.txtBuffs.Text;
            _selectedCharacter.Sinergy = this.txtSinergy.Text;
            _selectedCharacter.Equipment1 = this.txtEquipment1.Text;
            _selectedCharacter.Equipment2 = this.txtEquipment2.Text;
            _selectedCharacter.Equipment3 = this.txtEquipment3.Text;
            _selectedCharacter.Equipment4 = this.txtEquipment4.Text;
        }

        /// <summary>
        /// Updates both PictureBoxes images properties,
        /// with their corresponding image from directory.
        /// </summary>
        private void UpdatePictureBoxes()
        {
            if (_selectedCharacter == null)
                return;

            SetImage(this.picCharacter, _selectedCharacter.MainPictureDirectory);
            SetImage(this.picChibi, _selectedCharacter.ChibiPictureDirectory);
        }

        /// <summary>
        /// Sets a PictureBox Image property with image file from
        /// a given path.
        /// </summary>
        /// <param name="pictureBox">
        /// Picture box which Image property will be set.
        /// </param>
        /// <param name="imageShortPath">
        /// ShortPath of image file, as stored in eCharacter.
        /// </param>
        private void SetImage(PictureBox pictureBox, string imageShortPath)
        {
            string imageFullPath = Application.StartupPath + imageShortPath;
            if (File.Exists(imageFullPath))
            {
                pictureBox.Image = _bImageFiles.GetImage(imageFullPath);
                if(pictureBox.Image == null)
                {
                    MessageBox.Show("There was an error getting main picture file", "Could not get image",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string SelectImageFile()
        {
            if (_selectedCharacter == null)
            {
                MessageBox.Show("You must first save the character", "Character not saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            if(_selectedCharacter.MainPictureDirectory == null && _selectedCharacter.ChibiPictureDirectory == null)
            {
                MessageBox.Show("To keep exact proportions, select an image with same height and width.", "Recommended image size",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG JPG GIF(*.png, *jpg, *gif)|*.png;*.jpg;*gif";
            openFile.Multiselect = false;
            openFile.CheckFileExists = true;
            openFile.Title = "Select image file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                return openFile.FileName;
            }
            else
                return null;
        }

        private void SelectAndSavePicture(bool saveMainPicture)
        {
            string imageFilePath = SelectImageFile();
            if (imageFilePath == null)
                return;

            _bImageFiles.SavePictureFile(saveMainPicture, imageFilePath, _selectedCharacter);
            _bCharacter.CharacterUpdateImageDirectories(_selectedCharacter);
            UpdatePictureBoxes();
            
        }

        //Returns false if can't save
        private bool SaveCharacter()
        {
            //White spaces of all TextBoxes are eliminated
            ControlsTrimTextBoxes();
            if(txtName.Text == "")
            {
                MessageBox.Show("Character must have a name.", "Character has no name",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_selectedCharacter == null)
            {
                /*If trying to make a new character*/
                _bCharacter.CharacterCreate(this.txtName.Text);
                /*Now this Form references the new character*/
                this._selectedCharacter = _bCharacter.GetCharacterNewest();
            }
            CharacterUpdateInformation();
            if(_bCharacter.CharacterUpdate(_selectedCharacter) == 0)
            {
                MessageBox.Show("Character could not be saved.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this._frmParent.UpdateGrid();
            UpdateFormText();
            MessageBox.Show("Character has been saved.", "Character Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ControlsSetReadOnly(true);
            _changesNotSaved = false;
            return true;
        }

        private void DeleteCharacter()
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to delete this character?", "Delete character", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result != DialogResult.Yes)
            {
                return;
            }


            if (_bCharacter.CharacterDelete(_selectedCharacter.CharacterId) == 0)
            {
                MessageBox.Show("Character could not be deleted.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            _frmParent.UpdateGrid();
            MessageBox.Show("Character has been deleted.", "Character Deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void saveCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveCharacter();
        }

        private void mnuEditEditCharacter_Click(object sender, EventArgs e)
        {
            ControlsSetReadOnly(false);
            _changesNotSaved = true;
        }

        private void mnuFileDeleteCharacter_Click(object sender, EventArgs e)
        {
            DeleteCharacter();
        }

        private void selectMainPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAndSavePicture(true);
        }

        private void selectChibiPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAndSavePicture(false);
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCharacter_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_changesNotSaved == false)
                return;

            DialogResult result = MessageBox.Show("Do you want to save changes?", "Save changes",
    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SaveCharacter() == true)
                    return;
                else
                    e.Cancel = true;
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                //If user doesn't select any option,
                //form doesn't close
                e.Cancel = true;
            }

        }


       


        private void emptyBasicInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsEmpty(this.grpBasicInformation);
        }

        private void emptySkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsEmpty(this.grpSkills);
        }

        private void emptyStrategyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlsEmpty(this.grpStrategy);
        }

        private void mnuEditEmptyEquipment_Click(object sender, EventArgs e)
        {
            ControlsEmpty(this.grpEquipment);
        }
    }
}
