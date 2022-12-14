using CA1_v1.Models;

namespace CA1_v1.Repository
{
    public interface IMockRepo
    {
        List<Match> GetFixtures();
        Match GetFixture(int Id);

        void CreateFixture(Match m);
        void EditFixture(Match m);
    }
}
