using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recommends
    {
        public int Recom_Id { get; set; }
        public int Recom_Number { get; set; }//推荐数量
        public int State { get; set; }//状态
        public int Blog_Id { get; set; }//博客状态
        public int User_Id { get; set; }//用户编号
    }
}
