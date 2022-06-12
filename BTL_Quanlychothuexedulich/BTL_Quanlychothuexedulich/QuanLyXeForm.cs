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
    public partial class QuanLyXeForm : Form
    {
        ThueXeDB db = new ThueXeDB();
        public QuanLyXeForm()
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

        public void hienthi()
        {
            using (var db = new ThueXeDB())
            {
                var ed = (from e in db.Thongtinxes
                          select new { e.Bienso, e.Hangxe, e.Tenxe, e.Loaixe, e.Mauson, e.Tinhtrang }
                          ).ToList();

                dgvXe.DataSource = ed;

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainFrm = new MainMenu();
            this.Hide();
            mainFrm.Show();
        }

        private void QuanLyXeForm_Load(object sender, EventArgs e)
        {
            khoitaoLoaiXe();
            khoitaotinhtrang();
            hienthi();
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
        private void dgvXe_SelectionChanged(object sender, EventArgs e)
        {
            onclick();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ed = db.Thongtinxes.ToList();
            if(!String.IsNullOrEmpty((string)cbbTinhtrang.SelectedValue))
            {
                ed = ed.Where(p => p.Tinhtrang.Contains((string)cbbTinhtrang.SelectedValue)).ToList();
            }
            if(!String.IsNullOrEmpty(txtBienso.Text))
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
            QuanLyXeForm_Load(sender,e);
        }

        private void txtTinhtrang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            var xe = db.Thongtinxes.ToList();
            xe = xe.OrderBy(h => h.Hangxe).ToList();
            dgvXe.DataSource = xe;
        }
    }
}
