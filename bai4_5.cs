namespace BaiTap4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMSSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            lstSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                 AnchorStyles.Left | AnchorStyles.Right;

            btnThem.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnXoa.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string mssv = txtMSSV.Text;
            string lop = txtLop.Text;

            if (hoTen == "" || mssv == "" || lop == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string sinhVien = mssv + " - " + hoTen + " - " + lop;

            lstSinhVien.Items.Add(sinhVien);

            txtHoTen.Clear();
            txtMSSV.Clear();
            txtLop.Clear();

            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSinhVien.SelectedItem != null)
            {
                lstSinhVien.Items.Remove(lstSinhVien.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
            }
        }
    }
}
