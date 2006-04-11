using System;
using System.Windows.Forms;
using UOXData;

namespace AccountManager
{
	public partial class CharacterEditor : Form
	{
		private AccountObject assocAcct;
		private SlotObject selSlot;

		public CharacterEditor()
		{
			assocAcct	= null;
			selSlot		= null;
			InitializeComponent();
		}

		private void btnCharHide_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void cbBlockSlot_CheckedChanged(object sender, EventArgs e)
		{
			if( assocAcct != null && listCharacters.Items.Count > 0 )
			{
				ushort flag = (ushort)Math.Pow( 2, (4 + listCharacters.SelectedIndex) );
				assocAcct.SetFlag( flag, cbBlockSlot.Checked );
			}
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
		}

		private void listCharacters_SelectedIndexChanged(object sender, EventArgs e)
		{
			selSlot = null;
			cbBlockSlot.Checked = false;
			if( assocAcct == null || listCharacters.Items.Count <= 0 || listCharacters.SelectedIndex == -1 )
			{
				txtCharName.Clear();
				txtCharSer.Clear();
				return;
			}

			int index			= listCharacters.SelectedIndex;
			SlotObject tmpSlot  = assocAcct.CharSlots[index];
			txtCharName.Text	= tmpSlot.Name;
			txtCharSer.Text		= UOXData.Conversion.ToHexString( tmpSlot.Serial );
			ushort flag			= (ushort)Math.Pow( 2, (4 + index) );
			if( (assocAcct.Flags&flag) == flag )
				cbBlockSlot.Checked = true;

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
	}
}