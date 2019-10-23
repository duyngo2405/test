﻿using System;
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
using ThucHanhKiemThuPhanMem.Model.DAO;
using ThucHanhKiemThuPhanMem.Model.EF;

namespace ThucHanhKiemThuPhanMem
{
    /// <summary>
    /// Interaction logic for DanhSachMonHoc.xaml
    /// </summary>
    public partial class DanhSachMonHoc : Window
    {
        MyDbContext db;
        MonHocDAO daoMH;
        LopDAO daoL;

        public static MonHoc monHoc;
        public static string maLop;
        

        public DanhSachMonHoc()
        {
            InitializeComponent();


            Reload();
        }

        void Reload()
        {
            daoMH = new MonHocDAO();
            //daoL = new LopDAO();

            dataGridDanhSachMonHoc.ItemsSource = null;
            //dataGridDanhSachLop.ItemsSource = null;

            dataGridDanhSachMonHoc.ItemsSource = daoMH.GetMonHocs();
            //dataGridDanhSachLop.ItemsSource = daoL.GetLops();
        }

        private void BntPhanLop_Click(object sender, RoutedEventArgs e)
        {
            if (monHoc != null)
            {
                PhanLop pl = new PhanLop();
                pl.Owner = this;
                pl.ShowDialog();
            }
            
        }

        private void DataGridDanhSachMonHoc_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                
                db = new MyDbContext();
                var obj = dataGridDanhSachMonHoc.SelectedItem;
                monHoc = db.MonHoc.Find((obj as MonHoc).MaMonHoc);
                if (obj != null)
                {
                    MonHoc monHoc = (MonHoc)obj;
                    LopDAO dao = new LopDAO();
                    List<Lop> lops = dao.GetLops(monHoc.MaMonHoc);
                    dataGridDanhSachLop.ItemsSource = lops;
                }
            }catch(Exception ex) { }
        }

        private void bntBack_Click(object sender, RoutedEventArgs e)
        {
            //ExportToExcelAndCsv();
            this.Close();
        }
        private void ExportToExcelAndCsv()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dataGridDanhSachMonHoc.SelectAllCells();
            dataGridDanhSachMonHoc.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dataGridDanhSachMonHoc);
            String resultat = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            String result = (string)Clipboard.GetData(DataFormats.Text);
            dataGridDanhSachMonHoc.UnselectAllCells();
            System.IO.StreamWriter file1 = new System.IO.StreamWriter(@path + "/test.xls", false,Encoding.UTF8);
            file1.WriteLine(result.Replace(',', ' '));
            file1.Close();

            MessageBox.Show(" Exporting DataGrid data to Excel file created.xls");
        }
        private void bntHuyLop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db = new MyDbContext();
                var obj = dataGridDanhSachLop.SelectedItems;
                if (obj != null)
                {
                    foreach (var lop in obj)
                    {
                        Lop mlop = db.Lop.Find((lop as Lop).MaLop);
                        List<ThamGia> listThamGia = db.ThamGia.Where(x => x.MaLop == mlop.MaLop).ToList();
                        foreach (var tg in listThamGia)
                        {
                            ThamGia mtg = tg as ThamGia;
                            if (String.IsNullOrEmpty(mtg.MaLop) == false)
                            {
                                db.ThamGia.Remove(db.ThamGia.Find(mtg.MaLop,mtg.MaSinhVien));
                                db.SaveChanges();
                            }
                            
                        }
                        
                        db.Lop.Remove(mlop);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Đã xóa");
                    Reload();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntCapNhatLop_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db = new MyDbContext();
                var obj = dataGridDanhSachLop.SelectedItems;
                
                if (obj != null)
                {
                    foreach (var lop in obj)
                    {
                        Lop mLop = lop as Lop;
                        if (mLop != null)
                        {
                            maLop = mLop.MaLop;
                            CapNhatLop capNhatLop = new CapNhatLop();
                            capNhatLop.ShowInTaskbar = false;
                            capNhatLop.Owner = this;
                            capNhatLop.ShowDialog();
                        }
                    }
                    Reload();

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
