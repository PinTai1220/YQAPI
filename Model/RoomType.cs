using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //房间类型表
    public class RoomType
    {
        public int RoomType_Id { get; set; }
        public string RoomType_Name { get; set; }//房间类型名称
        public decimal RoomType_Price { get; set; }//房间价格
    }
}
