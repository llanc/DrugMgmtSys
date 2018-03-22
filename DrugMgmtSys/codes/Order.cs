using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugMgmtSys.codes
{
    class Order
    {
        private List<Drug> order = new List<Drug>();
        private ArrayList num = new ArrayList();

        internal List<Drug> Orders
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }

        /// <summary>
        /// 添加药品
        /// </summary>
        /// <param name="drug"></param>
        public void add(Drug drug)
        {
            Orders.Add(drug);
        }
        public void setNum(double num)
        {
            this.num.Add(num);
        }
        public string[] getMessage()
        {
            string[] result ={"","" };
            string result_head = "药品清单：\n\n";
            double money = 0;
            for (int i = 0; i < Orders.Count; i++)
            {
                Drug drug = Orders[i];
                //string item= string.Format("{0}、 {1}  \t数量 {2} \t\t单价 {3} 元\n\n", i + 1, drug.Name, (double)num[i], drug.R_price);
                string item = string.Format("{0}{1}{2}{3}\n\n", padRightEx(i + 1 +"、",5 ), padRightEx(drug.Name,30), padRightEx("数量 X"+num[i].ToString(),10), padRightEx("单价 "+drug.R_price.ToString(),10));

                result_head += item;
                money += drug.R_price*(double)num[i];
                //统计
                insertOrder(drug, (double)num[i]);
            }
            result[0] = result_head;
            result[1] = money.ToString();
            return result;

        }

        /// <summary>
        /// 订单信息写入数据库
        /// </summary>
        private void insertOrder(Drug drug,double n)
        {
            string date = DateTime.Now.ToLongDateString().ToString();
            string name = drug.Name;
            double number = n;
            double r_price = drug.R_price;
            double money = (drug.R_price-drug.W_price)*n;

            string sql=string.Format("INSERT INTO tb_order (o_time,o_name,o_num,o_r_price,o_money) VALUES ('{0}','{1}',{2},{3},{4})", date, name, number, r_price, money);

            int result = MySqlTools.ExecuteNonQuery(sql);

            
        }


        //对齐
        private static string padRightEx(string str, int totalByteCount)
        {
            Encoding coding = Encoding.GetEncoding("gb2312");
            int dcount = 0;
            foreach (char ch in str.ToCharArray())
            {
                if (coding.GetByteCount(ch.ToString()) == 2)
                    dcount++;
            }
            string w = str.PadRight(totalByteCount - dcount);
            return w;
        }

    }
}
 