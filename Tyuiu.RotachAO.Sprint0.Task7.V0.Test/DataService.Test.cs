using Tyuiu.RotachAO.Sprint0.Task7.V0.Lib;

namespace Tyuiu.RotachAO.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = { 1, 1, 1, 1, 1 };
            int[] nums2 = { 1, 1, 1, 1, 1 }; int[] nums3 = { 2, 2, 2, 2, 2 };
            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEqual(nums3, res);
        }
    }
}