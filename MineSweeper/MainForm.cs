using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            Parameter.SetParameter("easy");
            this.Controls.Add(map = new Map());
        }

        private void btn_config_Click(object sender, EventArgs e) {
            Config config = new Config();
            config.ShowDialog();
            if (config.init_flag) {
                map = new Map();
            }
            config.Dispose();
        }
    }
}
