using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8._7._2实现带查询功能的ComboBox控件
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            cbox_Find.Items.Clear();
            cbox_Find.Items.Add("C#编程字典");
            cbox_Find.Items.Add("C#编程宝典");
            cbox_Find.Items.Add("C#视频学");
            cbox_Find.Items.Add("C#范例宝典");
            cbox_Find.Items.Add("C#从入门到精通");
            cbox_Find.Items.Add("C#范例大全");
        }

        private void btn_Begin_Click(object sender, EventArgs e)
        {
            cbox_Find.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbox_Find.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
