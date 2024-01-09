using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oopexample
{

    public partial class MainForm : Form
    {
        List<Player> playerList = new List<Player>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            int health, powerLevel;

            int.TryParse(txtHealth.Text, out health);
            int.TryParse(txtPowerLevel.Text, out powerLevel);

            Player player = new Player(firstName, lastName, health, powerLevel);
            playerList.Add(player);

            lstPlayer.Items.Add(player.GetGreeting());
        }
    }
}
