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
    public partial class Config : Form {
        public bool init_flag = false;      // 設定ボタンが押されたらTrueにする

        public Config() {
            InitializeComponent();
        }

        /// <summary>
        /// OKボタンを押した際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e) {
            List<RadioButton> radio_btn_list = new List<RadioButton>();
            radio_btn_list.Add(radioBtn_easy);
            radio_btn_list.Add(radioBtn_nomal);
            radio_btn_list.Add(radioBtn_hard);

            string difficulty = "";
            foreach (RadioButton btn in radio_btn_list) {
                if (btn.Checked) {
                    difficulty = btn.Text;
                }
            }

            Parameter.SetParameter(difficulty);
            init_flag = true;
            this.Close();
        }

        /// <summary>
        /// キャンセルボタンを押した際の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
