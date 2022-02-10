using MaxNumber;
using NUnit.Framework;
namespace MaxNumberTest
{
    public class Tests
    {
        MaximumNumber max = new MaximumNumber();
        [Test]
        public void GivenThreeIntNumFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(3,2,1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(2, 3, 1);
            Assert.AreEqual(3, maximumInt);
        }

        [Test]
        public void GivenThreeIntNumThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            int maximumInt = max.IntMax(2, 1, 3);
            Assert.AreEqual(3, maximumInt);
        }

        //Float numbers
        [Test]
        public void GivenThreeFloatNumFirstPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = max.FloatMax(5.0f, 1.3f, 2.2f);
            Assert.AreEqual(5.0, maximumFloat);
        }

        [Test]
        public void GivenThreeFloatNumSecondPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = max.FloatMax(1.3f, 5.0f, 2.2f);
            Assert.AreEqual(5.0, maximumFloat);
        }

        [Test]
        public void GivenThreeFloatNumThirdPosition_WhenChecked_ThenShouldReturnMax()
        {
            float maximumFloat = max.FloatMax(2.2f, 1.3f, 5.0f);
            Assert.AreEqual(5.0, maximumFloat);
        }

    }
}