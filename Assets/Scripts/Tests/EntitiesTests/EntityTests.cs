using Framework.Entities;
using NUnit.Framework;

namespace Tests.EntitiesTests
{
    [TestFixture]
    public class EntityTests
    {
        [TestCase]
        public void Test_Equals()
        {
            // Arrange
            Entity e1 = new Entity();
            Entity e2 = new Entity();
            
            // Act
            bool e1EqualsE2 = e1.Equals(e2);
            bool e2EqualsE1 = e2.Equals(e1);
            bool e1EqualsNull = e1.Equals(null);
            bool e2EqualsNull = e2.Equals(null);
            
            bool e1EqualsE1 = e1.Equals(e1);
            bool e2EqualsE2 = e2.Equals(e2);
            
            // Assert
            Assert.AreEqual(e1EqualsE2, false);
            Assert.AreEqual(e2EqualsE1, false);
            Assert.AreEqual(e1EqualsNull, false);
            Assert.AreEqual(e2EqualsNull, false);
            
            Assert.AreEqual(e1EqualsE1, true);
            Assert.AreEqual(e2EqualsE2, true);
        }

        [TestCase]
        public void Test_Equals_Operator()
        {
            // Arrange
            Entity e1 = new Entity();
            Entity e2 = new Entity();
            
            // Act
            bool e1EqualsE2 = e1 == e2;
            bool e2EqualsE1 = e2 == e1;
            bool e1EqualsNull = e1 == null;
            bool e2EqualsNull = e2 == null;
            
            bool e1EqualsE1 = e1 == e1;
            bool e2EqualsE2 = e2 == e2;
            
            // Assert
            Assert.AreEqual(e1EqualsE2, false);
            Assert.AreEqual(e2EqualsE1, false);
            Assert.AreEqual(e1EqualsNull, false);
            Assert.AreEqual(e2EqualsNull, false);
            
            Assert.AreEqual(e1EqualsE1, true);
            Assert.AreEqual(e2EqualsE2, true);
        }
        
        [TestCase]
        public void Test_Not_Equals_Operator()
        {
            // Arrange
            Entity e1 = new Entity();
            Entity e2 = new Entity();
            
            // Act
            bool e1EqualsE2 = e1 != e2;
            bool e2EqualsE1 = e2 != e1;
            bool e1EqualsNull = e1 != null;
            bool e2EqualsNull = e2 != null;
            
            bool e1EqualsE1 = e1 != e1;
            bool e2EqualsE2 = e2 != e2;
            
            // Assert
            Assert.AreEqual(e1EqualsE2, true);
            Assert.AreEqual(e2EqualsE1, true);
            Assert.AreEqual(e1EqualsNull, true);
            Assert.AreEqual(e2EqualsNull, true);
            
            Assert.AreEqual(e1EqualsE1, false);
            Assert.AreEqual(e2EqualsE2, false);
        }
    }
}