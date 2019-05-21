namespace Entities.Enumerations
{
    public enum TransStatusEnum
    {
        InStock = 0, // Trong kho chưa vận chuyển
        BeingTransported = 1, // Đang vận chuyển
        Delivery = 2, // Đang giao hàng
        Completed = 3, // Hoàn tất
    }
}
