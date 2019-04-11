using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Attention
    {
        public int Atten_Id { get; set; }
        public DateTime Atten_Time { get; set; }//关注时间
        public int Atten_Number { get; set; }//关注数量
        public int Bolg_Id { get; set; }//博客编号
        public int User_Id { get; set; }//用户编号
    }
}
