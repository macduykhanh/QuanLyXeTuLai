using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Quanlychothuexedulich
{
    public partial class QuanLyXeAdmin : Form
    {
        ThueXeDB db = new ThueXeDB();
        public QuanLyXeAdmin()
        {
            InitializeComponent();
        }

        public void khoitaoLoaiXe()
        {
            
            db.Loaixes.Load();
            cbbLoaixe.DataSource = db.Loaixes.Local;
            cbbLoaixe.DisplayMember = "loaixe";
            cbbLoaixe.ValueMember = "loaixe";
            
        }

        public void khoitaotinhtrang()
        {

            db.Tinhtrangs.Load();
            cbbTinhtrang.DataSource = db.Tinhtrangs.Local;
            cbbTinhtrang.DisplayMember = "tinhtrang";
            cbbTinhtrang.ValueMember = "tinhtrang";

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                var xe = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == txtBienso.Text);
                if (xe == null)
                {
                    Thongtinxe s = new Thongtinxe()
                    {
                        Bienso = txtBienso.Text,
                        Hangxe = txtHangxe.Text,
                        Tenxe = txtTenxe.Text,
                        Loaixe = (string)cbbLoaixe.SelectedValue,
                        Mauson = txtMauson.Text,
                        Tinhtrang = (string)cbbTinhtrang.SelectedValue
                    };
                    db.Thongtinxes.Add(s);
                }
                else
                {
                    MessageBox.Show("Trùng biển số xe", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return;
                }
                hienthi();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Thêm thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(e1.Message);
            }
            
        }
        public void ClearText()
        {
            txtBienso.Clear();
            txtHangxe.Clear();
            txtTenxe.Clear();
            txtMauson.Clear();
            
        }
        public void hienthi()
        {
            using (var db = new ThueXeDB())
            {
                var ed = (from e in db.Thongtinxes
                          select new { e.Bienso, e.Hangxe,e.Tenxe,e.Loaixe, e.Mauson, e.Tinhtrang}
                          ).ToList();
                
                dgvXe.DataSource = ed;
               
            }
        }
        private void QuanLyXeAdmin_Load(object sender, EventArgs e)
        {
            khoitaoLoaiXe();
            khoitaotinhtrang();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
            try
            {
                var xe = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == txtBienso.Text);
                if (xe == null)
                {
                    MessageBox.Show("Xe không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    xe.Bienso = txtBienso.Text;
                    xe.Mauson = txtMauson.Text;
                    xe.Tenxe = txtTenxe.Text;
                    xe.Hangxe = txtHangxe.Text;
                    xe.Loaixe = (string)cbbLoaixe.SelectedValue;
                    xe.Tinhtrang = (string)cbbTinhtrang.SelectedValue;
                }
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    return;
                }
                hienthi();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Cập nhật thất bại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(e1.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                
                var s = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == txtBienso.Text);
                if (s.Tinhtrang.Equals("Chưa thuê"))
                {
                    db.Thongtinxes.Remove(s);
                    db.SaveChanges();
                    
                }
                else
                {
                    MessageBox.Show("Xe này đang được sử dụng!!");
                }
                
                
                ClearText();
            }
            QuanLyXeAdmin_Load(sender, e);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không!!", "Message", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
            {
                MenuDangnhap dnFrm = new MenuDangnhap();
                dnFrm.Show();
                this.Hide();
            }
        }

        private void onclick()
        {
            
            txtBienso.Text = dgvXe.CurrentRow.Cells[0].Value.ToString();
            txtHangxe.Text = dgvXe.CurrentRow.Cells[1].Value.ToString();
            txtTenxe.Text = dgvXe.CurrentRow.Cells[2].Value.ToString();
            cbbLoaixe.Text = dgvXe.CurrentRow.Cells[3].Value.ToString();
            txtMauson.Text = dgvXe.CurrentRow.Cells[4].Value.ToString();
            cbbTinhtrang.Text = dgvXe.CurrentRow.Cells[5].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvXe_SelectionChanged(object sender, EventArgs e)
        {
            onclick();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ed = db.Thongtinxes.ToList();
            if (!String.IsNullOrEmpty((string)cbbTinhtrang.SelectedValue))
            {
                ed = ed.Where(p => p.Tinhtrang.Contains((string)cbbTinhtrang.SelectedValue)).ToList();
            }
            if (!String.IsNullOrEmpty(txtBienso.Text))
            {
                ed = ed.Where(p => p.Bienso.Contains(txtBienso.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtHangxe.Text))
            {
                ed = ed.Where(p => p.Hangxe.Contains(txtHangxe.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtTenxe.Text))
            {
                ed = ed.Where(p => p.Tenxe.Contains(txtTenxe.Text)).ToList();
            }
            if (!String.IsNullOrEmpty((string)cbbLoaixe.SelectedValue))
            {
                ed = ed.Where(p => p.Loaixe.Contains((string)cbbLoaixe.SelectedValue)).ToList();
            }

            dgvXe.DataSource = ed;
        }

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            QuanLyXeAdmin_Load(sender, e);
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            var xe = db.Thongtinxes.ToList();
            xe = xe.OrderBy(h => h.Hangxe).ToList();
            dgvXe.DataSource = xe;
        }
    }
}
