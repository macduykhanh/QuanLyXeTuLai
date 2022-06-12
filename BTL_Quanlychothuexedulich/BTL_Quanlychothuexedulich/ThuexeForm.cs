using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Quanlychothuexedulich
{
    public partial class ThuexeForm : Form
    {
        ThueXeDB db = new ThueXeDB();

        public void khoitaobienso()
        {

            db.Thongtinxes.Load();
            cbbBS.DataSource = db.Thongtinxes.Local;
            cbbBS.DisplayMember = "Bienso";
            cbbBS.ValueMember = "Bienso";

        }
        public void khoitaomakh()
        {

            db.Khachhangs.Load();
            cbbMakh.DataSource = db.Khachhangs.Local;
            cbbMakh.DisplayMember = "Makh";
            cbbMakh.ValueMember = "Makh";

        }
        public ThuexeForm()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainFrm = new MainMenu();
            this.Hide();
            mainFrm.Show();
        }

        private void btnXemTT_Click(object sender, EventArgs e)
        {
            Thongtinkhachhang TTfrm = new Thongtinkhachhang();
            this.Hide();
            TTfrm.Show();
        }

        public void hienthi()
        {
            
            var ed = (from e in db.Phieuthuexes
                      group e by e.Maxe into pg
                      join d in db.Xethues
                      on pg.FirstOrDefault().Maxe equals d.Maxe
                      select new { pg.FirstOrDefault().Maphieu, d.Bienso, pg.FirstOrDefault().Makh, pg.FirstOrDefault().Khachhang.Tenkh, pg.FirstOrDefault().Ngaythue }
                      ).ToList();
            

            dgvThuexe.DataSource = ed;


        }

        private void ThuexeForm_Load(object sender, EventArgs e)
        {
            khoitaobienso();
            khoitaomakh();
            hienthi();
        }


        public void ClearText()
        {
            
            txtMaphieu.Clear();
            txtMaxe.Clear();
            txtDongia.Clear();
            txtSongaythue.Clear();
        }

       

        private void cbbBS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Dongia
            String bs = (string)cbbBS.SelectedValue;
            var xe = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == bs);
            if (bs.Trim().Equals(xe.Bienso))
                {
                    if (xe.Loaixe == "Xe đạp")
                    {
                        txtDongia.Text = "100000";
                        return;
                    }
                    else if (xe.Loaixe == "Xe máy")
                    {
                        txtDongia.Text = "150000";
                        return;
                    }
                    else if (xe.Loaixe == "Ô tô")
                    {
                        txtDongia.Text = "200000";
                        return;
                    }
                    else
                    {
                        txtDongia.Text = "300000";
                        return;
                    }
                }
            }

        private void btnThemphieu_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMaphieu.Text.Trim() != "" || cbbMakh.Text.Trim() != "" || txtMaxe.Text.Trim() != "" || cbbBS.Text.Trim() != "")
                {

                    String bs = (string)cbbBS.SelectedValue;
                    String mkh = (string)cbbMakh.SelectedValue;
                    var xe = db.Thongtinxes.FirstOrDefault(emp => emp.Bienso == bs);
                    var ph = db.Phieuthuexes.ToList();
                    var xt = db.Xethues.ToList();
                    Boolean flag = true;
                    if (xe.Tinhtrang.Equals("Chưa thuê"))
                    {
                        foreach (Phieuthuexe phieu in ph)
                        {
                            if(phieu.Maphieu == txtMaphieu.Text)
                            {
                                flag = false;
                            }
                        }
                        foreach (Xethue xethue in xt)
                        {
                            if (xethue.Maxe == txtMaxe.Text)
                            {
                                flag = false;
                            }
                        }
                        if (flag == true)
                        {
                            Phieuthuexe p = new Phieuthuexe()
                            {
                                Maphieu = txtMaphieu.Text,
                                Maxe = txtMaxe.Text,
                                Makh = mkh,
                                Ngaythue = dtpTime.Value,
                                Songaythue = Int32.Parse(txtSongaythue.Text)
                            };
                            db.Phieuthuexes.Add(p);
                            Xethue x = new Xethue()
                            {
                                Maxe = txtMaxe.Text,
                                Makh = mkh,
                                DongiaNgay = Int32.Parse(txtDongia.Text),
                                Bienso = bs
                            };
                            db.Xethues.Add(x);
                            xe.Tinhtrang = "Đã thuê";
                            db.SaveChanges();
                            txtMaphieu.Clear();
                            txtMaxe.Clear();
                            txtDongia.Clear();
                            txtSongaythue.Clear();
                        }    
                        else
                        {
                            MessageBox.Show("Mã phiếu hoặc mã xe đã tồn tại, vui lòng kiểm tra lại!!", "Thông báo");
                            
                        }
                        
                        ThuexeForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xe đã được thuê, vui lòng chọn xe khác!!", "Thông báo");
                    }


                }
                else
                {
                    MessageBox.Show("Mã phiếu không được để trống !!! \n" +
                        "Mã khách hàng không được để trống !!! \n" +
                        "Mã xe không được để trống !!!");
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show("Thuê xe thất bại!!", "Thông báo");
            }
            
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var ed = (from em in db.Phieuthuexes
                      join d in db.Xethues
                      on em.Makh equals d.Makh
                      select new { em.Maphieu, em.Makh, em.Khachhang.Tenkh, d.Bienso, d.Maxe, em.Songaythue, d.DongiaNgay,em.Ngaythue }
                      ).ToList();
            if (!String.IsNullOrEmpty(txtMaphieu.Text))
            {
                ed = ed.Where(p => p.Maphieu.Contains(txtMaphieu.Text)).ToList();
            }
            if (!String.IsNullOrEmpty((string)cbbMakh.SelectedValue))
            {
                ed = ed.Where(p => p.Makh.Contains((string)cbbMakh.SelectedValue)).ToList();
            }
            if (!String.IsNullOrEmpty(txtMaxe.Text))
            {
                ed = ed.Where(p => p.Maxe.Contains(txtMaxe.Text)).ToList();
            }
            if (!String.IsNullOrEmpty((string)cbbBS.SelectedValue))
            {
                ed = ed.Where(p => p.Bienso.Contains((string)cbbBS.SelectedValue)).ToList();
            }
            if (!String.IsNullOrEmpty(txtDongia.Text))
            {
                ed = ed.Where(p => p.DongiaNgay.Equals(Convert.ToInt32(txtDongia.Text))).ToList();
            }
            if (!String.IsNullOrEmpty(txtSongaythue.Text))
            {
                ed = ed.Where(p => p.Songaythue.Equals(Convert.ToInt32(txtSongaythue.Text))).ToList();
            }
            
            dgvThuexe.DataSource = ed;
        }

        private void btnLoadForm_Click(object sender, EventArgs e)
        {
            ThuexeForm_Load(sender, e);
        }

        private void btnsapxep_Click(object sender, EventArgs e)
        {
            var ed = (from em in db.Phieuthuexes
                      group em by em.Maxe into pg
                      join d in db.Xethues
                      on pg.FirstOrDefault().Maxe equals d.Maxe
                      select new { pg.FirstOrDefault().Maphieu, d.Bienso, pg.FirstOrDefault().Makh, pg.FirstOrDefault().Khachhang.Tenkh, pg.FirstOrDefault().Ngaythue }
                      ).ToList();
            ed = ed.OrderBy(h => h.Maphieu).ToList();
            dgvThuexe.DataSource = ed;
        }
    }
}
