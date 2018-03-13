using DrugMgmtSys.codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugMgmtSys
{
    public partial class InfoMgmtForm : Form
    {
        public InfoMgmtForm()
        {
            InitializeComponent();
        }
        
        //HACK:删除
        //数据数组
        string[] result = new string[7];

        public string[] Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tb_name.Text = "";
            cb_unit.Text = "请选择单位";
            tb_spec.Text= "";
            tb_origin.Text = "";
            tb_lot_num.Text = "";
            nud_reserve.Value = 0;
            nud_w_price.Value = 0;
            nud_r_price.Value = 0;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
            //创建药品信息类Drug的对象（使用带参构造器）
            Drug drug = new Drug(tb_name.Text, cb_unit.ValueMember, tb_spec.Text, tb_origin.Text, tb_lot_num.Text, double.Parse(nud_reserve.Value.ToString()), double.Parse(nud_w_price.Value.ToString()), double.Parse(nud_r_price.Value.ToString()));

            //HACK:在Drug中实现添加，此处接收返回值并判断是否成功。

            //调用drug的获取信息数组方法
            Result=drug.getResult();
            Close();
        }
        
    }
}
