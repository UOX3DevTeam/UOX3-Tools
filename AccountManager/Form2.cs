using System;
using System.Windows.Forms;
using UOXData;

namespace AccountManager
{
	public partial class CharacterEditor : Form
	{
		private AccountObject assocAcct;
		private SlotObject selSlot;
		private OrphanObject selOrph;

		public CharacterEditor()
		{
			assocAcct	= null;
			selSlot		= null;
			selOrph		= null;
			InitializeComponent();
		}

		private void btnCharHide_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void cbBlockSlot_CheckedChanged(object sender, EventArgs e)
		{
			if( selSlot != null && assocAcct != null && listCharacters.Items.Count > 0 )
			{
				ushort flag = (ushort)Math.Pow( 2, (4 + listCharacters.SelectedIndex) );
				assocAcct.SetFlag( flag, cbBlockSlot.Checked );
			}
		}

		public void Clear()
		{
			assocAcct = null;
			selSlot = null;
			selOrph = null;

			listCharacters.Items.Clear();
			listCharacters.Update();
			txtCharName.Clear();
			txtCharSer.Clear();
			cbBlockSlot.Checked = false;
			listOrphans.Items.Clear();
			listOrphans.Update();
			txtOrphName.Clear();
			txtOrphSerial.Clear();
			btnRestore.Enabled = false;
		}

		public void UpdateList( AccountObject toDisp )
		{
			listCharacters.Items.Clear();
			listCharacters.Update();

			assocAcct = toDisp;
			foreach( SlotObject slotObj in toDisp.CharSlots )
			{
				listCharacters.Items.Add( slotObj.Name );
			}

			if( listCharacters.Items.Count > 0 )
				listCharacters.SelectedIndex = 0;

			listOrphans.Items.Clear();
			listOrphans.Update();
			txtOrphName.Clear();
			txtOrphSerial.Clear();
			btnRestore.Enabled = false;

			foreach( SlotObject orphObj in toDisp.OrphanChars )
			{
				listOrphans.Items.Add( orphObj.Name );
			}
		}

		private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
		{
			selSlot = null;
			cbBlockSlot.Checked = false;
			if( assocAcct == null || listCharacters.Items.Count <= 0 || listCharacters.SelectedIndex == -1 )
			{
				txtCharName.Clear();
				txtCharSer.Clear();
				btnRestore.Enabled = false;
				return;
			}

			int index			= listCharacters.SelectedIndex;
			SlotObject tmpSlot  = assocAcct.CharSlots[index];
			txtCharName.Text	= tmpSlot.Name;
			txtCharSer.Text		= UOXData.Conversion.ToHexString( tmpSlot.Serial );
			ushort flag			= (ushort)Math.Pow( 2, (4 + index) );
			if( (assocAcct.Flags&flag) == flag )
				cbBlockSlot.Checked = true;

			if( listOrphans.SelectedIndex != -1 )
				btnRestore.Enabled = true;

			selSlot				= tmpSlot;
		}

		private void txtCharSer_TextChanged(object sender, EventArgs e)
		{
			if( selSlot != null )
			{
				if( txtCharSer.Text.Length > 0 )
					selSlot.Serial = UOXData.Conversion.ToUInt32( txtCharSer.Text );
				else
					selSlot.Serial = 0xFFFFFFFF;
			}
		}

		private void listOrphans_SelectedIndexChanged(object sender, EventArgs e)
		{
			selOrph = null;
			if (assocAcct == null || listOrphans.Items.Count <= 0 || listOrphans.SelectedIndex == -1)
			{
				txtOrphName.Clear();
				txtOrphSerial.Clear();
				btnRestore.Enabled = false;
				return;
			}

			int index = listOrphans.SelectedIndex;
			OrphanObject tmpSlot = assocAcct.OrphanChars[index];
			txtOrphName.Text = tmpSlot.Name;
			txtOrphSerial.Text = UOXData.Conversion.ToHexString(tmpSlot.Serial);
			btnRestore.Enabled = true;

			selOrph = tmpSlot;
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			if( MessageBox.Show("Are you sure you want to overwrite " + txtCharName.Text + " with " + txtOrphName.Text + "?", "Confirmation", MessageBoxButtons.YesNo ) == DialogResult.Yes )
			{
				selSlot.Name = selOrph.Name;
				selSlot.Serial = selOrph.Serial;

				assocAcct.DeleteOrphan( selOrph );
				UpdateList( assocAcct );
			}
		}
	}
}