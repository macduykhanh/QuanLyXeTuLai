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
    public partial class MenuDangnhap : Form
    {
        
        public MenuDangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!!","Error");
            }
            else if(txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!","Error");
            }
            else
            {
                using (var db = new ThueXeDB())
                {
                    var tk = db.Taikhoans.ToList().FirstOrDefault(u => u.Taikhoan1 == txtTK.Text);
                    Boolean flag = false;
                    
                    if (tk.Taikhoan1 == txtTK.Text && tk.Matkhau == txtMK.Text)
                    {
                        flag = true;
                        if (tk.Quyen == "NV")
                        {
                            MainMenu mainfrm = new MainMenu();
                            mainfrm.Show();
                            this.Hide();
                        }
                        else if (tk.Quyen == "AD")
                        {
                            QuanLyXeAdmin adFrm = new QuanLyXeAdmin();
                            adFrm.Show();
                            this.Hide();
                        }
                    }
                    
                    if (flag == false)
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!", "Error");
                    }
                }
                    
            }
        }

        private void MenuDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
