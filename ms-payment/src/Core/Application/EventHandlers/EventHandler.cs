namespace Application.EventHandlers;
public class EventHandler : IEventHandler
{

    public EventHandler(IHandler handler)
    {
        handler.Add<PaymentGet, PaymentGetEventHandler>();
        handler.Add<PaymentDeleted, PaymentDeletedEventHandler>();
        handler.Add<PaymentCreated, PaymentCreatedEventHandler>();
        handler.Add<PaymentUpdated, PaymentUpdatedEventHandler>();
    }
}