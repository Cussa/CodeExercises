namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class PerformStringShifts
    {
        public string Resolve(string s, int[][] shift)
        {
            if (shift == null || shift.Length == 0)
                return s;

            var moveLeft = 0;
            foreach (var change in shift)
            {
                var direction = change[0];
                var amount = change[1];

                moveLeft += direction == 0 ? amount : -amount;
            }

            moveLeft %= s.Length;

            if (moveLeft == 0)
                return s;

            if (moveLeft < 0)
                moveLeft = s.Length + moveLeft;

            return s.Substring(moveLeft) + s.Substring(0, moveLeft);
        }
    }
}
