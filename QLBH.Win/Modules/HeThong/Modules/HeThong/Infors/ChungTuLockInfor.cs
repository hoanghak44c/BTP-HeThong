using System;

namespace QLBanHang.Modules.HeThong.Infors
{
    public class ChungTuLockInfor
    {
        public int IdChungtu { get; set; }
        public string SoChungTu { get; set; }
        public string LockAccount { get; set; }
        public string LockMachine { get; set; }
        public string ProcessId { get; set; }
        public DateTime Last_Update_Date { get; set; }
    }
}