using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugMgmtSys.codes
{
    class Drug
    {
        public string Name { get; set; }

        public int Unit { get; set; }

        public string Spec { get; set; }

        public string Origin { get; set; }

        public string Lot_num { get; set; }

        public double Reserve { get; set; }

        public double W_price { get; set; }

        public double R_price { get; set; }

        public int KEY { get; set; }

        #region 构造器

        /// <summary>
        /// 带参构造，用于添加信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unit"></param>
        /// <param name="spec"></param>
        /// <param name="origin"></param>
        /// <param name="lot_num"></param>
        /// <param name="reserve"></param>
        /// <param name="w_price"></param>
        /// <param name="r_price"></param>
        public Drug(int key,string name, int unit, string spec, string origin, string lot_num, double reserve, double w_price, double r_price)
        {
            KEY = key;
            Name = name;
            Unit = unit;
            Spec = spec;
            Origin = origin;
            Lot_num = lot_num;
            Reserve = reserve;
            W_price = w_price;
            R_price = r_price;
        }
        /// <summary>
        /// 带参构造器，用于修改信息是显示当前信息
        /// </summary>
        /// <param name="key">主键</param>
        public Drug(int key)
        {
            KEY = key;

            //根据KEY Select tb_drug；初始化属性

            string sql = "SELECT * FROM tb_drug WHERE d_id="+key;
            DataTable dt= MySqlTools.GetDataSet(sql).Tables[0];

            Name = dt.Rows[0][1].ToString();
            Unit = (int)dt.Rows[0][2];
            Spec = dt.Rows[0][3].ToString();
            Origin = dt.Rows[0][4].ToString();
            Lot_num = dt.Rows[0][5].ToString();
            Reserve = (double)dt.Rows[0][6];
            W_price = (double)dt.Rows[0][7];
            R_price = (double)dt.Rows[0][8];
        }
        /// <summary>
        /// 无参构造器
        /// </summary>
        public Drug()
        {

        }
        #endregion

        /// <summary>
        /// 添加药品信息
        /// </summary>
        /// <returns>影响的行数</returns>
        public int addDrug()
        {
            string add_sql = string.Format("INSERT INTO tb_drug (d_name,d_unit,d_spec,d_origin,d_lot_num,d_reserve,d_w_price,d_r_price) VALUES ('{0}', {1},'{2}','{3}','{4}',{5},{6},{7})",Name,Unit,Spec,Origin,Lot_num,Reserve,W_price,R_price);

            int result= MySqlTools.ExecuteNonQuery(add_sql);
            return result;
        }
        
        /// <summary>
        /// 修改药品信息
        /// </summary>
        /// <returns>影响行数</returns>
        public int changeDrug()
        {
            string change_sql = string.Format("UPDATE tb_drug SET d_name='{0}',d_unit={1},d_spec='{2}',d_origin='{3}',d_lot_num='{4}',d_reserve={5},d_w_price={6},d_r_price={7} WHERE d_id={8}",Name,Unit,Spec,Origin,Lot_num,Reserve,W_price,R_price,KEY);
            int result = MySqlTools.ExecuteNonQuery(change_sql);
            return result;
        }

    }
}
