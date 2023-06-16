using NUnit.Framework;
using TreeHeight;

namespace TreeTests
{
    public class CalculatorShould
    {
        private int randHeight;

        [SetUp]
        public void SetUp()
        {
            randHeight = 0;
        }

        [Test]
        [Repeat(100)]
        public void ReturnCorrectHeightOnRandomSeed()
        {
            var root = new Branch();
            PopulateNodes(root);

            var actualHeight = HeightCalculator.GetHeight(root);

            var expectedHeight = randHeight;

            Assert.That(actualHeight, Is.EqualTo(expectedHeight));
        }

        private void PopulateNodes(Branch branch, int h = 1)
        {
            randHeight = Math.Max(randHeight, h);

            var nodesCount = h < 30 ? new Random().Next(2) : 0;
            var children = Enumerable.Repeat(new Branch(), nodesCount).ToList();

            branch.Branches = children;

            foreach (var child in branch.Branches) 
                PopulateNodes(child, h + 1);
        }
    }
}