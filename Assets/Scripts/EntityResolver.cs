public class EntityResolver
{
    private Entity[][] entities;

    public EntityResolver(Entity[][] entities)
    {
        this.entities = entities;
    }

    public void Resolve()
    {
        for (int i = 0; i < entities.Length; i++)
        {
            for (int j = 0; j < entities[i].Length; j++)
            {
                ResolveNeighbours(i, j);
            }
        }
    }

    private void ResolveNeighbours(int x, int y)
    {
        
    }

    private void ResolveNeighboursUp(int x, int y)
    {
        if (x < 2)
        {
            return;
        }

        if (entities[x][y] == entities[x - 1][y] && entities[x - 1][y] == entities[x - 2][y])
        {
            // Resolved up
        }
    }

    private void ResolveNeighboursDown(int x, int y)
    {
        if (x > entities.Length - 3)
        {
            return;
        }

        if (entities[x][y] == entities[x + 1][y] && entities[x + 1][y] == entities[x + 2][y])
        {
            // Resolved down
        }
    }

    private void ResolveNeighboursLeft(int x, int y)
    {
        if (y < 2)
        {
            return;
        }

        if (entities[x][y] == entities[x][y - 1] && entities[x][y - 1] == entities[x][y - 2])
        {
            // Resolved left
        }
    }

    private void ResolveNeighboursRight(int x, int y)
    {
        if (y > entities[x].Length)
        {
            return;
        }

        if (entities[x][y] == entities[x][y + 1] && entities[x][y] == entities[x][y + 2])
        {
            // Resolved right
        }
    }
}