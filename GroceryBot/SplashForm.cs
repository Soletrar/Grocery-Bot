using System;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Modules;

using Tangine;

namespace GroceryBot
{
    [Author("ric", HabboName = "ricardo?seidel", Hotel = HHotel.ComBr)]
    [Author("ric (.com)", HabboName = "Soletrar", Hotel = HHotel.Com)]
    [Module("Grocery Bot", "A fun automatized application lel")]
    public partial class SplashForm : ExtensionForm
    {
        public override bool IsRemoteModule => true;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 1;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lang = metroComboBox1.SelectedItem.ToString();
            var flag = lang == "English";
            Helper.Language = flag ? "EN" : "PT";
            metroButton1.Text = flag ? "Continue" : "Prosseguir";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide();
            new MainFrm(this).Show();
        }
    }
}
