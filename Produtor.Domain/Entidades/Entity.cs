using Flunt.Notifications;

namespace Produtor.Domain.Entidades
{
    public abstract class Entity : Notifiable
    {
        public Entity() 
        {
            Id = 0;
        }

        public int Id { get; private set; }
    }
}
