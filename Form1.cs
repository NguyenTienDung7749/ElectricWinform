namespace WaterBillWinformTest
{
    public partial class Form1 : Form
    {
        KhachHang[] DanhSachKhachHang = new KhachHang[100];
        int SoLuongKhachHang = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncaculator_Click(object sender, EventArgs e)
        {
            string TenKhachHang = tbname.Text;
            string CCCD = tbcccd.Text;
            string LoaiKhachHang = cbbcustomer.SelectedItem.ToString();
            int SoDienThangTruoc = Convert.ToInt32(tbwaterlast.Text);
            int SoDienThangNay = Convert.ToInt32(tbwaterthis.Text);


            KhachHang kh = new KhachHang(TenKhachHang, CCCD, LoaiKhachHang, SoDienThangTruoc, SoDienThangNay);
            int SoTienPhaiTra = kh.getSoTienPhaiTra();
            tbbill.Text = SoTienPhaiTra.ToString();
            DanhSachKhachHang[SoLuongKhachHang] = kh;
            SoLuongKhachHang++;
            displayDanhSachKhachHang();
        }

        private void displayDanhSachKhachHang()
        {
            lvDSKH.Items.Clear();
            for (int i = 0; i < SoLuongKhachHang; i++)
            {
                ListViewItem row = new ListViewItem(DanhSachKhachHang[i].getHoVaTen());
                row.SubItems.Add(DanhSachKhachHang[i].getCCCD());
                row.SubItems.Add(DanhSachKhachHang[i].getLoaiKhachHang());
                row.SubItems.Add(DanhSachKhachHang[i].getSoDienThangTruoc().ToString());
                row.SubItems.Add(DanhSachKhachHang[i].getSoDienThangNay().ToString());
                row.SubItems.Add(DanhSachKhachHang[i].getSoTienPhaiTra().ToString());

                lvDSKH.Items.Add(row);
            }
        }
    }
}
