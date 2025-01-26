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
            var charEntities = GenerateEmptyCharEntities(size, size);
            
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

        [Test]
        public void Test_00_03_Row_Resolve()
        {
            // Arrange
            var size = 4;
            char[][] chars =
            {
                new[] { 'a', 'a', 'a', 'b' },
                new[] { 'b', 'c', 'd', 'e' },
                new[] { 'f', 'g', 'h', 'i' },
                new[] { 'j', 'k', 'l', 'm' }
            };
            var charEntities = GenerateCharEntitiesForChars(chars);
            
            // Act
            var entityResolver = new EntityResolver(charEntities);
            entityResolver.Resolve();
            var resolvedField = entityResolver.GetResolvedField();
            
            // Assert
            bool[][] expected =
            {
                new[] { true, true, true, false },
                new[] { false, false, false, false },
                new[] { false, false, false, false },
                new[] { false, false, false, false }
            };
            CustomAssertions.AreEqual(resolvedField, expected);
        }

        private Entity[][] GenerateEmptyCharEntities(int rows, int columns)
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

        private Entity[][] GenerateCharEntitiesForChars(char[][] chars)
        {
            var charEntities = new Entity[chars.Length][];
            for (var row = 0; row < charEntities.Length; row++)
            {
                charEntities[row] = new Entity[chars[row].Length];
                for (var column = 0; column < charEntities[row].Length; column++)
                {
                    CharEntity charEntity = new CharEntity();
                    charEntity.Symbol = chars[row][column];
                    charEntities[row][column] = charEntity;
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