using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //房间表
    public class Rooms
    {
        public int Room_Id { get; set; }
        public int RoomType_Id { get; set; }//类型编号
        public int Room_Num { get; set; }//房间号
        public int Room_State { get; set; }//房间状态
        public string RoomType_Name { get; set; }//房间类型名称
        public decimal RoomType_Price { get; set; }//房间价格
    }
}
