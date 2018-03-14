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
        private int key;

        public InfoMgmtForm()
        {
            InitializeComponent();
            bindUnit();
        }

        public InfoMgmtForm(int key)
        {
            InitializeComponent();
            bindUnit();
            this.key = key;
        }


        /// <summary>
        /// 绑定单位到comboBox
        /// </summary>
        private void bindUnit()
        {
            string sql = "SELECT * from tb_unit";
            DataSet ds= MySqlTools.GetDataSet(sql);
            //绑定数据源
            cb_unit.DataSource = ds.Tables[0];
            //值为u_id
            cb_unit.ValueMember = "u_id";
            //属性为u_name
            cb_unit.DisplayMember = "u_name";
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
                Drug drug = new Drug(key,tb_name.Text,(int)cb_unit.SelectedValue, tb_spec.Text, tb_origin.Text, tb_lot_num.Text, double.Parse(nud_reserve.Value.ToString()), double.Parse(nud_w_price.Value.ToString()), double.Parse(nud_r_price.Value.ToString()));
            if (btn_add.Text=="添加")
            {
                int result=drug.addDrug();
                if (result==1)
                {
                    MessageBox.Show("添加成功！", "温馨提示");
                }
                else
                {
                    MessageBox.Show("添加失败，请检查输入信息！", "温馨提示");
                }
            }
            else if (btn_add.Text=="修改")
            {
                int result = drug.changeDrug();
                if (result == 1)
                {
                    MessageBox.Show("修改信息成功！", "温馨提示");
                    
                }
                else
                {
                    MessageBox.Show("修改信息失败，请检查输入信息！", "温馨提示");
                }
            }

            Close();
        }

        /// <summary>
        /// 添加新单位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //TODO:调用添加单位方法
        }

        #region 计算利润
        private void nud_r_price_ValueChanged(object sender, EventArgs e)
        {
            lb_progit.Text = (nud_r_price.Value - nud_w_price.Value) + "元";
        }

        private void nud_r_price_KeyUp(object sender, KeyEventArgs e)
        {
            lb_progit.Text = (nud_r_price.Value - nud_w_price.Value) + "元";
        }
        #endregion

        /// <summary>
        /// 作为修改对话框
        /// </summary>
        public void asChange()
        {
            btn_add.Text = "修改";
        }

        /// <summary>
        /// 显示当前药品信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unit"></param>
        /// <param name="spec"></param>
        /// <param name="origin"></param>
        /// <param name="lot_num"></param>
        /// <param name="reserve"></param>
        /// <param name="w_price"></param>
        /// <param name="r_price"></param>
        public void setValue(string name,int unit,string spec,string origin,string lot_num,double reserve,double w_price,double r_price)
        {
            tb_name.Text = name;
            cb_unit.SelectedValue = unit;
            tb_spec.Text = spec;
            tb_origin.Text = origin;
            tb_lot_num.Text = lot_num;
            nud_reserve.Value = (decimal)reserve;
            nud_w_price.Value = (decimal)w_price;
            nud_r_price.Value = (decimal)r_price;
        }
    }
}
