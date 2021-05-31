using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_project
{ 
    public partial class about_UserControl1 : UserControl
    {
        private static about_UserControl1 _instance;

        public static about_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new about_UserControl1();
                }
                return _instance;
            }
        }
        public about_UserControl1()
        {
            InitializeComponent();
        }
    }
}
