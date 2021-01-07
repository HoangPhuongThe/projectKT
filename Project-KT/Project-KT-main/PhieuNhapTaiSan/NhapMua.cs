using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhieuNhapTaiSan
{
    public partial class NhapMua : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-MCG6S6JA\SQLEXPRESS;Initial Catalog=ketoan;Integrated Security=True;");       
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataSet ds;
        DataTable dt;
        int ID = 0;
        public NhapMua()
        {
            InitializeComponent();
        }
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from ts";  
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        private void LoadTKduDBCombox()
        {
            con.Open();
            string sql = "select MaTK from DMTK";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            cbTkdu.DataSource = ds.Tables[0];
            cbTkdu.DisplayMember = "MaTK";
            con.Close();  // đóng kết nối

        }
        
        private void LoadTKhoanDBCombox()
        {
            con.Open();
            string sql = "select MaTK,TenMaTK from DMTK";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            cbTK.DataSource = ds.Tables[0];
            cbTK.DisplayMember = "MaTK";
            cbTK.ValueMember = "TenMaTK";
            tbTenTaiKhoan.DataBindings.Add("Text", cbTK.DataSource,"TenMaTK");
            tbDes1.DataBindings.Add("Text", cbTK.DataSource, "TenMaTK");
            con.Close();  // đóng kết nối

        }

        private void LoadKHangDBCombox()
        {
            con.Open();
            string sql = "select MSKH,TENKH, dchi from DMKH";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            comboMKH.DataSource = ds.Tables[0];
            comboMKH.DisplayMember = "MSKH";
            comboMKH.ValueMember = "TENKH";
            comboMKH.ValueMember = "dchi";
            tbTenKH.DataBindings.Add("Text", comboMKH.DataSource, "TENKH");
            tbDiaChi.DataBindings.Add("Text", comboMKH.DataSource, "dchi");
            con.Close();  // đóng kết nối

        }

        private void LoadMSTSDBCombox()
        {
            con.Open();
            string sql = "select MSTS,tenTS from DMTS";
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataSet ds = new DataSet(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(ds);  // đổ dữ liệu vào kho
            cbMSTS.DataSource = ds.Tables[0];
            cbMSTS.DisplayMember = "MSTS";
            cbMSTS.ValueMember = "tenTS";
            tbTenTS.DataBindings.Add("Text", cbMSTS.DataSource, "tenTS");
            con.Close();  // đóng kết nối

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbMauSo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*public void AutoIncre()
        {
            string[] mang = tbPso.Text.ToString().Split('C', '-');
            int chuoi = Int32.Parse(mang[1]);
            chuoi++;
            tbPso.Text = "NTSC0000" + chuoi.ToString() + "-1-21s";
        }*/
       /* public void AutoIncreHoaDon()
        {
            int dem = Int32.Parse(tbSHD.Text.ToString());
            dem++;
            tbSHD.Text = "" + dem.ToString();
        }
        public void AutoMSDV()
        {
            int msdv = Int32.Parse(tbMSDV.Text.ToString());
            tbMSDV.Text = msdv.ToString();
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPso.Text != ""  & cbTkdu.Text != "" & tbGia.Text != "")
            {
                con.Open();
                /*string sql = string.Format("INSERT INTO[KT].[dbo].[TS](tkdu, MSTS, st, pso) VALUES", tbPso.Text,tbMSTS.Text,cbTkdu.Text,tbGia.Text);

                SqlCommand cmd = new SqlCommand(sql, con);*/

                /*SqlCommand cmd = new SqlCommand("INSERT INTO [ketoan].[dbo].[TS](tkdu,st,sl,nsudung,snkh,pso) VALUES " +
                    "    ('" + cbTkdu.Text + "','" + tbGia.Text + "','" + numSL.Text + "','" + dtpkNSuDung.Value + "','" + tbSoNKH.Text + "','" + tbPso.Text + "');", con);
                cmd.ExecuteNonQuery();*/
                //DateTime date = Convert.ToDateTime();

                /*SqlCommand cmd = new SqlCommand("INSERT INTO [ketoan].[dbo].[TS] (tkdu,st,sl,nsudung,snkh,pso) VALUES (@tkdu,@st,@sl,@nsudung,@snkh,@pso)", con);
                cmd.Parameters.AddWithValue("@tkdu", cbTkdu.Text);
                cmd.Parameters.AddWithValue("@st", tbGia.Text);
                cmd.Parameters.AddWithValue("@sl", numSL.Text);
                cmd.Parameters.AddWithValue("@nsudung", dtpkNgSuDung.Text);
                cmd.Parameters.AddWithValue("@snkh", tbSoNKH.Text);
                cmd.Parameters.AddWithValue("@pso", tbPso.Text);

                cmd.ExecuteNonQuery();*/


                /*con.Close();
                MessageBox.Show("Dữ liệu đã được thêm vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                using (SqlCommand cmd = new SqlCommand("INSERT INTO [ketoan].[dbo].[TS](tkdu,MSTS,st,sl,nsdung,snkh,MSDV,pso) VALUES " +
                    "    ('" + cbTkdu.Text + "','" + cbMSTS.Text + "','" + tbGia.Text + "','" + numSL.Text + "','" + lbTime.Text + "','" + tbSoNKH.Text + "','" + textBox1.Text + "','" + tbPso.Text + "');", con))
                {
                    cmd.ExecuteNonQuery();
                }
                //using (SqlCommand cmd1 = new SqlCommand("INSERT INTO [HTTTKT].[dbo].[ph$](ten,nlap,MSKH,pso,tk,nky,ldo,MSDV,thuesuat,tgtgt,sohd,nphhd,diachi) VALUES (N'" + txtTnb.Text + "','" + lbTime.Text + "','" + txtMSKH.Text + "','" +  txtsophieu.Text  + "','" + txtTk.Text + "','" + lbTime.Text + "','" + txtLydo.Text + "','" + txtMSDV.Text + "','" + txtThue.Text + "','" + txtTienthue.Text + "','" + txtHoadon.Text + "','" + lbTime.Text + "','" + txtDiachi.Text + "')", con))
                /*using (SqlCommand cmd1 = new SqlCommand("INSERT INTO [ketoan].[dbo].[PH](pso,nlap,MSKH,ten,tk,nky,ldo,MSDV,thuesuat,tgtgt,sohd,nphhd,diachi) VALUES " +
                    "(N'" + tbPso.Text + "','" + lbTime.Text + "','" + comboMKH.Text + "','" + tbTenKH.Text + "','" + lbTime.Text + "','" + tbLyDo.Text + "','" + textBox1.Text + "','" + tbMSDV.Text + "','" + tbVAT.Text+ "','" + tbThue.Text + "','" + tbSHD.Text + "','" + lbTime.Text + "','" + tbDiaChi.Text + "')", con))
                {
                    cmd1.ExecuteNonQuery();
                }*/
                con.Close();
                MessageBox.Show("Dữ liệu đã được thêm vào ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*AutoIncre();*/
            /*AutoIncreHoaDon();
            AutoMSDV();*/
        }
        public DataTable XemDL(string sql)
        {


            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            adap.Fill(dt);

            return dt;
        }
        private void NhapMua_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            XemDL("select * from ts ");
            this.LoadTKduDBCombox();
            this.LoadTKhoanDBCombox();
            this.LoadKHangDBCombox();
            this.LoadMSTSDBCombox();

            DateTime tn = DateTime.Now;
            lbTime.Text = tn.ToString("yyyy'-'MM'-'dd HH':'mm':'ss''");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tbNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tbTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void tbMaKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Main m = new Form_Main();
            m.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sotien = Convert.ToInt32(tbGia.Text);
            float thue = Convert.ToInt32(tbVAT.Text);

            float kq = Convert.ToInt32(sotien * (thue / 100));
            float trigia = Convert.ToInt32(sotien + kq);
            tbTriGia.Text = trigia.ToString();
            tbThue.Text = kq.ToString();
            tbTienHang.Text = sotien.ToString();
            tbCong.Text = sotien.ToString();
        }

        private void tbVAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLyDo_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTkdu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbDes1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckpso_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = XemDL("select * from ts where pso like '%" + tbPso.Text.Trim() + "%' ");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
