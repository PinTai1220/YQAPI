using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kinds
    {
        public int Kinds_Id { get; set; }
        public string Kinds_Name { get; set; }//分类名称
        public int User_Id { get; set; }//用户编号
    }
}
