namespace Shuffle.Sources.content.Shuffle
{
    public interface IRandomWrapper
    {
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
    }
}