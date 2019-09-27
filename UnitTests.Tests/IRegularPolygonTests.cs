using UnitTests.Library;
using Moq;
using NUnit.Framework;
using NSubstitute;
using FakeItEasy;

namespace UnitTests.Tests 
{
    public class FakePolygonWithDefault : IRegularPolygon
    {
        public int NumberOfSides { get { return 4; } }
        public int SideLength { get { return 5; } set { } }
        public double GetArea() => NumberOfSides * SideLength;
    }

    public class FakePolygonWithOverride : IRegularPolygon
    {
        public int NumberOfSides { get { return 4; } }
        public int SideLength { get { return 5; } set { } }
        public double GetPerimeter => NumberOfSides * SideLength;
        public double GetArea() => SideLength * SideLength;
    }


    public class IRegularPolygonTests
    {
        [Test]
        public void FakeObject_CheckDefaultImplementation()
        {
            IRegularPolygon fake = new FakePolygonWithDefault();

            double result = fake.GetPerimeter();

            Assert.AreEqual(20.0, result);
        }

        [Test]
        public void FakeObject_OverrideDefaultImplementation()
        {
            IRegularPolygon fake = new FakePolygonWithOverride();

            double result = fake.GetPerimeter();

            Assert.AreEqual(20.0, result);
        }

        [Test]
        public void Moq_CheckDefaultImplementation()
        {
            var mock = new Mock<IRegularPolygon>();
            mock.SetupGet(m => m.NumberOfSides).Returns(3);
            mock.SetupGet(m => m.SideLength).Returns(5);

            double result = mock.Object.GetPerimeter();

            Assert.AreEqual(15.0, result);
        }

        [Test]
        public void Moq_OverrideDefaultImplementation()
        {
            var mock = new Mock<IRegularPolygon>();
            mock.SetupGet(m => m.NumberOfSides).Returns(3);
            mock.SetupGet(m => m.SideLength).Returns(5);
            mock.Setup(m => m.GetPerimeter()).Returns(
                (mock.Object.SideLength * mock.Object.NumberOfSides));

            double result = mock.Object.GetPerimeter();

            Assert.AreEqual(15.0, result);
        }

        [Test]
        public void NSubstitute_CheckDefaultImplementation()
        {
            var mock = Substitute.For<IRegularPolygon>();
            mock.NumberOfSides.Returns(3);
            mock.SideLength.Returns(5);

            double result = mock.GetPerimeter();

            Assert.AreEqual(15.0, result);
        }

        [Test]
        public void NSubstitute_OverrideDefaultImplementation()
        {
            var mock = Substitute.For<IRegularPolygon>();
            mock.NumberOfSides.Returns(3);
            mock.SideLength.Returns(5);
            double perimeter = mock.NumberOfSides * mock.SideLength;
            mock.GetPerimeter().Returns(perimeter);

            double result = mock.GetPerimeter();

            Assert.AreEqual(15,0, result);
        }

        [Test]
        public void FakeItEasy_CheckDefaultImplementation()
        {
            var mock = A.Fake<IRegularPolygon>();
            A.CallTo(() => mock.NumberOfSides).Returns(3);
            A.CallTo(() => mock.SideLength).Returns(5);

            double result = mock.GetPerimeter();

            Assert.AreEqual(15.0, result);
        }

        [Test]
        public void FakeItEasy_OverrideDefaultImplementation()
        {
            var mock = A.Fake<IRegularPolygon>();
            A.CallTo(() => mock.NumberOfSides).Returns(3);
            A.CallTo(() => mock.SideLength).Returns(5);
            A.CallTo(() => mock.GetPerimeter()).Returns(mock.NumberOfSides * mock.SideLength);

            double result = mock.GetPerimeter();

            Assert.AreEqual(15.0, result);
        }
    }
}
