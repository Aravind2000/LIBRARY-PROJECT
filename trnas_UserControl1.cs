using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DBMS_project
{
    public partial class trnas_UserControl1 : UserControl
    {
        private static trnas_UserControl1 _instance;

        public static trnas_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new trnas_UserControl1();
                }
                return _instance;
            }
        }
        public trnas_UserControl1()
        {
            InitializeComponent();
        }
    }
}
