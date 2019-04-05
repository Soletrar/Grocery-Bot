using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MetroFramework.Controls;
using MetroFramework.Forms;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Habbo.Messages;
using Tangine;

namespace GroceryBot
{
    public partial class MainFrm : MetroForm
    {
        private List<IBlackHoleItem> _blackHoleItems;

        private int _myIndex;
        private int _blackHole;
        private HPoint _initialChair = null;
        private HPoint _nextToBh = null;

        private bool _isRunning;

        private readonly ExtensionForm _conn;
        private readonly Incoming _in;
        private readonly Outgoing _out;

        private const int PtWidth = 438;

        public MainFrm(ExtensionForm main)
        {
            InitializeComponent();

            metroComboBox1.Sorted = true;
            metroComboBox2.Sorted = true;
            metroComboBox3.Sorted = true;

            _conn = main;
            _in = main.In;
            _out = main.Out;

            FormClosed += (sender, args) => main.Close();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            _blackHoleItems = BlackHoleItem.GetBlackHoleItems().Result;
            _blackHoleItems.ForEach(item =>
            {
                metroComboBox1.Items.Add(item);
                metroComboBox2.Items.Add(item);
                metroComboBox3.Items.Add(item);
            });

            if (Helper.Language != "PT") goto Handlers;

            cbBlackHole.Text = "Buraco Negro";
            cbBlackHoleChair.Text = "Banco próximo ao Buraco Negro";
            cbInitialChair.Text = "Banco Inicial";
            cbAutoSit.Text = "Sentar Automático";
            btnReset.Text = "Limpar";
            btnStart.Text = "Iniciar";

            this.Width = PtWidth;

            Handlers:
            _conn.Triggers.InAttach(_in.RoomUserHandItem, OnRoomUserHandItem);

            _conn.Triggers.OutAttach(_out.ToggleFloorItem, OnToggleFloorItem);
            _conn.Triggers.OutAttach(_out.RoomUserWalk, OnRoomUserWalk);
        }

        private void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
            if (cbInitialChair.Checked)
            {
                _initialChair = new HPoint(e.Packet.ReadInteger(), e.Packet.ReadInteger());
                cbInitialChair.Checked = false;
            }
            else if (cbBlackHoleChair.Checked)
            {
                _nextToBh = new HPoint(e.Packet.ReadInteger(), e.Packet.ReadInteger());
                cbBlackHoleChair.Checked = false;
            }
        }

        private void OnToggleFloorItem(DataInterceptedEventArgs e)
        {
            if (!cbBlackHole.Checked) return;
            _blackHole = e.Packet.ReadInteger();
            cbBlackHole.Checked = false;
        }

        private async void OnRoomUserHandItem(DataInterceptedEventArgs e)
        {
            if (!_isRunning) return;

            var flag = _myIndex == e.Packet.ReadInteger();
            if (!flag) return;

            var handItem = e.Packet.ReadInteger();

            if (Helper.CurrentItemId1 == handItem && cbItem1.Checked)
            {
                cbItem1.Checked = false;
                await ReturnToChairAndStop(1);
            }
            else if (Helper.CurrentItemId2 == handItem && cbItem2.Checked)
            {
                cbItem2.Checked = false;
                await ReturnToChairAndStop(2);
            }
            else if (Helper.CurrentItemId3 == handItem && cbItem3.Checked)
            {
                cbItem3.Checked = false;
                await ReturnToChairAndStop(3);
            }
            else await _conn.Connection.SendToServerAsync(_out.ToggleFloorItem, _blackHole, 0);
        }

        private async Task ReturnToChairAndStop(int comboId)
        {
            _isRunning = false;
            btnStart.Text = Helper.Language == "PT" ? "Iniciar" : "Start";

            if(_initialChair != null && cbAutoSit.Checked)
                await _conn.Connection.SendToServerAsync(_out.RoomUserWalk, _initialChair.X, _initialChair.Y);

            var itemName = string.Empty;

            switch (comboId)
            {
                case 1:
                    itemName = (metroComboBox1.SelectedItem as IBlackHoleItem)?.Name;
                    break;
                case 2:
                    itemName = (metroComboBox2.SelectedItem as IBlackHoleItem)?.Name;
                    break;
                case 3:
                    itemName = (metroComboBox3.SelectedItem as IBlackHoleItem)?.Name;
                    break;
            }

            var flag = Helper.Language == "PT";
            if (flag) await SendNotification($"Adquirido {itemName}");
            else await SendNotification($"Got {itemName}");

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbox = (MetroComboBox)sender;
            try
            {
                switch (cbox.Name.Last())
                {
                    case '1':
                        Helper.CurrentItemId1 = ((IBlackHoleItem)((MetroComboBox)sender).SelectedItem).Id;
                        break;
                    case '2':
                        Helper.CurrentItemId2 = ((IBlackHoleItem)((MetroComboBox)sender).SelectedItem).Id;
                        break;
                    case '3':
                        Helper.CurrentItemId3 = ((IBlackHoleItem)((MetroComboBox)sender).SelectedItem).Id;
                        break;
                }
            }
            catch (Exception exception)
            {
            }

        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = metroCheckBox2.Checked;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _conn.Triggers.InAttach(_in.RoomUserWhisper, InUserWhisper);
            _conn.Connection.SendToServerAsync(_out.RoomUserWhisper, "GroceryBot Index", 0).Wait();

            if (Helper.Language == "PT")
            {
                if (btnStart.Text == "Iniciar")
                {
                    btnStart.Text = "Parar";
                    _isRunning = true;

                    if (_nextToBh is null) return;

                    _conn.Connection.SendToServerAsync(_out.RoomUserWalk, _nextToBh.X, _nextToBh.Y);
                }
                else
                {
                    btnStart.Text = "Iniciar";
                    _isRunning = false;
                }
            }
            else
            {
                if (btnStart.Text == "Start")
                {
                    btnStart.Text = "Stop";
                    _isRunning = true;

                    if (_nextToBh is null) return;

                    _conn.Connection.SendToServerAsync(_out.RoomUserWalk, _nextToBh.X, _nextToBh.Y);
                }
                else
                {
                    btnStart.Text = "Start";
                    _isRunning = false;
                }
            }
        }

        private void InUserWhisper(DataInterceptedEventArgs e)
        {
            _myIndex = e.Packet.ReadInteger();
            e.IsBlocked = true;
            _conn.Triggers.InDetach(_in.RoomUserWhisper);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cbItem1.Checked = true;
            cbItem2.Checked = true;
            cbItem3.Checked = true;
            metroComboBox1.SelectedItem = null;
            metroComboBox2.SelectedItem = null;
            metroComboBox3.SelectedItem = null;
        }

        private async Task SendNotification(string message) => 
            await _conn.Connection.SendToServerAsync(_out.RoomUserWhisper, "GB Grocery Bot: " + message, 0);

        private void cbBlackHole_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbBlackHoleChair_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
