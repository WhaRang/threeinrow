using System;

namespace Framework.Entities
{
    public class EntityField
    {
        private Entity[] entities;

        public EntityField()
        {
            entities = Array.Empty<Entity>();
        }

        public EntityField(int size)
        {
            entities = new Entity[size];
            for (int i = 0; i < entities.Length; i++)
            {
                entities[i] = new Entity();
            }
        }

        public EntityField(Entity[] entities)
        {
            this.entities = entities;
        }
    }
}