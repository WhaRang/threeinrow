using Framework.Entities;
using NUnit.Framework;
using Tests.Custom;

namespace Tests.EntitiesTests
{
    [TestFixture]
    public class EntityResolverTests
    {
        [Test]
        public void Test_Empty_Resolved_Field()
        {
            // Arrange
            int size = 4;
            var charEntities = GenerateCharEntities(size, size);
            
            // Act
            var entityResolver = new EntityResolver(charEntities);
            var resolvedField = entityResolver.GetResolvedField();
            
            // Assert
            bool[][] expected =
            {
                new[] { false, false, false, false },
                new[] { false, false, false, false },
                new[] { false, false, false, false },
                new[] { false, false, false, false }
            };
            CustomAssertions.AreEqual(resolvedField, expected);
        }

        private Entity[][] GenerateCharEntities(int rows, int columns)
        {
            var charEntities = new Entity[rows][];
            for (var row = 0; row < charEntities.Length; row++)
            {
                charEntities[row] = new Entity[columns];
                for (var column = 0; column < charEntities[row].Length; column++)
                {
                    charEntities[row][column] = new CharEntity();
                }
            }
            
            return charEntities;
        }

        private bool[][] GetEmptyBoolMatrix(int size)
        {
            bool[][] matrix = new bool[size][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new bool[size];
            }

            return matrix;
        }
    }
}