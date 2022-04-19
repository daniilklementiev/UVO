using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace UVO.Forms
{
    public partial class Game : Form
    {
        private readonly Logger _logger;
        public Game(Logger logger)
        {
            InitializeComponent();
            _logger = logger;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = false;
            buttonExit.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
