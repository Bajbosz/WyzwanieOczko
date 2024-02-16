namespace WyzwanieOczko
{
    public interface IEmployee
    {
        string Name { get; }
        string SurName { get; }
        void AddScore(float score);
        void AddScore(string score);
        void AddScore(int score);
        void AddScore(double score);
        void AddScore(long score);
        void AddScore(char score);
        Statistics GetStatistics();

    }
}
