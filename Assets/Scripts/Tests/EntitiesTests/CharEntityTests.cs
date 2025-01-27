using Framework.Entities;
using NUnit.Framework;

namespace Tests.EntitiesTests
{
    [TestFixture]
    public class CharEntityTests
    {
        [TestCase]
        public void Test_Equals()
        {
            // Arrange
            CharEntity a1 = new CharEntity
            {
                Symbol = 'A'
            };

            CharEntity a2 = new CharEntity
            {
                Symbol = 'A'
            };
            
            CharEntity b = new CharEntity
            {
                Symbol = 'B'
            };

            Entity e = new Entity();
            
            // Act
            bool a1EqualsA2 = a1.Equals(a2);
            bool a1EqualsB = a1.Equals(b);
            bool a1EqualsE = a1.Equals(e);
            bool a1EqualsNull = a1.Equals(null);
            
            // Assert
            Assert.AreEqual(a1EqualsA2, true);
            Assert.AreEqual(a1EqualsB, false);
            Assert.AreEqual(a1EqualsE, false);
            Assert.AreEqual(a1EqualsNull, false);
        }

        [TestCase]
        public void Test_Equals_Operator()
        {
            // Arrange
            CharEntity a1 = new CharEntity
            {
                Symbol = 'A'
            };

            CharEntity a2 = new CharEntity
            {
                Symbol = 'A'
            };
            
            CharEntity b = new CharEntity
            {
                Symbol = 'B'
            };

            Entity e = new Entity();
            
            // Act
            bool a1EqualsA2 = a1 == a2;
            bool a1EqualsB = a1 == b;
            bool a1EqualsE = a1 == e;
            bool a1EqualsNull = a1 == null;
            
            // Assert
            Assert.AreEqual(a1EqualsA2, true);
            Assert.AreEqual(a1EqualsB, false);
            Assert.AreEqual(a1EqualsE, false);
            Assert.AreEqual(a1EqualsNull, false);
        }

        [TestCase]
        public void Test_Not_Equals_Operator()
        {
            // Arrange
            CharEntity a1 = new CharEntity
            {
                Symbol = 'A'
            };

            CharEntity a2 = new CharEntity
            {
                Symbol = 'A'
            };
            
            CharEntity b = new CharEntity
            {
                Symbol = 'B'
            };

            Entity e = new Entity();
            
            // Act
            bool a1EqualsA2 = a1 != a2;
            bool a1EqualsB = a1 != b;
            bool a1EqualsE = a1 != e;
            bool a1EqualsNull = a1 != null;
            
            // Assert
            Assert.AreEqual(a1EqualsA2, false);
            Assert.AreEqual(a1EqualsB, true);
            Assert.AreEqual(a1EqualsE, true);
            Assert.AreEqual(a1EqualsNull, true);
        }
    }
}