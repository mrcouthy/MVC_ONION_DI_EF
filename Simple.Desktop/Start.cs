using Simple.Interface.Repository;
using Simple.Interface.Service;
using Simple.Repository;
using Simple.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple.Desktop
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        IUsersService us;
        private void Start_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["SimpleConnection"].ConnectionString;
            IUsersRepository ur = new UsersRepository(constr);
             us = new UsersService(ur);

        }

        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            usersGrid.DataSource = us.GetUsers();
        }
    }
}
