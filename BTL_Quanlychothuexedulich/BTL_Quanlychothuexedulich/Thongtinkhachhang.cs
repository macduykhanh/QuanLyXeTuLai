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
    public partial class Thongtinkhachhang : Form
    {
        ThueXeDB db = new ThueXeDB();
        public Thongtinkhachhang()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ThuexeForm thueFrm = new ThuexeForm();
            this.Hide();
            thueFrm.Show();
        }
        public void hienthi()
        {
            db.Khachhangs.Load();
            dgvKhachhang.DataSource = db.Khachhangs.ToList();
        
        }

        private void Thongtinkhachhang_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Vitri = e.RowIndex;
            txtMakh.Text = dgvKhachhang.Rows[Vitri].Cells[0].Value.ToString();
            txtTenkh.Text = dgvKhachhang.Rows[Vitri].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachhang.Rows[Vitri].Cells[2].Value.ToString();
            txtDiachi.Text = dgvKhachhang.Rows[Vitri].Cells[3].Value.ToString();
            txtSocmt.Text = dgvKhachhang.Rows[Vitri].Cells[4].Value.ToString();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = db.Khachhangs.FirstOrDefault(emp => emp.Makh == txtMakh.Text);
                if (kh == null)
                {
                    Khachhang s = new Khachhang()
                    {
                        Makh = txtMakh.Text,
                        Tenkh = txtTenkh.Text,
                        Dienthoai = txtSDT.Text,
                        Diachi = txtDiachi.Text,
                        Socmt = txtSocmt.Text,
                        
                    };
                    db.Khachhangs.Add(s);
                }
                else
                {
                    MessageBox.Show("Trùng mã khách hàng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Thongtinkhachhang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var selectedRows = dgvKhachhang.SelectedRows;
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var mahk = row.Cells[0].Value.ToString();
                        var s = db.Khachhangs.FirstOrDefault(emp => emp.Makh == txtMakh.Text);

                        db.Khachhangs.Remove(s);
                    }
                    db.SaveChanges();
                    
                }
                Thongtinkhachhang_Load(sender, e);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại!!" + ex.Message, "Error");
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ed = db.Khachhangs.ToList();
            if (!String.IsNullOrEmpty(txtMakh.Text))
            {
                ed = ed.Where(p => p.Makh.Contains(txtMakh.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtTenkh.Text))
            {
                ed = ed.Where(p => p.Tenkh.Contains(txtTenkh.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtDiachi.Text))
            {
                ed = ed.Where(p => p.Diachi.Contains(txtDiachi.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtSDT.Text))
            {
                ed = ed.Where(p => p.Dienthoai.Contains(txtSDT.Text)).ToList();
            }
            if (!String.IsNullOrEmpty(txtSocmt.Text))
            {
                ed = ed.Where(p => p.Socmt.Contains(txtSocmt.Text)).ToList();
            }

            dgvKhachhang.DataSource = ed;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMakh.Clear();
            txtTenkh.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtSocmt.Clear();
            Thongtinkhachhang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var kh = db.Khachhangs.FirstOrDefault(emp => emp.Makh == txtMakh.Text);
                if (kh == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    kh.Makh = txtMakh.Text;
                    kh.Tenkh = txtTenkh.Text;
                    kh.Diachi = txtDiachi.Text;
                    kh.Dienthoai = txtSDT.Text;
                    kh.Socmt = txtSocmt.Text;
                    
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

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            Thongtinkhachhang_Load(sender, e);
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            var ed = db.Khachhangs.ToList();
            ed = ed.OrderBy(h => h.Makh).ToList();
            dgvKhachhang.DataSource = ed;
        }
    }
}
