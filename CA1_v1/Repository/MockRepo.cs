using CA1_v1.Models;

namespace CA1_v1.Repository
{
    public class MockRepo : IMockRepo
    {
        private static List<Match> Matches = new List<Match>();


        public void CreateFixture(Match m)
        {
            Matches.Add(m);
        }

        public void EditFixture(Match m)
        {
            var found = Matches.Find(x => x.MatchID == m.MatchID);
            if (found != null)
            {
                found.GoalsFor = m.GoalsFor;
                found.GoalsAgainst = m.GoalsAgainst;
            }
        }

        public List<Match> GetFixtures()
        {
            return Matches;
        }

        public Match GetFixture(int Id)
        {
            var found = Matches.FirstOrDefault(x => x.MatchID == Id);
            return found;
        }
    }
}
