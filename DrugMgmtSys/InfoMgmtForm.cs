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
            tb_w_price.Text = "0";
            tb_r_price.Text = "0";
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_add_Click(object sender, EventArgs e)
        {
                //创建药品信息类Drug的对象（使用带参构造器）
                Drug drug = new Drug(key,tb_name.Text,(int)cb_unit.SelectedValue, tb_spec.Text, tb_origin.Text, tb_lot_num.Text, double.Parse(nud_reserve.Value.ToString()), double.Parse(tb_w_price.Text), double.Parse(tb_r_price.Text.ToString()));
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
                    MessageBox.Show("修改信息失败，请检查药品是否已经存在！", "温馨提示");
                }
            }

            Close();
        }

        #region 计算利润

        private void tb_w_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x= Convert.ToDouble(tb_r_price.Text);
                double y = Convert.ToDouble(tb_w_price.Text);
                lb_progit.Text = (x - y) + "元";
            }
            catch (Exception)
            {
                tb_w_price.Text = "0";
                MessageBox.Show("请输入数字！", "温馨提示");
            }
        }

        private void tb_r_price_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lb_progit.Text = (Convert.ToDouble(tb_r_price.Text) - Convert.ToDouble(tb_w_price.Text)) + "元";

            }
            catch (Exception)
            {

                tb_r_price.Text = "0";
                MessageBox.Show("请输入数字！", "温馨提示");
            }
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
            tb_w_price.Text = w_price.ToString();
            tb_r_price.Text = r_price.ToString();
        }

        #region 点击文本框全选
        private void tb_w_price_MouseClick(object sender, MouseEventArgs e)
        {
            tb_w_price.SelectAll();
        }
        private void tb_r_price_MouseClick(object sender, MouseEventArgs e)
        {
            tb_r_price.SelectAll();
        }
        #endregion


        #region 限制只能输入数字
        private void tb_w_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制只能输入数字，Backspace键，小数点

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')

            {

                e.Handled = true;  //非以上键则禁止输入

            }

            if (e.KeyChar == '.' && tb_w_price.Text.Trim() == "") e.Handled = true; //禁止第一个字符就输入小数点

            if (e.KeyChar == '.' && tb_w_price.Text.Contains(".")) e.Handled = true; //禁止输入多个小数点
        }

        private void tb_r_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //限制只能输入数字，Backspace键，小数点

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')

            {

                e.Handled = true;  //非以上键则禁止输入

            }

            if (e.KeyChar == '.' && tb_r_price.Text.Trim() == "") e.Handled = true; //禁止第一个字符就输入小数点

            if (e.KeyChar == '.' && tb_r_price.Text.Contains(".")) e.Handled = true; //禁止输入多个小数点
        }
        #endregion


    }
}
