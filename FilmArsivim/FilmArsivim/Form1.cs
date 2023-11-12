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
using System.Management.Instrumentation;
using System.Diagnostics;

namespace FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlbaglantisi = new SqlConnection(@"Data Source=DEVRAN-PC\SQLEXPRESS;Initial Catalog=FilmArşivim;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter veriBagla = new SqlDataAdapter("Select NAME,LINK From TBLFILMLER", sqlbaglantisi);
            DataTable dt = new DataTable();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
