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
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //显示
            BindAll_X();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查询
            BindByTrim();
        }

        /// <summary>
        /// 查询所有并绑定
        /// </summary>
        protected void BindAll_X()
        {

            string sql_select_drug_X = "SELECT d_id,d_name,u_name,d_spec,d_reserve,d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id";
            DataSet ds = MySqlTools.GetDataSet(sql_select_drug_X);
            dataGridView_X.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// 按条件绑定
        /// </summary>
        protected void BindByTrim()
        {
            string d_name = string.Format("'%{0}%'", textBox_select_X.Text);
            string sql_select_by_d_name = "SELECT d_id,d_name,u_name,d_spec,d_reserve,d_r_price FROM tb_drug INNER JOIN tb_unit ON d_unit = u_id WHERE d_unit = u_id AND d_name LIKE " + d_name;
            DataSet ds = MySqlTools.GetDataSet(sql_select_by_d_name);
            dataGridView_X.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindAll_X();
        }

        private void textBox_select_X_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_select_X.Text = "";
        }

        private void dataGridView_X_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex!=0||e.RowIndex==-1)
            {
                return;
            }

            double num=getIntputNum();

            bool b = false;
            //获取当前行的索引
            int index=dataGridView_X.CurrentCell.RowIndex;
            //获取当前行对应的“编号”列的值（主键） 
            int key=Int32.Parse(dataGridView_X.Rows[index].Cells["编号"].Value.ToString());

            updateReserve(num, key, false);

            BindAll_X();
        }
        /// <summary>
        /// 获取用户输入
        /// </summary>
        /// <returns>输入的值</returns>
        private double getIntputNum()
        {
            InputNumDiaLog form = new InputNumDiaLog();
            form.ShowDialog();
            return form.Input; 

        }
        /// <summary>
        /// 更新库存方法
        /// </summary>
        /// <param name="num">用户输入</param>
        /// <param name="key">主键</param>
        /// <param name="b">true为增加，false为减少</param>
        private void updateReserve(double num,int key,bool b)
        {
            if (num==0)
            {
                return;
            }
            string sql_SelectReserve = "SELECT d_reserve FROM tb_drug WHERE d_id=" + key;
            //获取库存
            double reserve = (double)MySqlTools.ExecuteScalar(sql_SelectReserve);
            if (b)
            {
                string sql_updateReserve = string.Format("UPDATE tb_drug SET d_reserve={0} WHERE d_id={1}", reserve + num, key);
                if (MySqlTools.ExecuteNonQuery(sql_updateReserve) ==1 )
                {
                    MessageBox.Show("入库成功！","温馨提示");
                }
                else
                {
                    MessageBox.Show("入库失败！", "温馨提示");
                }
            }
            else
            {
                if (reserve - num<0)
                {
                    MessageBox.Show("  该药品剩余库存为:" + reserve + "\n  库存不足,请尽快补货！", "温馨提示");
                }
                else
                {
                    string sql_updateReserve = string.Format("UPDATE tb_drug SET d_reserve={0} WHERE d_id={1}", reserve - num, key);
                    string sql_select_r_price = "SELECT d_r_price FROM tb_drug WHERE d_id=" + key;
                    double money =num*(double)MySqlTools.ExecuteScalar(sql_select_r_price);
                    if (MySqlTools.ExecuteNonQuery(sql_updateReserve) == 1)
                    {
                        MessageBox.Show("应收金额："+ money + "元。", "出库成功！");
                    }
                    else
                    {
                        MessageBox.Show("出库失败！", "温馨提示");
                    }
                }
            }
        }
    }
}

