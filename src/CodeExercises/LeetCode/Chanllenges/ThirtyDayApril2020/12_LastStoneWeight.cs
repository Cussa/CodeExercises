using System.Linq;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class LastStoneWeight
    {
        public int Resolve(int[] stones)
        {
            var listStones = stones.ToList();

            while (listStones.Count > 1)
            {
                listStones = listStones.OrderByDescending(x => x).ToList();
                var stone1 = listStones.Take(1).Single();
                var stone2 = listStones.Skip(1).Take(1).Single();

                listStones.RemoveRange(0, 2);

                var newStone = stone1 - stone2;
                if (newStone > 0)
                    listStones.Add(newStone);
            }

            return listStones.Count == 1 ? listStones[0] : 0;
        }
    }
}
