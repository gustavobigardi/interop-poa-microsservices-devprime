namespace Application.EventHandlers;
public class EventHandler : IEventHandler
{

    public EventHandler(IHandler handler)
    {
        handler.Add<OrderUpdated, OrderUpdatedEventHandler>();
        handler.Add<OrderGet, OrderGetEventHandler>();
        handler.Add<OrderDeleted, OrderDeletedEventHandler>();
        handler.Add<OrderCreated, OrderCreatedEventHandler>();
    }
}