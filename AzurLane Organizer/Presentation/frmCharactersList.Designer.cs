namespace AzurLane_Organizer.Presentation
{
    partial class frmCharactersList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgdCharactersList = new System.Windows.Forms.DataGridView();
            this.spALCharacterSelectNamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azurLaneOrganizerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.azur_Lane_OrganizerDataSet = new AzurLane_Organizer.Databases.Azur_Lane_OrganizerDataSet();
            this.spALCharacterSelectNamesTableAdapter = new AzurLane_Organizer.Databases.Azur_Lane_OrganizerDataSetTableAdapters.spALCharacterSelectNamesTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDeleteCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditEditCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewCharacter = new System.Windows.Forms.Button();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdCharactersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spALCharacterSelectNamesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azurLaneOrganizerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azur_Lane_OrganizerDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdCharactersList
            // 
            this.dgdCharactersList.AllowUserToAddRows = false;
            this.dgdCharactersList.AllowUserToDeleteRows = false;
            this.dgdCharactersList.AllowUserToResizeColumns = false;
            this.dgdCharactersList.AllowUserToResizeRows = false;
            this.dgdCharactersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgdCharactersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdCharactersList.Location = new System.Drawing.Point(12, 39);
            this.dgdCharactersList.MultiSelect = false;
            this.dgdCharactersList.Name = "dgdCharactersList";
            this.dgdCharactersList.ReadOnly = true;
            this.dgdCharactersList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgdCharactersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdCharactersList.ShowCellToolTips = false;
            this.dgdCharactersList.ShowEditingIcon = false;
            this.dgdCharactersList.Size = new System.Drawing.Size(350, 510);
            this.dgdCharactersList.TabIndex = 1;
            // 
            // spALCharacterSelectNamesBindingSource
            // 
            this.spALCharacterSelectNamesBindingSource.DataMember = "spALCharacterSelectNames";
            this.spALCharacterSelectNamesBindingSource.DataSource = this.azurLaneOrganizerDataSetBindingSource;
            // 
            // azurLaneOrganizerDataSetBindingSource
            // 
            this.azurLaneOrganizerDataSetBindingSource.DataSource = this.azur_Lane_OrganizerDataSet;
            this.azurLaneOrganizerDataSetBindingSource.Position = 0;
            // 
            // azur_Lane_OrganizerDataSet
            // 
            this.azur_Lane_OrganizerDataSet.DataSetName = "Azur_Lane_OrganizerDataSet";
            this.azur_Lane_OrganizerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spALCharacterSelectNamesTableAdapter
            // 
            this.spALCharacterSelectNamesTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewCharacter,
            this.mnuFileDeleteCharacter});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewCharacter
            // 
            this.mnuFileNewCharacter.Name = "mnuFileNewCharacter";
            this.mnuFileNewCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNewCharacter.Size = new System.Drawing.Size(203, 22);
            this.mnuFileNewCharacter.Text = "&New Character";
            this.mnuFileNewCharacter.Click += new System.EventHandler(this.mnuFileNewCharacter_Click);
            // 
            // mnuFileDeleteCharacter
            // 
            this.mnuFileDeleteCharacter.Name = "mnuFileDeleteCharacter";
            this.mnuFileDeleteCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuFileDeleteCharacter.Size = new System.Drawing.Size(203, 22);
            this.mnuFileDeleteCharacter.Text = "&Delete Character";
            this.mnuFileDeleteCharacter.Click += new System.EventHandler(this.mnuFileDeleteCharacter_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditEditCharacter});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditEditCharacter
            // 
            this.mnuEditEditCharacter.Name = "mnuEditEditCharacter";
            this.mnuEditEditCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEditEditCharacter.Size = new System.Drawing.Size(188, 22);
            this.mnuEditEditCharacter.Text = "&Edit Character";
            this.mnuEditEditCharacter.Click += new System.EventHandler(this.mnuEditEditCharacter_Click);
            // 
            // btnNewCharacter
            // 
            this.btnNewCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCharacter.Location = new System.Drawing.Point(380, 39);
            this.btnNewCharacter.Name = "btnNewCharacter";
            this.btnNewCharacter.Size = new System.Drawing.Size(150, 50);
            this.btnNewCharacter.TabIndex = 2;
            this.btnNewCharacter.Text = "New Character";
            this.btnNewCharacter.UseVisualStyleBackColor = true;
            this.btnNewCharacter.Click += new System.EventHandler(this.btnNewCharacter_Click);
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCharacter.Location = new System.Drawing.Point(380, 95);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteCharacter.TabIndex = 3;
            this.btnDeleteCharacter.Text = "Delete Character";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            this.btnDeleteCharacter.Click += new System.EventHandler(this.btnDeleteCharacter_Click);
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCharacter.Location = new System.Drawing.Point(380, 151);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(150, 50);
            this.btnEditCharacter.TabIndex = 4;
            this.btnEditCharacter.Text = "Edit Character";
            this.btnEditCharacter.UseVisualStyleBackColor = true;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // frmCharactersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 561);
            this.Controls.Add(this.btnEditCharacter);
            this.Controls.Add(this.btnDeleteCharacter);
            this.Controls.Add(this.btnNewCharacter);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgdCharactersList);
            this.Name = "frmCharactersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Characters List - Azur Lane Organizer";
            this.Load += new System.EventHandler(this.frmCharactersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdCharactersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spALCharacterSelectNamesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azurLaneOrganizerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azur_Lane_OrganizerDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdCharactersList;
        private System.Windows.Forms.BindingSource azurLaneOrganizerDataSetBindingSource;
        private Databases.Azur_Lane_OrganizerDataSet azur_Lane_OrganizerDataSet;
        private System.Windows.Forms.BindingSource spALCharacterSelectNamesBindingSource;
        private Databases.Azur_Lane_OrganizerDataSetTableAdapters.spALCharacterSelectNamesTableAdapter spALCharacterSelectNamesTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewCharacter;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDeleteCharacter;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEditCharacter;
        private System.Windows.Forms.Button btnNewCharacter;
        private System.Windows.Forms.Button btnDeleteCharacter;
        private System.Windows.Forms.Button btnEditCharacter;
    }
}