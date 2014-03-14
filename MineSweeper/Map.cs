using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MineSweeper {
    class Map : Panel {
        private Cell[,] cell_array;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Map() {
            cell_array = new Cell[Parameter.col, Parameter.row];
            this.Size = new Size(Parameter.col * Parameter.cell_height, Parameter.row * Parameter.cell_width);

            for (int i = 0; i < Parameter.col; i++) {
                for (int j = 0; j < Parameter.row; j++) {
                    cell_array[i, j] = new Cell();
                    cell_array[i, j].Location = new Point(i * (Parameter.cell_height - 1), j * (Parameter.cell_width -1));
                    this.Controls.Add(cell_array[i, j]);
                }
            }
        }
    }
}
