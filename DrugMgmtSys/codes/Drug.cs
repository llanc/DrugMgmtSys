using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugMgmtSys.codes
{
    class Drug
    {
        public string Name { get; set; }

        public string Unit { get; set; }

        public string Spec { get; set; }

        public string Origin { get; set; }

        public string Lot_num { get; set; }

        public double Reserve { get; set; }

        public double W_price { get; set; }

        public double R_price { get; set; }

        /// <summary>
        /// 带参构造，用于修改信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unit"></param>
        /// <param name="spec"></param>
        /// <param name="origin"></param>
        /// <param name="lot_num"></param>
        /// <param name="reserve"></param>
        /// <param name="w_price"></param>
        /// <param name="r_price"></param>
        public Drug(string name, string unit, string spec, string origin, string lot_num, double reserve, double w_price, double r_price)
        {
            Name = name;
            Unit = unit;
            Spec = spec;
            Origin = origin;
            Lot_num = lot_num;
            Reserve = reserve;
            W_price = w_price;
            R_price = r_price;
        }

        //HACK:MayBe Not Need
        public string[] getResult()
        {
            string[] result = new string[7];
            result[0] = Name;
            result[1] = Unit;
            result[2] = Spec;
            result[3] = Origin;
            result[4] = Lot_num;
            result[5] = Reserve.ToString();
            result[6] = W_price.ToString();
            result[7] = R_price.ToString();
            return result;
        }

        //TODO:添加方法

    }
}
