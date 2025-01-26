namespace Entities
{
    public class EntityResolver
    {
        private bool[][] resolvedField;
        private Entity[][] entities;

        public EntityResolver(Entity[][] entities)
        {
            this.entities = entities;
            
            resolvedField = new bool[entities.Length][];
            for (int i = 0; i < resolvedField.Length; i++)
            {
                resolvedField[i] = new bool[entities[i].Length];
            }
        }

        public void Resolve()
        {
            for (int i = 0; i < entities.Length; i++)
            {
                for (int j = 0; j < entities[i].Length; j++)
                {
                    ResolveNeighboursClockwiseStartingWithRight(i, j);
                }
            }
        }

        private void ResolveNeighboursClockwiseStartingWithRight(int x, int y)
        {
            if (TryResolveNeighboursRight(x, y))
            {
                return;
            }
            
            if (TryResolveNeighboursDown(x, y))
            {
                return;
            }

            if (TryResolveNeighboursLeft(x, y))
            {
                return;
            }

            TryResolveNeighboursUp(x, y);
        }

        private bool TryResolveNeighboursUp(int x, int y)
        {
            if (IsNotResolvableUp(x, y))
            {
                return false;
            }

            ResolveNeighboursUp(x, y);
            return true;
        }

        private bool IsNotResolvableUp(int x, int y)
        {
            return x < 2
                   || resolvedField[x][y]
                   || resolvedField[x - 1][y]
                   || resolvedField[x - 2][y]
                   || entities[x][y] != entities[x - 1][y]
                   || entities[x - 1][y] != entities[x - 2][y];
        }

        private void ResolveNeighboursUp(int x, int y)
        {
            resolvedField[y][x] = resolvedField[x - 1][y] = resolvedField[x - 2][y] = true;
        }

        private bool TryResolveNeighboursDown(int x, int y)
        {
            if (IsNotResolvableDown(x, y))
            {
                return false;
            }

            ResolveNeighboursDown(x, y);
            return true;
        }

        private bool IsNotResolvableDown(int x, int y)
        {
            return x > entities.Length - 3
                   || resolvedField[x][y]
                   || resolvedField[x + 1][y]
                   || resolvedField[x + 2][y]
                   || entities[x][y] != entities[x + 1][y]
                   || entities[x + 1][y] != entities[x + 2][y];
        }

        private void ResolveNeighboursDown(int x, int y)
        {
            resolvedField[y][x] = resolvedField[x + 1][y] = resolvedField[x + 2][y] = true;
        }

        private bool TryResolveNeighboursLeft(int x, int y)
        {
            if (IsNotResolvableLeft(x, y))
            {
                return false;
            }

            ResolveNeighboursLeft(x, y);
            return true;
        }

        private bool IsNotResolvableLeft(int x, int y)
        {
            return y < 2
                   || resolvedField[x][y]
                   || resolvedField[x][y - 1]
                   || resolvedField[x][y - 2]
                   || entities[x][y] != entities[x][y - 1]
                   || entities[x][y - 1] != entities[x][y - 2];
        }

        private void ResolveNeighboursLeft(int x, int y)
        {
            resolvedField[y][x] = resolvedField[x][y - 1] = resolvedField[x][y - 2] = true;
        }

        private bool TryResolveNeighboursRight(int x, int y)
        {
            if (IsNotResolvableRight(x, y))
            {
                return false;
            }
            
            ResolveNeighboursRight(x, y);
            return true;
        }

        private bool IsNotResolvableRight(int x, int y)
        {
            return y > entities[x].Length - 3
                   || resolvedField[x][y]
                   || resolvedField[x][y + 1]
                   || resolvedField[x][y + 2]
                   || entities[x][y] != entities[x][y + 1]
                   || entities[x][y + 1] != entities[x][y + 2];
        }
        
        private void ResolveNeighboursRight(int x, int y)
        {
            resolvedField[y][x] = resolvedField[x][y + 1] = resolvedField[x][y + 2] = true;
        }
    }
}