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
    public partial class Main : Form
    {
        private int KEY;
        private bool canOrder=false;
        Order order = null;

        public bool CanOrder
        {
            get
            {
                return canOrder;
            }

            set
            {
                canOrder = value;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ForbidSortColumn(dataGridView_K);
            //显示
            BindAll_X();
        }


        #region 查询按钮

        /// <summary>
        /// 药品销售页面查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //查询
            BindByTrim_X();
        }

        /// <summary>
        /// 库存页面查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            BindByTrim_K();
        }

        #endregion

        #region 显示全部按钮

        /// <summary>
        /// 销售页面显示全部按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            BindAll_X();
        }

        /// <summary>
        /// 库存页面显示全部按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            BindAll_K();
        }

        #endregion

        #region 出售按钮

        private void dataGridView_X_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 || e.RowIndex == -1)
            {
                return;
            }
            if (CanOrder)
            {
                double num = getIntputNum();


                //获取当前行的索引
                int index = dataGridView_X.CurrentCell.RowIndex;
                //获取当前行对应的“编号”列的值（主键） 
                int key = Int32.Parse(dataGridView_X.Rows[index].Cells["编号"].Value.ToString());

                //更新库存
                updateReserve(num, key);
                Drug drug = new Drug(key);

                //向订单添加
                order.add(drug);
                order.setNum(num);
                
                BindAll_X();
            }
            else
            {
                MessageBox.Show("请先点击上方“开处药方”按钮，建立新的药方再行出售！","温馨提示");
            }

        }

        #endregion

        #region 查询所有并绑定

        /// <summary>
        /// 销售页面查询所有并绑定
        /// </summary>
        protected void BindAll_X()
        {

            string sql_select_drug_X = "SELECT d_id,d_name,u_name,d_spec,d_reserve,d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id";
            DataSet ds = MySqlTools.GetDataSet(sql_select_drug_X);
            dataGridView_X.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 库存页面查询所有并绑定
        /// </summary>
        protected void BindAll_K()
        {

            string sql_select_drug_K = "SELECT d_id,d_name,u_name,d_spec,d_origin,d_lot_num,d_reserve,d_w_price,d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id";
            DataSet ds = MySqlTools.GetDataSet(sql_select_drug_K);

            DataTable dt = ds.Tables[0];
            //添加一列“tb_progit”
            dt.Columns.Add("tb_progit");
            //为该列的每一行赋值
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["tb_progit"] = Convert.ToDouble(dt.Rows[i][8]) - Convert.ToDouble(dt.Rows[i][7]);
            }
            dataGridView_K.DataSource = dt;
        }

        /// <summary>
        /// 销售记录查询
        /// </summary>
        protected void BindAndShow()
        {

            DateTime dt = dateTimePicker1.Value;
            string time=dt.ToLongDateString().ToString();
            string sql =string .Format("SELECT o_id,o_name,o_num,o_r_price,o_money FROM tb_order where o_time='{0}'", time);
            DataSet ds = MySqlTools.GetDataSet(sql);
            DataTable dataTable = ds.Tables[0];
            dataGridView_M.DataSource=dataTable;
            //求和
            double sum_m = 0;
            double sum_r = 0;
            for (int i = 0; i < dataGridView_M.Rows.Count; i++)
            {
                sum_m += Convert.ToDouble(dataGridView_M.Rows[i].Cells["利润"].Value);
                sum_r += Convert.ToDouble(dataGridView_M.Rows[i].Cells["售价"].Value);
            }
            lb_r.Text = sum_r.ToString()+"元";
            lb_m.Text = sum_m.ToString() + "元";
        }

        #endregion

        #region 条件查询并绑定

        /// <summary>
        /// 销售页面按条件绑定
        /// </summary>
        private void BindByTrim_X()
        {
            string d_name = string.Format("'%{0}%'", textBox_select_X.Text);
            string sql_select_by_d_name = "SELECT d_id,d_name,u_name,d_spec,d_reserve,d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id AND d_name LIKE " + d_name;
            DataSet ds = MySqlTools.GetDataSet(sql_select_by_d_name);
            dataGridView_X.DataSource = ds.Tables[0];
        }
        /// <summary>
        /// 库存页面按条件绑定
        /// </summary>
        private void BindByTrim_K()
        {
            string d_name = string.Format("'%{0}%'", textBox_select_K.Text);
            string sql_select_by_d_name = "SELECT d_id, d_name, u_name, d_spec, d_origin, d_lot_num, d_reserve, d_w_price, d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id AND d_name LIKE " + d_name;
            DataSet ds = MySqlTools.GetDataSet(sql_select_by_d_name);

            DataTable dt = ds.Tables[0];
            //添加一列“tb_progit”
            dt.Columns.Add("tb_progit");
            //为该列的每一行赋值
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["tb_progit"] = Convert.ToDouble(dt.Rows[i][8]) - Convert.ToDouble(dt.Rows[i][7]);
            }
            dataGridView_K.DataSource = dt;
        }

        #endregion

        #region 清空文本框

        private void textBox_select_X_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_select_X.Text = "";
        }
        private void textBox_select_K_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_select_K.Text = "";
        }

        #endregion

        #region 获取输入
        /// <summary>
        /// 获取用户输入数量
        /// </summary>
        /// <returns>输入的值</returns>
        private double getIntputNum()
        {
            InputNumDiaLog form = new InputNumDiaLog();
            form.ShowDialog();
            return form.Input; 
        }

        #endregion

        /// <summary>
        /// 更新库存方法
        /// </summary>
        /// <param name="num">用户输入</param>
        /// <param name="key">主键</param>
        /// <param name="b">true为增加，false为减少</param>
        private void updateReserve(double num,int key)
        {
            if (num==0)
            {
                return;
            }
            string sql_SelectReserve = "SELECT d_reserve FROM tb_drug WHERE d_id=" + key;
            double reserve = (double)MySqlTools.ExecuteScalar(sql_SelectReserve);

                if (reserve - num<0)
                {
                    MessageBox.Show("  该药品剩余库存为:" + reserve + "\n  库存不足,请尽快补货！", "温馨提示");
                }
                else
                {
                    string sql_updateReserve = string.Format("UPDATE tb_drug SET d_reserve={0} WHERE d_id={1}", reserve - num, key);
                    // sql_select_r_price = "SELECT d_r_price FROM tb_drug WHERE d_id=" + key;
                    //double money =num*(double)MySqlTools.ExecuteScalar(sql_select_r_price);
                    if (MySqlTools.ExecuteNonQuery(sql_updateReserve) == 1)
                    {
                        MessageBox.Show("出库成功！", "温馨提示");
                    }
                    else
                    {
                        MessageBox.Show("出库失败！", "温馨提示");
                    }
                }
           //}
        }

        #region 库存页面删除、修改按钮

        /// <summary>
        /// 修改药品信息按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

            if (KEY==0)
            {
                MessageBox.Show("请先选中一行数据！", "温馨提示");
                return;
            }

            //创建drug,获取当前信息
             Drug drug = new Drug(KEY);
            
            InfoMgmtForm infoForm = new InfoMgmtForm(KEY);
            //为组件赋值：当前值
            infoForm.setValue(drug.Name, drug.Unit, drug.Spec, drug.Origin, drug.Lot_num, drug.Reserve, drug.W_price, drug.R_price);
            infoForm.asChange();//更改按钮
            infoForm.ShowDialog();
            BindAll_K();

        }

        /// <summary>
        /// 删除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string caption = "温馨提示";
            string message = "是否删除该条数据？";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            DialogResult result = new DialogResult();
            result = MessageBox.Show(message, caption, btn);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                string sql = "delete from tb_drug where d_id=" + KEY;
                if (MySqlTools.ExecuteNonQuery(sql) > 0)
                {
                    MessageBox.Show("成功删除该条记录！", "温馨提示");
                    BindAll_K();
                }
            }
        }

        #endregion
        
        #region 添加数据

        /// <summary>
        /// 添加药品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            
            InfoMgmtForm infoForm = new InfoMgmtForm();
            infoForm.ShowDialog();
            //BindAll_K();
            tabControl_main.SelectedIndex = 0;
            tabControl_main.SelectedIndex = 1;
        }

        #endregion

        #region 选项卡切换处理

        /// <summary>
        /// 更改选项卡后触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = tabControl_main.SelectedTab.Text;
            switch (i)
            {
                case "药品销售":
                    BindAll_X();
                    break;
                case "药品库存信息管理":
                    BindAll_K();
                    break;
                case "销售记录":
                    BindAndShow();
                    break;
            }
        }

        #endregion

        #region 处理操作

        /// <summary>
        /// 点击单元格时，获取当前行索引
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_K_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex==-1)
            {
                return;
            }
            this.dataGridView_K.Rows[e.RowIndex].Selected = true;//是否选中当前行
            int index = e.RowIndex;
            //获取当前行对应的“编号”列的值（主键） 
            DataTable dt =(DataTable)dataGridView_K.DataSource;
            KEY = (int)dt.Rows[index][0];
        }
        
        /// <summary>
        /// 禁止DataGrideView排序 加载时调用
        /// </summary>
        /// <param name="dgv"></param>
        public static void ForbidSortColumn(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// 检索时间改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BindAndShow();
        }

        #endregion


        /// <summary>
        /// 版权方网站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.llanc.cn/");
        }

        /// <summary>
        /// 开处药方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text=="开处药方")
            {
                button8.Text = "结算";
                button8.ForeColor = Color.Red;
                CanOrder = true;//可以出售
                order = new Order();//新建订单
                MessageBox.Show("创建药方成功，请点击“出售”按钮添加药品", "温馨提示");
            }
            else if (button8.Text == "结算")
            {
                button8.Text = "开处药方";
                button8.ForeColor = Color.Green;
                CanOrder = false;//不可出售
                ShowOrder showOrderForm = new ShowOrder(order.getMessage());
                showOrderForm.ShowDialog();
            }
        }

        #region 登录处理

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            string pwd = tb_pwd.Text;
            string sql = string.Format("SELECT * FROM tb_pwd WHERE pwd='{0}'", pwd);
            try
            {
                if ((int)MySqlTools.ExecuteScalar(sql) == 1)
                {
                    panl_Login.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("您的密码输入有误，请重新输入!", "温馨提示");
            }
        }
        /// <summary>
        /// 修改密码按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bun_ch_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE tb_pwd SET pwd='{0}' where id=1",tb_pwdCh.Text);
            
            if ((int)MySqlTools.ExecuteNonQuery(sql)==1)
            {
                MessageBox.Show("密码更改成功，请牢记！\n" + tb_pwdCh.Text, "温馨提示");
            }
            else
            {
                MessageBox.Show("密码更改失败！", "温馨提示");
            }
        }

        #endregion
    }
}

