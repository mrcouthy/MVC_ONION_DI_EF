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
using Autofac;
namespace Simple.Desktop
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        public IUsersService us { get; set; }
        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            using (var scope = DIConfig.container.BeginLifetimeScope())
            {
                var us = scope.Resolve<IUsersService>();
                usersGrid.DataSource = us.GetUsers();
            }
        }
    }
}
