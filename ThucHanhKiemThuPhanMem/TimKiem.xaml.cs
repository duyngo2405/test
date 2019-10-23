using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ThucHanhKiemThuPhanMem.Model.EF;

namespace ThucHanhKiemThuPhanMem
{
    /// <summary>
    /// Interaction logic for TimKiem.xaml
    /// </summary>
    public partial class TimKiem : Window
    {
        MyDbContext db;
        static List<SinhVien> listSV;
        public TimKiem()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            txtNoiDungTimKiem.IsEnabled = true;
            if (listSV == null)
            {
                db = new MyDbContext();
                listSV = db.SinhVien.ToList().GetRange(0, 100);
                dataGridKetQua.ItemsSource = listSV;
            }
            else
            {
                dataGridKetQua.ItemsSource = listSV;
            }
            
        }

        private void cbLuaChon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbLuaChon.SelectedIndex == 0)
                txtNoiDungTimKiem.IsEnabled = false;
            else 
                txtNoiDungTimKiem.IsEnabled = true;
        }

        private void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbLuaChon.SelectedItem != null)
                {
                    //Ten Sv
                    if (cbLuaChon.SelectedIndex == 0)
                    {
                        if (String.IsNullOrEmpty(txtTenSV.Text) == false)
                        {
                            db = new MyDbContext();
                            dataGridKetQua.ItemsSource = db.SinhVien.Where(x => x.TenSinhVien.Contains(txtTenSV.Text)).ToList();
                        }
                        else MessageBox.Show("Tên sinh viên không được để trống");
                    }
                    //Diem
                    else if (cbLuaChon.SelectedIndex == 1)
                    {
                        if (String.IsNullOrEmpty(txtTenSV.Text) == false && String.IsNullOrEmpty(txtNoiDungTimKiem.Text) == false)
                        {
                            string[] num = txtNoiDungTimKiem.Text.Split('>');
                            double min, max;
                            if (double.TryParse(num[0], out min) && double.TryParse(num[1], out max))
                            {
                                if (min > max)
                                {
                                    min += max;
                                    max = min - max;
                                    min = min - max;

                                }
                                db = new MyDbContext();
                                dataGridKetQua.ItemsSource = db.SinhVien.Where(x => x.TenSinhVien == txtTenSV.Text && x.DiemThi >= min && x.DiemThi <= max).ToList();

                            }
                            else MessageBox.Show("Điểm không hợp lệ, vui lòng xem vd");

                        }
                        else MessageBox.Show("Vui lòng xem lại thông tin tìm kiếm");
                    }
                    //Môn học
                    else if (cbLuaChon.SelectedIndex == 2)
                    {
                        if (String.IsNullOrEmpty(txtTenSV.Text) == false && String.IsNullOrEmpty(txtNoiDungTimKiem.Text) == false)
                        {
                            List<MonHoc> tmpListMonHoc = db.MonHoc.Where(x => x.TenMon.Contains(txtNoiDungTimKiem.Text)).ToList();
                            List<Lop> tmpListLop = new List<Lop>();
                            List<ThamGia> tmpListThamGia = new List<ThamGia>();
                            foreach (MonHoc item in tmpListMonHoc)
                            {
                                tmpListLop.AddRange(db.Lop.Where(x => x.MaMonHoc == item.MaMonHoc));
                            }
                        }
                        else MessageBox.Show("Vui lòng xem lại thông tin tìm kiếm");
                    }
                } else MessageBox.Show("Vui lòng chọn mục tìm kiếm");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
