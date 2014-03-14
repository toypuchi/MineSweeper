using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper {
    class Parameter {
        private static int[] row_array = new int[] { 10, 20, 30 };              // 難易度別の行
        private static int[] col_array = new int[] { 15, 30, 45 };              // 難易度別の列
        private static int[] bomb_num_array = new int[] { 5, 10, 15 };

        public static int row { get; private set; }             // 行
        public static int col { get; private set; }             // 列
        public static int bomb_num { get; private set; }        // 爆弾の数

        /// <summary>
        /// パラメータの設定
        /// </summary>
        /// <param name="config"></param>
        internal static void SetParameter(string difficulty) {
            // 難易度別に行，列，爆弾数を変更する
            switch (difficulty) {
                case "easy": SetParameterEach(row_array[0], col_array[0], bomb_num_array[0]); break;
                case "nomal": SetParameterEach(row_array[1], col_array[1], bomb_num_array[1]); break;
                case "hard": SetParameterEach(row_array[2], col_array[2], bomb_num_array[2]); break;
                default: Console.WriteLine("難易度の設定が間違っています．"); break;
            }
        }

        /// <summary>
        /// 行，列，爆弾の数を設定
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="bomb_num"></param>
        private static void SetParameterEach(int row, int col, int bomb_num) {
            Parameter.row = row;
            Parameter.col = col;
            Parameter.bomb_num = bomb_num;
        }
    }
}
