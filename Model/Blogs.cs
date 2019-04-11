using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blogs
    {
        public int Blog_Id { get; set; }
        public string Headline { get; set; }//标题
        [MaxLength]
        public string Content { get; set; }//正文
        public DateTime Blog_Time { get; set; }//发布时间
        public int Browse_Number { get; set; }//浏览量
        public int State { get; set; }//发布状态
        public int User_Id { get; set; }//用户编号
        public int Kind_Id { get; set; }//分类编号

    }
}
