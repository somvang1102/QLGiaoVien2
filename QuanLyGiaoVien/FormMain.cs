using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using QLGV;
namespace QuanLyGiaoVien
{
    public partial class FormMain : Form
    {
        BUS_khoa bus_Khoa = new BUS_khoa();
        Bus_HocHam_HocVi bus_HocHam_HocVi = new Bus_HocHam_HocVi();
        //DataGridView data1 = new DataGridView();
        private string tenTaiKhoan;
        System.Data.DataTable dt;
        Bus_DangNhap bus_DangNhap = new Bus_DangNhap();
        public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            f.TenTK = textBox1.Text;
            this.Close();
            this.Hide();
            f.ShowDialog();

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data1.Visible = true;
            button1.Visible = true;
            data1.DataSource = bus_Khoa.getKhoaALL();
            data1.Columns[0].HeaderText = "Mã Khoa";
            data1.Columns[1].HeaderText = "Tên Khoa";
        }

        private void bộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            comboBoxKhoa.Visible = true;
            comboBoxKhoa.DataSource = bus_Khoa.getTenKhoa();
            comboBoxKhoa.DisplayMember = "Ma_Khoa";
            comboBoxKhoa.ValueMember = "";

            btnBoMon.Visible = true;
        }

        private void họcHàmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void họcVịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lịchGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxKhoa.Visible = false;
            this.Controls.Add(data1);
            textBox1.Text = tenTaiKhoan;

            data1.Visible = false;
            //comboBoxKhoa.Visible = false;
            button1.Visible = false;
            btnBoMon.Visible = false;
        }
    }
}
