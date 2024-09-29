namespace cw6.Models;

public class Numbers {
    private List<int> _numbers;

    public List<int> NumbersList {
        get {
            return _numbers;
        }
    }

    public Numbers(int size=10) {
        _numbers = new List<int>();
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            _numbers.Add(random.Next(1, 100));
        }
    }
    public int GetMax()
    {
        int index = 0;
        int max = _numbers[0];
        for (int i = 0; i < _numbers.Count; i++) {
            if (_numbers[i] > max) {
                index = i;
                max = _numbers[i];
            }
        }
        return index;
    }
    public int GetMin()
    {
        return _numbers.Min();
    }
    public double GetAvg()
    {
        return _numbers.Average();
    }

}