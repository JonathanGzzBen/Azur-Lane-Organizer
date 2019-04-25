namespace AzurLane_Organizer.Presentation
{
    partial class frmCharacter
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
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblFaction = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtRarity = new System.Windows.Forms.TextBox();
            this.txtFaction = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblAffinity = new System.Windows.Forms.Label();
            this.lblCharacterRanking = new System.Windows.Forms.Label();
            this.grpBasicInformation = new System.Windows.Forms.GroupBox();
            this.numRanking = new System.Windows.Forms.NumericUpDown();
            this.numIdNo = new System.Windows.Forms.NumericUpDown();
            this.numAffinity = new System.Windows.Forms.NumericUpDown();
            this.numStars = new System.Windows.Forms.NumericUpDown();
            this.numPower = new System.Windows.Forms.NumericUpDown();
            this.numIndex = new System.Windows.Forms.NumericUpDown();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.txtSkill4 = new System.Windows.Forms.TextBox();
            this.txtSkill3 = new System.Windows.Forms.TextBox();
            this.txtSkill2 = new System.Windows.Forms.TextBox();
            this.txtSkill1 = new System.Windows.Forms.TextBox();
            this.grpStrategy = new System.Windows.Forms.GroupBox();
            this.numTier = new System.Windows.Forms.NumericUpDown();
            this.txtSinergy = new System.Windows.Forms.TextBox();
            this.lblSinergy = new System.Windows.Forms.Label();
            this.txtBuffs = new System.Windows.Forms.TextBox();
            this.lblBuffs = new System.Windows.Forms.Label();
            this.lblTier = new System.Windows.Forms.Label();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.txtEquipment5 = new System.Windows.Forms.TextBox();
            this.txtEquipment4 = new System.Windows.Forms.TextBox();
            this.txtEquipment3 = new System.Windows.Forms.TextBox();
            this.txtEquipment2 = new System.Windows.Forms.TextBox();
            this.txtEquipment1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileDeleteCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditEditCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.selectMainPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectChibiPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyBasicInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptySkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyStrategyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditEmptyEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.picChibi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.grpBasicInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAffinity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            this.grpSkills.SuspendLayout();
            this.grpStrategy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTier)).BeginInit();
            this.grpEquipment.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChibi)).BeginInit();
            this.SuspendLayout();
            // 
            // picCharacter
            // 
            this.picCharacter.BackColor = System.Drawing.Color.Transparent;
            this.picCharacter.Location = new System.Drawing.Point(13, 27);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(400, 400);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharacter.TabIndex = 0;
            this.picCharacter.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(191, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Character Name:";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRarity.Location = new System.Drawing.Point(14, 81);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(54, 20);
            this.lblRarity.TabIndex = 2;
            this.lblRarity.Text = "Rarity:";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Location = new System.Drawing.Point(169, 81);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(52, 20);
            this.lblIndex.TabIndex = 4;
            this.lblIndex.Text = "Index:";
            // 
            // lblFaction
            // 
            this.lblFaction.AutoSize = true;
            this.lblFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaction.Location = new System.Drawing.Point(323, 78);
            this.lblFaction.Name = "lblFaction";
            this.lblFaction.Size = new System.Drawing.Size(66, 20);
            this.lblFaction.TabIndex = 6;
            this.lblFaction.Text = "Faction:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(597, 84);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(51, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id No.";
            // 
            // txtRarity
            // 
            this.txtRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRarity.Location = new System.Drawing.Point(74, 78);
            this.txtRarity.MaxLength = 5;
            this.txtRarity.Name = "txtRarity";
            this.txtRarity.ReadOnly = true;
            this.txtRarity.Size = new System.Drawing.Size(46, 26);
            this.txtRarity.TabIndex = 3;
            // 
            // txtFaction
            // 
            this.txtFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaction.Location = new System.Drawing.Point(395, 75);
            this.txtFaction.MaxLength = 50;
            this.txtFaction.Name = "txtFaction";
            this.txtFaction.ReadOnly = true;
            this.txtFaction.Size = new System.Drawing.Size(162, 26);
            this.txtFaction.TabIndex = 7;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(18, 131);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 10;
            this.lblLevel.Text = "Level:";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(164, 131);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(57, 20);
            this.lblPower.TabIndex = 12;
            this.lblPower.Text = "Power:";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStars.Location = new System.Drawing.Point(323, 131);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(51, 20);
            this.lblStars.TabIndex = 14;
            this.lblStars.Text = "Stars:";
            // 
            // lblAffinity
            // 
            this.lblAffinity.AutoSize = true;
            this.lblAffinity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffinity.Location = new System.Drawing.Point(444, 131);
            this.lblAffinity.Name = "lblAffinity";
            this.lblAffinity.Size = new System.Drawing.Size(61, 20);
            this.lblAffinity.TabIndex = 16;
            this.lblAffinity.Text = "Affinity:";
            // 
            // lblCharacterRanking
            // 
            this.lblCharacterRanking.AutoSize = true;
            this.lblCharacterRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterRanking.Location = new System.Drawing.Point(612, 131);
            this.lblCharacterRanking.Name = "lblCharacterRanking";
            this.lblCharacterRanking.Size = new System.Drawing.Size(36, 20);
            this.lblCharacterRanking.TabIndex = 18;
            this.lblCharacterRanking.Text = "CR:";
            // 
            // grpBasicInformation
            // 
            this.grpBasicInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBasicInformation.Controls.Add(this.numRanking);
            this.grpBasicInformation.Controls.Add(this.numIdNo);
            this.grpBasicInformation.Controls.Add(this.numAffinity);
            this.grpBasicInformation.Controls.Add(this.numStars);
            this.grpBasicInformation.Controls.Add(this.numPower);
            this.grpBasicInformation.Controls.Add(this.numIndex);
            this.grpBasicInformation.Controls.Add(this.numLevel);
            this.grpBasicInformation.Controls.Add(this.txtName);
            this.grpBasicInformation.Controls.Add(this.lblName);
            this.grpBasicInformation.Controls.Add(this.lblRarity);
            this.grpBasicInformation.Controls.Add(this.lblCharacterRanking);
            this.grpBasicInformation.Controls.Add(this.lblIndex);
            this.grpBasicInformation.Controls.Add(this.lblFaction);
            this.grpBasicInformation.Controls.Add(this.lblAffinity);
            this.grpBasicInformation.Controls.Add(this.lblId);
            this.grpBasicInformation.Controls.Add(this.txtRarity);
            this.grpBasicInformation.Controls.Add(this.lblStars);
            this.grpBasicInformation.Controls.Add(this.txtFaction);
            this.grpBasicInformation.Controls.Add(this.lblPower);
            this.grpBasicInformation.Controls.Add(this.lblLevel);
            this.grpBasicInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasicInformation.Location = new System.Drawing.Point(419, 27);
            this.grpBasicInformation.Name = "grpBasicInformation";
            this.grpBasicInformation.Size = new System.Drawing.Size(754, 176);
            this.grpBasicInformation.TabIndex = 0;
            this.grpBasicInformation.TabStop = false;
            this.grpBasicInformation.Text = "Basic Information";
            // 
            // numRanking
            // 
            this.numRanking.Location = new System.Drawing.Point(654, 128);
            this.numRanking.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRanking.Name = "numRanking";
            this.numRanking.ReadOnly = true;
            this.numRanking.Size = new System.Drawing.Size(58, 26);
            this.numRanking.TabIndex = 19;
            // 
            // numIdNo
            // 
            this.numIdNo.Location = new System.Drawing.Point(654, 81);
            this.numIdNo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIdNo.Name = "numIdNo";
            this.numIdNo.ReadOnly = true;
            this.numIdNo.Size = new System.Drawing.Size(58, 26);
            this.numIdNo.TabIndex = 9;
            // 
            // numAffinity
            // 
            this.numAffinity.Location = new System.Drawing.Point(507, 128);
            this.numAffinity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAffinity.Name = "numAffinity";
            this.numAffinity.ReadOnly = true;
            this.numAffinity.Size = new System.Drawing.Size(58, 26);
            this.numAffinity.TabIndex = 17;
            // 
            // numStars
            // 
            this.numStars.Location = new System.Drawing.Point(375, 128);
            this.numStars.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numStars.Name = "numStars";
            this.numStars.ReadOnly = true;
            this.numStars.Size = new System.Drawing.Size(58, 26);
            this.numStars.TabIndex = 15;
            // 
            // numPower
            // 
            this.numPower.Location = new System.Drawing.Point(227, 128);
            this.numPower.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPower.Name = "numPower";
            this.numPower.ReadOnly = true;
            this.numPower.Size = new System.Drawing.Size(58, 26);
            this.numPower.TabIndex = 13;
            // 
            // numIndex
            // 
            this.numIndex.Location = new System.Drawing.Point(227, 78);
            this.numIndex.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIndex.Name = "numIndex";
            this.numIndex.ReadOnly = true;
            this.numIndex.Size = new System.Drawing.Size(58, 26);
            this.numIndex.TabIndex = 5;
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(72, 128);
            this.numLevel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.ReadOnly = true;
            this.numLevel.Size = new System.Drawing.Size(58, 26);
            this.numLevel.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(326, 28);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(231, 26);
            this.txtName.TabIndex = 1;
            // 
            // grpSkills
            // 
            this.grpSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSkills.Controls.Add(this.txtSkill4);
            this.grpSkills.Controls.Add(this.txtSkill3);
            this.grpSkills.Controls.Add(this.txtSkill2);
            this.grpSkills.Controls.Add(this.txtSkill1);
            this.grpSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSkills.Location = new System.Drawing.Point(419, 209);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(754, 121);
            this.grpSkills.TabIndex = 1;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Skills";
            // 
            // txtSkill4
            // 
            this.txtSkill4.Location = new System.Drawing.Point(568, 25);
            this.txtSkill4.MaxLength = 250;
            this.txtSkill4.Multiline = true;
            this.txtSkill4.Name = "txtSkill4";
            this.txtSkill4.ReadOnly = true;
            this.txtSkill4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkill4.Size = new System.Drawing.Size(174, 80);
            this.txtSkill4.TabIndex = 3;
            // 
            // txtSkill3
            // 
            this.txtSkill3.Location = new System.Drawing.Point(383, 25);
            this.txtSkill3.MaxLength = 250;
            this.txtSkill3.Multiline = true;
            this.txtSkill3.Name = "txtSkill3";
            this.txtSkill3.ReadOnly = true;
            this.txtSkill3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkill3.Size = new System.Drawing.Size(174, 80);
            this.txtSkill3.TabIndex = 2;
            // 
            // txtSkill2
            // 
            this.txtSkill2.Location = new System.Drawing.Point(198, 25);
            this.txtSkill2.MaxLength = 250;
            this.txtSkill2.Multiline = true;
            this.txtSkill2.Name = "txtSkill2";
            this.txtSkill2.ReadOnly = true;
            this.txtSkill2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkill2.Size = new System.Drawing.Size(174, 80);
            this.txtSkill2.TabIndex = 1;
            // 
            // txtSkill1
            // 
            this.txtSkill1.Location = new System.Drawing.Point(13, 25);
            this.txtSkill1.MaxLength = 250;
            this.txtSkill1.Multiline = true;
            this.txtSkill1.Name = "txtSkill1";
            this.txtSkill1.ReadOnly = true;
            this.txtSkill1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkill1.Size = new System.Drawing.Size(174, 80);
            this.txtSkill1.TabIndex = 0;
            // 
            // grpStrategy
            // 
            this.grpStrategy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpStrategy.Controls.Add(this.numTier);
            this.grpStrategy.Controls.Add(this.txtSinergy);
            this.grpStrategy.Controls.Add(this.lblSinergy);
            this.grpStrategy.Controls.Add(this.txtBuffs);
            this.grpStrategy.Controls.Add(this.lblBuffs);
            this.grpStrategy.Controls.Add(this.lblTier);
            this.grpStrategy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStrategy.Location = new System.Drawing.Point(419, 336);
            this.grpStrategy.Name = "grpStrategy";
            this.grpStrategy.Size = new System.Drawing.Size(754, 172);
            this.grpStrategy.TabIndex = 2;
            this.grpStrategy.TabStop = false;
            this.grpStrategy.Text = "Strategy";
            // 
            // numTier
            // 
            this.numTier.Location = new System.Drawing.Point(67, 25);
            this.numTier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTier.Name = "numTier";
            this.numTier.ReadOnly = true;
            this.numTier.Size = new System.Drawing.Size(58, 26);
            this.numTier.TabIndex = 1;
            // 
            // txtSinergy
            // 
            this.txtSinergy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSinergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinergy.Location = new System.Drawing.Point(507, 16);
            this.txtSinergy.MaxLength = 500;
            this.txtSinergy.Multiline = true;
            this.txtSinergy.Name = "txtSinergy";
            this.txtSinergy.ReadOnly = true;
            this.txtSinergy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSinergy.Size = new System.Drawing.Size(235, 150);
            this.txtSinergy.TabIndex = 5;
            // 
            // lblSinergy
            // 
            this.lblSinergy.AutoSize = true;
            this.lblSinergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinergy.Location = new System.Drawing.Point(439, 28);
            this.lblSinergy.Name = "lblSinergy";
            this.lblSinergy.Size = new System.Drawing.Size(66, 20);
            this.lblSinergy.TabIndex = 4;
            this.lblSinergy.Text = "Sinergy:";
            // 
            // txtBuffs
            // 
            this.txtBuffs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuffs.Location = new System.Drawing.Point(198, 16);
            this.txtBuffs.MaxLength = 500;
            this.txtBuffs.Multiline = true;
            this.txtBuffs.Name = "txtBuffs";
            this.txtBuffs.ReadOnly = true;
            this.txtBuffs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBuffs.Size = new System.Drawing.Size(235, 150);
            this.txtBuffs.TabIndex = 3;
            // 
            // lblBuffs
            // 
            this.lblBuffs.AutoSize = true;
            this.lblBuffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuffs.Location = new System.Drawing.Point(141, 28);
            this.lblBuffs.Name = "lblBuffs";
            this.lblBuffs.Size = new System.Drawing.Size(51, 20);
            this.lblBuffs.TabIndex = 2;
            this.lblBuffs.Text = "Buffs:";
            // 
            // lblTier
            // 
            this.lblTier.AutoSize = true;
            this.lblTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTier.Location = new System.Drawing.Point(22, 28);
            this.lblTier.Name = "lblTier";
            this.lblTier.Size = new System.Drawing.Size(39, 20);
            this.lblTier.TabIndex = 0;
            this.lblTier.Text = "Tier:";
            // 
            // grpEquipment
            // 
            this.grpEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEquipment.Controls.Add(this.txtEquipment5);
            this.grpEquipment.Controls.Add(this.txtEquipment4);
            this.grpEquipment.Controls.Add(this.txtEquipment3);
            this.grpEquipment.Controls.Add(this.txtEquipment2);
            this.grpEquipment.Controls.Add(this.txtEquipment1);
            this.grpEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEquipment.Location = new System.Drawing.Point(311, 514);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Size = new System.Drawing.Size(862, 121);
            this.grpEquipment.TabIndex = 3;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Equipment";
            // 
            // txtEquipment5
            // 
            this.txtEquipment5.Location = new System.Drawing.Point(684, 25);
            this.txtEquipment5.MaxLength = 150;
            this.txtEquipment5.Multiline = true;
            this.txtEquipment5.Name = "txtEquipment5";
            this.txtEquipment5.ReadOnly = true;
            this.txtEquipment5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquipment5.Size = new System.Drawing.Size(163, 80);
            this.txtEquipment5.TabIndex = 4;
            // 
            // txtEquipment4
            // 
            this.txtEquipment4.Location = new System.Drawing.Point(515, 25);
            this.txtEquipment4.MaxLength = 150;
            this.txtEquipment4.Multiline = true;
            this.txtEquipment4.Name = "txtEquipment4";
            this.txtEquipment4.ReadOnly = true;
            this.txtEquipment4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquipment4.Size = new System.Drawing.Size(163, 80);
            this.txtEquipment4.TabIndex = 3;
            // 
            // txtEquipment3
            // 
            this.txtEquipment3.Location = new System.Drawing.Point(346, 25);
            this.txtEquipment3.MaxLength = 150;
            this.txtEquipment3.Multiline = true;
            this.txtEquipment3.Name = "txtEquipment3";
            this.txtEquipment3.ReadOnly = true;
            this.txtEquipment3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquipment3.Size = new System.Drawing.Size(163, 80);
            this.txtEquipment3.TabIndex = 2;
            // 
            // txtEquipment2
            // 
            this.txtEquipment2.Location = new System.Drawing.Point(177, 25);
            this.txtEquipment2.MaxLength = 150;
            this.txtEquipment2.Multiline = true;
            this.txtEquipment2.Name = "txtEquipment2";
            this.txtEquipment2.ReadOnly = true;
            this.txtEquipment2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquipment2.Size = new System.Drawing.Size(163, 80);
            this.txtEquipment2.TabIndex = 1;
            // 
            // txtEquipment1
            // 
            this.txtEquipment1.Location = new System.Drawing.Point(8, 25);
            this.txtEquipment1.MaxLength = 150;
            this.txtEquipment1.Multiline = true;
            this.txtEquipment1.Name = "txtEquipment1";
            this.txtEquipment1.ReadOnly = true;
            this.txtEquipment1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEquipment1.Size = new System.Drawing.Size(163, 80);
            this.txtEquipment1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCharacterToolStripMenuItem,
            this.mnuFileDeleteCharacter,
            this.closeWindowToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // saveCharacterToolStripMenuItem
            // 
            this.saveCharacterToolStripMenuItem.Name = "saveCharacterToolStripMenuItem";
            this.saveCharacterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCharacterToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.saveCharacterToolStripMenuItem.Text = "&Save Character";
            this.saveCharacterToolStripMenuItem.Click += new System.EventHandler(this.saveCharacterToolStripMenuItem_Click);
            // 
            // mnuFileDeleteCharacter
            // 
            this.mnuFileDeleteCharacter.Name = "mnuFileDeleteCharacter";
            this.mnuFileDeleteCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuFileDeleteCharacter.Size = new System.Drawing.Size(203, 22);
            this.mnuFileDeleteCharacter.Text = "&Delete Character";
            this.mnuFileDeleteCharacter.Click += new System.EventHandler(this.mnuFileDeleteCharacter_Click);
            // 
            // closeWindowToolStripMenuItem
            // 
            this.closeWindowToolStripMenuItem.Name = "closeWindowToolStripMenuItem";
            this.closeWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeWindowToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.closeWindowToolStripMenuItem.Text = "Close &Window";
            this.closeWindowToolStripMenuItem.Click += new System.EventHandler(this.closeWindowToolStripMenuItem_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditEditCharacter,
            this.selectMainPictureToolStripMenuItem,
            this.selectChibiPictureToolStripMenuItem,
            this.emptyBasicInformationToolStripMenuItem,
            this.emptySkillsToolStripMenuItem,
            this.emptyStrategyToolStripMenuItem,
            this.mnuEditEmptyEquipment});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditEditCharacter
            // 
            this.mnuEditEditCharacter.Name = "mnuEditEditCharacter";
            this.mnuEditEditCharacter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEditEditCharacter.Size = new System.Drawing.Size(204, 22);
            this.mnuEditEditCharacter.Text = "&Edit Character";
            this.mnuEditEditCharacter.Click += new System.EventHandler(this.mnuEditEditCharacter_Click);
            // 
            // selectMainPictureToolStripMenuItem
            // 
            this.selectMainPictureToolStripMenuItem.Name = "selectMainPictureToolStripMenuItem";
            this.selectMainPictureToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.selectMainPictureToolStripMenuItem.Text = "Select &Main Picture";
            this.selectMainPictureToolStripMenuItem.Click += new System.EventHandler(this.selectMainPictureToolStripMenuItem_Click);
            // 
            // selectChibiPictureToolStripMenuItem
            // 
            this.selectChibiPictureToolStripMenuItem.Name = "selectChibiPictureToolStripMenuItem";
            this.selectChibiPictureToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.selectChibiPictureToolStripMenuItem.Text = "Select &Chibi Picture";
            this.selectChibiPictureToolStripMenuItem.Click += new System.EventHandler(this.selectChibiPictureToolStripMenuItem_Click);
            // 
            // emptyBasicInformationToolStripMenuItem
            // 
            this.emptyBasicInformationToolStripMenuItem.Name = "emptyBasicInformationToolStripMenuItem";
            this.emptyBasicInformationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.emptyBasicInformationToolStripMenuItem.Text = "Empty &Basic Information";
            this.emptyBasicInformationToolStripMenuItem.Click += new System.EventHandler(this.emptyBasicInformationToolStripMenuItem_Click);
            // 
            // emptySkillsToolStripMenuItem
            // 
            this.emptySkillsToolStripMenuItem.Name = "emptySkillsToolStripMenuItem";
            this.emptySkillsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.emptySkillsToolStripMenuItem.Text = "Empty S&kills";
            this.emptySkillsToolStripMenuItem.Click += new System.EventHandler(this.emptySkillsToolStripMenuItem_Click);
            // 
            // emptyStrategyToolStripMenuItem
            // 
            this.emptyStrategyToolStripMenuItem.Name = "emptyStrategyToolStripMenuItem";
            this.emptyStrategyToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.emptyStrategyToolStripMenuItem.Text = "Empty S&trategy";
            this.emptyStrategyToolStripMenuItem.Click += new System.EventHandler(this.emptyStrategyToolStripMenuItem_Click);
            // 
            // mnuEditEmptyEquipment
            // 
            this.mnuEditEmptyEquipment.Name = "mnuEditEmptyEquipment";
            this.mnuEditEmptyEquipment.Size = new System.Drawing.Size(204, 22);
            this.mnuEditEmptyEquipment.Text = "Empty E&quipment";
            this.mnuEditEmptyEquipment.Click += new System.EventHandler(this.mnuEditEmptyEquipment_Click);
            // 
            // picChibi
            // 
            this.picChibi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picChibi.BackColor = System.Drawing.Color.Transparent;
            this.picChibi.Location = new System.Drawing.Point(13, 450);
            this.picChibi.Name = "picChibi";
            this.picChibi.Size = new System.Drawing.Size(200, 200);
            this.picChibi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChibi.TabIndex = 1;
            this.picChibi.TabStop = false;
            // 
            // frmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.grpEquipment);
            this.Controls.Add(this.grpStrategy);
            this.Controls.Add(this.grpSkills);
            this.Controls.Add(this.grpBasicInformation);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.picChibi);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(845, 620);
            this.Name = "frmCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Character Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCharacter_FormClosing);
            this.Load += new System.EventHandler(this.frmCharacter_Load);
            this.Resize += new System.EventHandler(this.frmCharacter_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.grpBasicInformation.ResumeLayout(false);
            this.grpBasicInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAffinity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.grpStrategy.ResumeLayout(false);
            this.grpStrategy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTier)).EndInit();
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChibi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblFaction;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtRarity;
        private System.Windows.Forms.TextBox txtFaction;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblAffinity;
        private System.Windows.Forms.Label lblCharacterRanking;
        private System.Windows.Forms.GroupBox grpBasicInformation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpSkills;
        private System.Windows.Forms.TextBox txtSkill4;
        private System.Windows.Forms.TextBox txtSkill3;
        private System.Windows.Forms.TextBox txtSkill2;
        private System.Windows.Forms.TextBox txtSkill1;
        private System.Windows.Forms.GroupBox grpStrategy;
        private System.Windows.Forms.Label lblSinergy;
        private System.Windows.Forms.TextBox txtBuffs;
        private System.Windows.Forms.Label lblBuffs;
        private System.Windows.Forms.Label lblTier;
        private System.Windows.Forms.TextBox txtSinergy;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.TextBox txtEquipment5;
        private System.Windows.Forms.TextBox txtEquipment4;
        private System.Windows.Forms.TextBox txtEquipment3;
        private System.Windows.Forms.TextBox txtEquipment2;
        private System.Windows.Forms.TextBox txtEquipment1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEditCharacter;
        private System.Windows.Forms.ToolStripMenuItem mnuFileDeleteCharacter;
        private System.Windows.Forms.ToolStripMenuItem mnuEditEmptyEquipment;
        private System.Windows.Forms.ToolStripMenuItem saveCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectMainPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectChibiPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptySkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyStrategyToolStripMenuItem;
        private System.Windows.Forms.PictureBox picChibi;
        private System.Windows.Forms.ToolStripMenuItem closeWindowToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numRanking;
        private System.Windows.Forms.NumericUpDown numIdNo;
        private System.Windows.Forms.NumericUpDown numAffinity;
        private System.Windows.Forms.NumericUpDown numStars;
        private System.Windows.Forms.NumericUpDown numPower;
        private System.Windows.Forms.NumericUpDown numIndex;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.NumericUpDown numTier;
        private System.Windows.Forms.ToolStripMenuItem emptyBasicInformationToolStripMenuItem;
    }
}