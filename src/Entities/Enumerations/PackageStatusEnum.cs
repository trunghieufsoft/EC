namespace Entities.Enumerations
{
    public enum PackageStatusEnum
    {
        // TODO
        NotPacked = 0, // Chưa đóng gói
        Packing = 1, // Đang đóng gói
        Packed = 2, // Đã đóng gói
        Cancel = 3, // Hủy gói hàng
        Exception = 4 // Giao hàng nhưng bên nhận chưa nhận hàng
    }
}
