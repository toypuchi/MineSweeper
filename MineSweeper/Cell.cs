using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeper {
    class Cell : Button {
        public Cell() {
            this.Size = new Size(Parameter.cell_height, Parameter.cell_width);
        }
    }
}
