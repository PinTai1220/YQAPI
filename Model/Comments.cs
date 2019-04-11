using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comments
    {
        public int Com_Id { get; set; }
        public string Content { get; set; }//评论内容
        public int Com_Number { get; set; }//评论数量
        public int Blog_Id { get; set; }//博客编号
        public int User_Id { get; set; }//用户编号
    }
}
