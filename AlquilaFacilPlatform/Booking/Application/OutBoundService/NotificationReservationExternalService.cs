using AlquilaFacilPlatform.Notifications.Interfaces.ACL;

namespace AlquilaFacilPlatform.Booking.Application.OutBoundService;

public class NotificationReservationExternalService(INotificationsContextFacade notificationsContextFacade) : INotificationReservationExternalService
{
    public async Task<int> CreateNotification(
        string title,
        string description,
        int userId
    )
    {
        return await notificationsContextFacade.CreateNotification(title, description, userId);
    }
}