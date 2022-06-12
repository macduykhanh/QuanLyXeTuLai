using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace BTL_Quanlychothuexedulich
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLyXeForm QLXFrm = new QuanLyXeForm();
            QLXFrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThuexeForm thueFrm = new ThuexeForm();
            thueFrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TraxeForm traxeFrm = new TraxeForm();
            traxeFrm.Show();
            this.Hide();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không!!","Message",MessageBoxButtons.YesNo);
            if(dia == DialogResult.Yes)
            {
                MenuDangnhap dnFrm = new MenuDangnhap();
                dnFrm.Show();
                this.Hide();
            }
        }

    }
}
