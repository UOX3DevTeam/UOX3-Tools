using System;
using System.Windows.Forms;
using UOXData;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;

namespace UOX3_INI_Editor
{
	public partial class INIEditor : Form
	{
        Dictionary< string, ControlData > iniControls;
        Dictionary<SectionNames, ArrayList> sectionTags;

		public INIEditor()
		{
			InitializeComponent();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*";
            openFileDialog1.FileName = "uox.ini";

            saveFileDialog1.Filter = "INI Files (*.ini)|*.ini|All Files (*.*)|*.*";

            iniControls = new Dictionary<string, ControlData>();
            sectionTags = new Dictionary<SectionNames, ArrayList>();
            for (SectionNames s = SectionNames.system; s != SectionNames.COUNT; ++s)
            {
                sectionTags.Add(s, new ArrayList());
            }

            #region CheckBoxes
            AddTag("ADVANCEDPATHFINDING", SectionNames.settings, "chkAdvPathfind");
            AddTag("AMBIENTFOOTSTEPS", SectionNames.settings, "chkAmbientFootsteps");
            AddTag("ANIMALSGUARDED", SectionNames.combat, "chkAnimalsGuarded");
            AddTag("ANNOUNCEWORLDSAVES", SectionNames.system, "chkAnnSave");
            AddTag("ARMORAFFECTMANAREGEN", SectionNames.skills, "chkArmorAffectRegen");
            AddTag("BACKUPSENABLED", SectionNames.system, "chkBackup");
            AddTag("CONSOLELOG", SectionNames.system, "chkLogConsole");
            AddTag("CRASHPROTECTION", SectionNames.system, "chkCrashProtect");
            AddTag("CUTSCROLLREQUIREMENTS", SectionNames.skills, "chkScrollSkill");
            AddTag("DEATHANIMATION", SectionNames.settings, "chkDeathAnim");
            AddTag("DISPLAYHITMSG", SectionNames.combat, "chkHitMessage");
            AddTag("ESCORTENABLED", SectionNames.escorts, "chkEscorts");
            AddTag("GUARDSACTIVE", SectionNames.settings, "chkGuards");
            AddTag("HIDEWILEMOUNTED", SectionNames.settings, "chkHideWhileMounted");
            AddTag("INTERNALACCOUNTCREATION", SectionNames.settings, "chkAutoAccount");
            AddTag("JOINPARTMSGS", SectionNames.system, "chkAnnLog");
            AddTag("LOOTDECAYSWITHCORPSE", SectionNames.settings, "chkLootDecay");
            AddTag("MONSTERSVSANIMALS", SectionNames.combat, "chkMonsterVsAnimals");
            AddTag("NPCTRAININGENABLED", SectionNames.settings, "chkNPCTrain");
            AddTag("OVERLOADPACKETS", SectionNames.settings, "chkOverloadPackets");
            AddTag("PETHUNGEROFFLINE", SectionNames.hunger, "chkPetHungerOffline");
            AddTag("PLAYERPERSECUTION", SectionNames.settings, "chkPersecute");
            AddTag("RANKSYSTEM", SectionNames.settings, "chkAdvCrafting");
            AddTag("SELLBYNAME", SectionNames.settings, "chkSellByName");
            AddTag("SHOOTONANIMALBACK", SectionNames.combat, "chkArcheryOnMount");
            AddTag("SHOWOFFLINEPCS", SectionNames.settings, "chkShowOfflinePCs");
            AddTag("SNOOPISCRIME", SectionNames.skills, "chkSnoopIsCrime");
            AddTag("TRADESYSTEM", SectionNames.settings, "chkAdvTrade");
            #endregion
            #region ComboBoxes
            AddTag("AMBIENTSOUNDS", SectionNames.settings, "comboAmbientSound");
            AddTag("MINECHECK", SectionNames.resources, "comboMineCheck");
            AddTag("SKILLLEVEL", SectionNames.skills, "comboCraftDiff");
            #endregion
            #region TextBoxes
            AddTag("ANIMALATTACKCHANCE", SectionNames.combat, "mtxtAnimalAttChance");
            AddTag("ARCHERRANGE", SectionNames.combat, "mtxtArcheryRange");
            AddTag("ATTACKSTAMINA", SectionNames.combat, "mtxtStamPerHit");
            AddTag("BACKUPSAVERATIO", SectionNames.system, "mtxtBackupRatio");
            AddTag("BASERANGE", SectionNames.tracking, "mtxtTrackBaseRange");
            AddTag("BRIGHTLEVEL", SectionNames.worldlight, "mtxtBrightLight");
            AddTag("COMMANDPREFIX", SectionNames.system, "txtPrefix");
            AddTag("DARKLEVEL", SectionNames.worldlight, "mtxtDarkLight");
            AddTag("DUNGEONLEVEL", SectionNames.worldlight, "mtxtDungeonLight");
            AddTag("HUNGERDMGVAL", SectionNames.hunger, "mtxtHungerDmg");
            AddTag("LOGSPERAREA", SectionNames.resources, "mtxtMaxLogs");
            AddTag("LOGSRESPAWNAREA", SectionNames.resources, "mtxtLogArea");
            AddTag("MAXSTAMINAMOVEMENTS", SectionNames.skills, "mtxtMaxStaminaMove");
            AddTag("MAXSTEALTHMOVEMENTS", SectionNames.skills, "mtxtMaxStealthMove");
            AddTag("MAXKILLS", SectionNames.reputation, "mtxtMaxKills");
            AddTag("MAXRANGE", SectionNames.combat, "mtxtCombatRange");
            AddTag("MAXTARGETS", SectionNames.tracking, "mtxtTrackMaxTarg");
            AddTag("NPCBASEFLEEAT", SectionNames.combat, "mtxtFleeAt");
            AddTag("NPCBASEREATTACKAT", SectionNames.combat, "mtxtReAttackAt");
            AddTag("NPCDAMAGERATE", SectionNames.combat, "mtxtNPCDmgRate");
            AddTag("OREPERAREA", SectionNames.resources, "mtxtMaxOre");
            AddTag("ORERESPAWNAREA", SectionNames.resources, "mtxtOreArea");
            AddTag("PETOFFLINETIMEOUT", SectionNames.hunger, "mtxtPetOfflineTimeout");
            AddTag("PORT", SectionNames.system, "mtxtLSPort");
            AddTag("SECONDSPERUOMINUTE", SectionNames.worldlight, "mtxtSecondsPerUOMin");
            AddTag("SELLMAXITEMS", SectionNames.settings, "mtxtMaxSellItems");
            AddTag("SKILLCAP", SectionNames.skills, "mtxtSkillCap");
            AddTag("SPELLMAXRANGE", SectionNames.combat, "mtxtMagicRange");
            AddTag("STATCAP", SectionNames.skills, "mtxtStatCap");
            AddTag("WEIGHTPERSTR", SectionNames.settings, "mtxtWeightPerSTR");
            #endregion
            #region DataGrids
            AddTag("ACCOUNTFLUSH", SectionNames.settings, "dataGridSpeed", "Online Accounts");
            AddTag("BASEFISHINGTIMER", SectionNames.timers, "dataGridTimers", "Base Fishing Delay");
            AddTag("BASETIMER", SectionNames.tracking, "dataGridTimers", "Min Tracking Duration");
            AddTag("CHECKBOATS", SectionNames.speedup, "dataGridSpeed", "Boats");
            AddTag("CHECKITEMS", SectionNames.speedup, "dataGridSpeed", "Items");
            AddTag("CHECKNPCAI", SectionNames.speedup, "dataGridSpeed", "NPC AI");
            AddTag("CHECKSPAWNREGIONS", SectionNames.speedup, "dataGridSpeed", "Spawn Regions");
            AddTag("CORPSEDECAYTIMER", SectionNames.timers, "dataGridTimers", "Corpse Decay");
            AddTag("CRIMINALTIMER", SectionNames.reputation, "dataGridTimers", "Criminal Duration");
            AddTag("DECAYTIMER", SectionNames.timers, "dataGridTimers", "Item Decay");
            AddTag("ESCORTACTIVEEXPIRE", SectionNames.escorts, "dataGridTimers", "Escort Time Limit");
            AddTag("ESCORTDONEEXPIRE", SectionNames.escorts, "dataGridTimers", "Completed Escort Decay");
            AddTag("ESCORTINITEXPIRE", SectionNames.escorts, "dataGridTimers", "New Escort Decay");
            AddTag("GATETIMER", SectionNames.timers, "dataGridTimers", "Moongate Duration");
            AddTag("GUARDSPAID", SectionNames.towns, "dataGridTimers", "Town Guard Pay Interval");
            AddTag("HITPOINTREGENTIMER", SectionNames.timers, "dataGridTimers", "Hitpoint Regen Interval");
            AddTag("HUNGERRATE", SectionNames.hunger, "dataGridTimers", "Hunger Interval");
            AddTag("INVISIBILITYTIMER", SectionNames.timers, "dataGridTimers", "Invisibility Duration");
            AddTag("LOGINTIMEOUT", SectionNames.timers, "dataGridTimers", "Idle Timeout");
            AddTag("LOGSRESPAWNTIMER", SectionNames.resources, "dataGridTimers", "Log Respawn");
            AddTag("MANAREGENTIMER", SectionNames.timers, "dataGridTimers", "Mana Regen Interval");
            AddTag("MAYORTIME", SectionNames.towns, "dataGridTimers", "Town Mayor Term");
            AddTag("MSGREDISPLAYTIME", SectionNames.tracking, "dataGridTimers", "Tracking Message");
            AddTag("MURDERDECAYTIMER", SectionNames.reputation, "dataGridTimers", "Murder Decay");
            AddTag("NPCMOVEMENTSPEED", SectionNames.speedup, "dataGridSpeed", "NPC Movement");
            AddTag("OBJECTUSETIMER", SectionNames.timers, "dataGridTimers", "Object Delay");
            AddTag("ORERESPAWNTIMER", SectionNames.resources, "dataGridTimers", "Ore Respawn");
            AddTag("PETOFFLINECHECKTIMER", SectionNames.timers, "dataGridSpeed", "Offline Player's Pets");
            AddTag("POISONTIMER", SectionNames.timers, "dataGridTimers", "Poison Duration");
            AddTag("POLLTIME", SectionNames.towns, "dataGridTimers", "Town Poll Duration");
            AddTag("POLYDURATION", SectionNames.settings, "dataGridTimers", "Polymorph Duration");
            AddTag("RANDOMFISHINGTIMER", SectionNames.timers, "dataGridTimers", "Random Fishing Delay");
            AddTag("SAVESTIMER", SectionNames.system, "dataGridTimers", "Auto Worldsave Interval");
            AddTag("SHOPSPAWNTIMER", SectionNames.timers, "dataGridTimers", "Shop Restock Interval");
            AddTag("SKILLDELAY", SectionNames.skills, "dataGridTimers", "Skill Delay");
            AddTag("SPIRITSPEAKTIMER", SectionNames.timers, "dataGridTimers", "Spirit Speak Duration");
            AddTag("STAMINAREGENTIMER", SectionNames.timers, "dataGridTimers", "Stamina Regen Interval");
            AddTag("TAXPERIOD", SectionNames.towns, "dataGridTimers", "Town Tax Interval");
            AddTag("WEATHERTIMER", SectionNames.timers, "dataGridSpeed", "Weather");
            #endregion
        }

        public void AddTag(string mTag, SectionNames mSectType, string mCont, string mDesc)
        {
            iniControls.Add(mTag, new ControlData(mCont, mDesc));
            sectionTags[mSectType].Add(mTag);
        }

        public void AddTag(string mTag, SectionNames mSectType, string mCont)
        {
            iniControls.Add(mTag, new ControlData(mCont));
            sectionTags[mSectType].Add(mTag);
        }

        private void dataGridDirectories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            folderBrowserDialog1.Description = "Select the new directory.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dataGridDirectories.SelectedRows.Count > 0)
                {
                    DataGridViewRow sRow = dataGridDirectories.SelectedRows[0];
                    if (sRow.Cells.Count > 1)
                    {
                        sRow.Cells[1].Value = folderBrowserDialog1.SelectedPath;
                        lblFile.Select();
                    }
                }
            }
        }

        private void comboGumpText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( comboGumpText.SelectedIndex > -1 && comboGumpText.SelectedIndex < gumpText.Length )
                mtxtGumpText.Text = gumpText[comboGumpText.SelectedIndex].ToString();
        }

        private void comboGumpButtons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboGumpButtons.SelectedIndex > -1 && comboGumpButtons.SelectedIndex < gumpButtons.Length)
                mtxtGumpButtons.Text = gumpButtons[comboGumpButtons.SelectedIndex].ToString();
        }

        private void chkBackup_CheckedChanged(object sender, EventArgs e)
        {
            mtxtBackupRatio.ReadOnly = !chkBackup.Checked;
        }

        private void chkMonsterVsAnimals_CheckedChanged(object sender, EventArgs e)
        {
            mtxtAnimalAttChance.ReadOnly = !chkMonsterVsAnimals.Checked;
        }

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
            if (Path.GetFileName(txtINIFile.Text) != "")
                openFileDialog1.FileName = txtINIFile.Text;
            else if (Directory.Exists(txtINIFile.Text))
                openFileDialog1.InitialDirectory = txtINIFile.Text;

			if( openFileDialog1.ShowDialog() == DialogResult.OK )
			{
                ClearControlValues(this);

				string fileName = openFileDialog1.FileName;
				txtINIFile.Text = fileName;

                UOXData.Script.UOXIni iniFile = new UOXData.Script.UOXIni(fileName);

                foreach (UOXData.Script.ScriptSection mSect in iniFile.Sections)
				{
					if( mSect.SectionName == "play server list" )
					{
						foreach (UOXData.Script.TagDataPair sRow in mSect.TagDataPairs)
						{
							dataGridServers.Rows.Add(sRow.Data.ToString().Split(",".ToCharArray()));
						}
					}
					else if( mSect.SectionName == "start locations" )
					{
						foreach (UOXData.Script.TagDataPair lRow in mSect.TagDataPairs)
						{
							dataGridLocations.Rows.Add(lRow.Data.ToString().Split(",".ToCharArray()));
						}
					}
					else if( mSect.SectionName == "directories" )
					{
						for (UOXData.Script.UOXIni.DirectoryPaths dPath = UOXData.Script.UOXIni.DirectoryPaths.Root; dPath != UOXData.Script.UOXIni.DirectoryPaths.COUNT; ++dPath)
						{
							dataGridDirectories.Rows.Add(dPath.ToString(), iniFile.Directory(dPath));
						}
					}
					else
					{
						foreach( UOXData.Script.TagDataPair mPair in mSect.TagDataPairs )
						{
                            try
                            {
                                ControlData mControl = iniControls[mPair.Tag.ToString()];
                                Control ctrl = Controls.Find(mControl.CtrlName, true)[0];
                                if( ctrl.GetType() == typeof(CheckBox))
                                    ((CheckBox)ctrl).Checked = (mPair.Data.ToInt08() == 1);
                                else if( ctrl.GetType() == typeof(ComboBox))
                                {
                                    int aSound = mPair.Data.ToInt08();
                                    if (aSound < ((ComboBox)ctrl).Items.Count)
                                        ((ComboBox)ctrl).SelectedIndex = aSound;
                                }
                                else if( ctrl.GetType() == typeof(DataGridView))
                                    ((DataGridView)ctrl).Rows.Add(mControl.CtrlDesc, mPair.Data.ToString());
                                else if( ctrl.GetType() == typeof(MaskedTextBox))
                                    ((MaskedTextBox)ctrl).Text = mPair.Data.ToString();
                                else if( ctrl.GetType() == typeof(RadioButton))
                                    ((RadioButton)ctrl).Checked = (mPair.Data.ToInt08() == 1);
                                else if( ctrl.GetType() == typeof(TextBox))
                                    ((TextBox)ctrl).Text = mPair.Data.ToString();
                            }
                            catch (KeyNotFoundException)
                            {
                                switch (mPair.Tag.ToString())
                                {
                                    case "BACKGROUNDPIC":
                                        mtxtGumpBackground.Text = mPair.Data.ToString();
                                        break;
                                    case "BUTTONCANCEL":
                                        gumpButtons[0] = mPair.Data.ToUInt16();
                                        break;
                                    case "BUTTONLEFT":
                                        gumpButtons[1] = mPair.Data.ToUInt16();
                                        break;
                                    case "BUTTONRIGHT":
                                        gumpButtons[2] = mPair.Data.ToUInt16();
                                        break;
                                    case "LEFTTEXTCOLOUR":
                                        gumpText[1] = mPair.Data.ToUInt16();
                                        break;
                                    case "RIGHTTEXTCOLOUR":
                                        gumpText[2] = mPair.Data.ToUInt16();
                                        break;
                                    case "STARTGOLD":
                                        mtxtStartGold.Text = mPair.Data.ToString();
                                        break;
                                    case "STARTPRIVS":
                                        BitVector32 sPriv = new BitVector32(mPair.Data.ToUInt16());
                                        int mask = BitVector32.CreateMask();
                                        for (StartPrivs bEnum = StartPrivs.GM; bEnum < StartPrivs.COUNT; ++bEnum)
                                        {
                                            dataGridPrivs.Rows.Add(bEnum.ToString().Replace("_", " "), sPriv[mask]);
                                            mask = BitVector32.CreateMask(mask);
                                        }
                                        break;
                                    case "TITLECOLOUR":
                                        gumpText[0] = mPair.Data.ToUInt16();
                                        break;
                                }
                            }
						}
					}
				}
				comboGumpText.SelectedIndex = 0;
				comboGumpButtons.SelectedIndex = 0;
			}
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
            string saveAs = Directory.GetCurrentDirectory() + "\\uox.ini";
            if( Path.GetFileName( openFileDialog1.FileName ) != "" )
                saveAs = openFileDialog1.FileName;

            DoSave(saveAs);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            string saveAs = Directory.GetCurrentDirectory() + "\\uox.ini";
            if( Path.GetFileName( openFileDialog1.FileName ) != "" )
                saveAs = openFileDialog1.FileName ;

            saveFileDialog1.FileName = saveAs;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.FileName = saveFileDialog1.FileName;
                DoSave(saveFileDialog1.FileName);
            }
        }

        private void DoSave(string path)
        {
            txtINIFile.Text = path;

            StreamWriter iniOut = new StreamWriter(path);

            SaveSection(iniOut, "play server list", dataGridServers, "SERVERLIST");

            iniOut.WriteLine("[directories]");
            iniOut.WriteLine("{");
            foreach (DataGridViewRow dgRow in dataGridDirectories.Rows)
            {
                if (dgRow.Cells.Count > 1)
                {
                    string tag = GetDirectoryTag(dgRow.Cells[0].Value.ToString());
                    iniOut.WriteLine(tag + "=" + dgRow.Cells[1].Value.ToString());
                }
            }
            iniOut.WriteLine("}");
            iniOut.WriteLine();

            for (SectionNames s = SectionNames.system; s != SectionNames.COUNT; ++s)
            {
                SaveSection(iniOut, s);
            }

            SaveSection(iniOut, "start locations", dataGridLocations, "LOCATION");

            BitVector32 sPriv = new BitVector32(0);
            int mask = BitVector32.CreateMask();
            foreach (DataGridViewRow dgRow in dataGridPrivs.Rows)
            {
                sPriv[mask] = (bool)dgRow.Cells[1].Value;
                mask = BitVector32.CreateMask(mask);
            }

            iniOut.WriteLine("[startup]");
            iniOut.WriteLine("{");
            iniOut.WriteLine("STARTGOLD=" + mtxtStartGold.Text);
            iniOut.WriteLine("STARTPRIVS=" + UOXData.Conversion.ToHexString((ushort)sPriv.Data));
            iniOut.WriteLine("}");
            iniOut.WriteLine();

            iniOut.WriteLine("[gumps]");
            iniOut.WriteLine("{");
            iniOut.WriteLine("BACKGROUNDPIC=" + mtxtGumpBackground.Text);
            iniOut.WriteLine("BUTTONCANCEL=" + gumpButtons[0].ToString());
            iniOut.WriteLine("BUTTONLEFT=" + gumpButtons[1].ToString());
            iniOut.WriteLine("BUTTONRIGHT=" + gumpButtons[2].ToString());
            iniOut.WriteLine("LEFTTEXTCOLOUR=" + gumpText[1].ToString());
            iniOut.WriteLine("RIGHTTEXTCOLOUR=" + gumpText[2].ToString());
            iniOut.WriteLine("TITLECOLOUR=" + gumpText[0].ToString());
            iniOut.WriteLine("}");
            iniOut.WriteLine();

            iniOut.WriteLine();
            iniOut.Close();
        }

        private string GetDirectoryTag(string dgRowName)
        {
            string retVal = "";
            switch (dgRowName)
            {
                case "Root":
                    retVal = "DIRECTORY";
                    break;
                case "Data":
                    retVal = "DATADIRECTORY";
                    break;
                case "Definitions":
                    retVal = "DEFSDIRECTORY";
                    break;
                case "Access":
                    retVal = "ACCESSDIRECTORY";
                    break;
                case "Accounts":
                    retVal = "ACTSDIRECTORY";
                    break;
                case "Scripts":
                    retVal = "SCRIPTSDIRECTORY";
                    break;
                case "Backup":
                    retVal = "BACKUPDIRECTORY";
                    break;
                case "Msgboard":
                    retVal = "MSGBOARDDIRECTORY";
                    break;
                case "Shared":
                    retVal = "SHAREDDIRECTORY";
                    break;
                case "HTML":
                    retVal = "HTMLDIRECTORY";
                    break;
                case "Logs":
                    retVal = "LOGSDIRECTORY";
                    break;
                case "Dictionaries":
                    retVal = "DICTIONARYDIRECTORY";
                    break;
                case "Books":
                    retVal = "BOOKSDIRECTORY";
                    break;
            }
            return retVal;
        }

        private void SaveSection(StreamWriter iniOut, string sectName, System.Windows.Forms.DataGridView dgCont, string tag )
        {
            iniOut.WriteLine("[" + sectName + "]");
            iniOut.WriteLine("{");
            foreach (DataGridViewRow dgRow in dgCont.Rows)
            {
                string data = "";
                foreach (DataGridViewCell dgCell in dgRow.Cells)
                {
                    if (dgCell.Value != null)
                    {
                        data += dgCell.Value.ToString() + ",";
                    }
                }
                if (data != "")
                    iniOut.WriteLine(tag + "=" + data.TrimEnd(",".ToCharArray()));
            }
            iniOut.WriteLine("}");
            iniOut.WriteLine();
        }
        private void SaveSection( StreamWriter iniOut, SectionNames sect )
        {
            iniOut.WriteLine("[" + sect.ToString().Replace( "_", " " ) + "]");
            iniOut.WriteLine("{");
            foreach (string t in sectionTags[sect])
            {
                iniOut.WriteLine(t + "=" + GetValue(t));
            }
            iniOut.WriteLine("}");
            iniOut.WriteLine();
        }

        private string GetValue(string tagName)
        {
            string retVal = "";
            ControlData cData = iniControls[tagName];
            string ctrlName = cData.CtrlName;
            Control ctrl = Controls.Find(ctrlName, true)[0];
            if (ctrl.GetType() == typeof(CheckBox))
                retVal = (((CheckBox)ctrl).Checked ? "1" : "0" );
            else if (ctrl.GetType() == typeof(ComboBox))
                retVal = ((ComboBox)ctrl).SelectedIndex.ToString();
            else if (ctrl.GetType() == typeof(DataGridView))
            {
                foreach (DataGridViewRow dgRow in ((DataGridView)ctrl).Rows)
                {
                    if (dgRow.Cells.Count > 1)
                    {
                        if (dgRow.Cells[0].Value.ToString() == cData.CtrlDesc)
                        {
                            retVal = dgRow.Cells[1].Value.ToString();
                            break;
                        }
                    }
                }
            }
            else if (ctrl.GetType() == typeof(MaskedTextBox))
                retVal = ((MaskedTextBox)ctrl).Text;
            else if (ctrl.GetType() == typeof(RadioButton))
                retVal = (((RadioButton)ctrl).Checked ? "1" : "0" );
            else if (ctrl.GetType() == typeof(TextBox))
                retVal = ((TextBox)ctrl).Text;

            return retVal;
        }

        private class ControlData
        {
            protected string ctrlName;
            protected string ctrlDesc;

            public string CtrlName { get { return ctrlName; } set { ctrlName = value; } }
            public string CtrlDesc { get { return ctrlDesc; } set { ctrlDesc = value; } }

            public ControlData(string cName)
                : this()
            {
                ctrlName = cName;
            }

            public ControlData(string cName, string cDesc)
                : this(cName)
            {
                ctrlDesc = cDesc;
            }

            public ControlData()
            {
                ctrlName = "";
                ctrlDesc = "";
            }
        }

        public enum StartPrivs
        {
            GM = 1,
            Broadcast,
            Invulnerable,
            Show_Serials,
            Skill_Titles,
            GM_Pageable,
            Snoop,
            Counselor,
            AllMove,
            Frozen,
            View_House_As_Icon,
            Cast_Without_Mana,
            Dispellable,
            Permanent_Magic_Reflect,
            Cast_Without_Reagents,
            COUNT
        }

        public enum SectionNames
        {
            system = 0,
            skills,
            timers,
            settings,
            speedup,
            escorts,
            worldlight,
            tracking,
            reputation,
            resources,
            hunger,
            combat,
            towns,
            COUNT
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            ClearControlValues(this);
        }

        public void ClearControlValues(System.Windows.Forms.Control Container)
        {
            try
            {
                foreach (Control ctrl in Container.Controls)
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ((TextBox)ctrl).Text = "";
                    else if (ctrl.GetType() == typeof(MaskedTextBox))
                        ((MaskedTextBox)ctrl).Text = "";
                    else if (ctrl.GetType() == typeof(ComboBox))
                        ((ComboBox)ctrl).SelectedIndex = -1;
                    else if (ctrl.GetType() == typeof(CheckBox))
                        ((CheckBox)ctrl).Checked = false;
                    else if (ctrl.GetType() == typeof(DataGridView))
                        ((DataGridView)ctrl).Rows.Clear();
                    else if (ctrl.Controls.Count > 0)
                        ClearControlValues(ctrl);
                }
                for (byte i = 0; i < 3; ++i)
                {
                    gumpText[i] = 0;
                    gumpButtons[i] = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
	}
}