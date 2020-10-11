using System;
using System.Collections.Generic;
using QLBH.Core.Data;
using QLBH.Common;

// <Remarks>
// Tạo DMNhomNguoiDungProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 12/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.HeThong.Providers
{
    [Serializable]
    public class TblDMNhomNguoiDung : DataObject
    {
        public override string GetDataObjectName()
        {
            return Declare.TableNamespace.DmNhomNguoiDung;
        }
    }
    [Serializable]
    public class DMNhomNguoiDungInfor :TblDMNhomNguoiDung
    {
        public DMNhomNguoiDungInfor()
        {
            SetNullValues(this);
        }

        [IsKey(true)]
        [NullValue(-1)]
        public int IdNhomNguoiDung { get; set; }

        [NullValue("")]
        public string MaNhom { get; set; }

        [NullValue("")]
        public string TenNhom { get; set; }

        [NullValue(-1)]
        public int SuDung { get; set; }
    }
    public class DMNhomNguoiDungDataProvider :ProviderBase
    {
        public static List<DMNhomNguoiDungInfor> GetListNhomInfo()
        {
            return SelectAll<DMNhomNguoiDungInfor>();
        }


        internal static void Insert(DMNhomNguoiDungInfor dmNhomNguoiDungInfor)
        {
            ProviderBase.Insert(dmNhomNguoiDungInfor);
        }

        internal static void Delete(DMNhomNguoiDungInfor dmNhomNguoiDungInfor)
        {
            ProviderBase.Delete(dmNhomNguoiDungInfor);
        }

        internal static void Update(DMNhomNguoiDungInfor dmNhomNguoiDungInfor)
        {
            ProviderBase.Update(dmNhomNguoiDungInfor);
        }

        internal static bool Kiemtra(Predicate<DMNhomNguoiDungInfor>match)
        {
            return ProviderBase.Exists(match);
        }
    }
}
