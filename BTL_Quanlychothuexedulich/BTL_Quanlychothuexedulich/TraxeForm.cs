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
    public partial class TraxeForm : Form
    {
        ThueXeDB db = new ThueXeDB();
        public TraxeForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainFrm = new MainMenu();
            this.Hide();
            mainFrm.Show();
        }
        public void hienthi()
        {
            var ed = (from e in db.Phieuthuexes
                      group e by e.Maxe into pg
                      join d in db.Xethues
                      on pg.FirstOrDefault().Maxe equals d.Maxe
                      select new { pg.FirstOrDefault().Maphieu, pg.FirstOrDefault().Makh, pg.FirstOrDefault().Khachhang.Tenkh, d.Bienso, d.Maxe, pg.FirstOrDefault().Songaythue, d.DongiaNgay }
                      ).ToList();

            dgvtraxe.DataSource = ed;


        }
        private void TraxeForm_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        public void onclick()
        {
            txtMaphieu.Text = dgvtraxe.CurrentRow.Cells[0].Value.ToString();
            txtMakh.Text = dgvtraxe.CurrentRow.Cells[1].Value.ToString();
            txtTenkh.Text = dgvtraxe.CurrentRow.Cells[2].Value.ToString();
            txtBienso.Text = dgvtraxe.CurrentRow.Cells[3].Value.ToString();
            txtMaxe.Text = dgvtraxe.CurrentRow.Cells[4].Value.ToString();
            txtSongay.Text = dgvtraxe.CurrentRow.Cells[5].Value.ToString();
            txtDongia.Text = dgvtraxe.CurrentRow.Cells[6].Value.ToString();
            
        }
        
        public void ClearText()
         {
                txtMaphieu.Clear();
                txtMakh.Clear();
                txtTenkh.Clear();
                txtBienso.Clear();
                txtMaxe.Clear();
                txtSongay.Clear();
                txtDongia.Clear();

         }
        private void btnXoaphieu_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa khôngg?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var xe = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == txtBienso.Text);
                var x = db.Xethues.FirstOrDefault(emp => emp.Maxe == txtMaxe.Text);
                if (x != null)
                {
                    db.Xethues.Remove(x);
                    
                }
                var p = db.Phieuthuexes.FirstOrDefault(emp => emp.Maphieu == txtMaphieu.Text);
                if (x != null)
                {
                    db.Phieuthuexes.Remove(p);

                }
                xe.Tinhtrang = "Chưa thuê";
                db.SaveChanges();
                
                ClearText();   
            }
            
            
            TraxeForm_Load(sender,e);
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            int songay =Int32.Parse(txtSongay.Text) ;
            int dongia =Int32.Parse(txtDongia.Text);
            int tien = songay * dongia;
            lblThanhTien.Text =Convert.ToString(String.Format("{0:n}", tien))+" VNĐ";
            MessageBox.Show("Số tiền phải trả là "+ String.Format("{0:n}", tien) + " VNĐ!!");
        }

        private void dgvtraxe_SelectionChanged(object sender, EventArgs e)
        {
            onclick();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ed = (from em in db.Phieuthuexes
                      join d in db.Xethues
                      on em.Makh equals d.Makh
                      select new { em.Maphieu, em.Makh, em.Khachhang.Tenkh, d.Bienso, d.Maxe, em.Songaythue, d.DongiaNgay }
                      ).ToList();
            if (!String.IsNullOrEmpty(txtMaphieu.Text))
            {
                ed = ed.Where(p => p.Maphieu.Contains(txtMaphieu.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtMakh.Text))
            {
                ed = ed.Where(p => p.Makh.Contains(txtMakh.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtMaxe.Text))
            {
                ed = ed.Where(p => p.Maxe.Contains(txtMaxe.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtBienso.Text))
            {
                ed = ed.Where(p => p.Bienso.Contains(txtBienso.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtDongia.Text))
            {
                ed = ed.Where(p => p.DongiaNgay.Equals(Convert.ToInt32(txtDongia.Text))).ToList();
            }
            if (!String.IsNullOrEmpty(txtSongay.Text))
            {
                ed = ed.Where(p => p.Songaythue.Equals(Convert.ToInt32(txtSongay.Text))).ToList();
            }
            if (!String.IsNullOrEmpty(txtTenkh.Text))
            {
                ed = ed.Where(p => p.Tenkh.Contains(txtTenkh.Text)).ToList();
            }
            dgvtraxe.DataSource = ed;
        }

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            TraxeForm_Load(sender, e);
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            var ed = (from em in db.Phieuthuexes
                      group em by em.Maxe into pg
                      join d in db.Xethues
                      on pg.FirstOrDefault().Maxe equals d.Maxe
                      select new { pg.FirstOrDefault().Maphieu, pg.FirstOrDefault().Makh, pg.FirstOrDefault().Khachhang.Tenkh, d.Bienso, d.Maxe, pg.FirstOrDefault().Songaythue, d.DongiaNgay }
                      ).ToList();
            ed = ed.OrderBy(h => h.Maphieu).ToList();
            dgvtraxe.DataSource = ed;
        }
    }
}
