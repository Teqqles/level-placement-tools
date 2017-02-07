public class FlagConfig
{
    private const float DEFAULT_SIZE_OF_FLAG = 3f;
    private const float DEFAULT_FLAG_WEIGHT = 0.2f;
    private const float DEFAULT_BASE_WEIGHT = 0.05f;

    private float _sizeOfFlag = 3f;
    public float sizeOfFlag
    {
        get
        {
            return _sizeOfFlag;
        }
        set
        {
            _sizeOfFlag = value;
        }
    }

    private float _weightOfFlagAgainstPoleLength = DEFAULT_FLAG_WEIGHT;
    public float WeightOfFlagAgainstPoleLength
    {
        get
        {
            return _weightOfFlagAgainstPoleLength;
        }

        set
        {
            _weightOfFlagAgainstPoleLength = value;
        }
    }

    private float _weightOfBaseAgainstPoleLength = DEFAULT_BASE_WEIGHT;
    public float WeightOfBaseAgainstPoleLength
    {
        get
        {
            return _weightOfBaseAgainstPoleLength;
        }

        set
        {
            _weightOfBaseAgainstPoleLength = value;
        }
    }

    public float flagScale
    {
        get
        {
            return _weightOfFlagAgainstPoleLength * _sizeOfFlag;
        }
    }

    public float boxScale
    {
        get
        {
            return _weightOfBaseAgainstPoleLength * _sizeOfFlag;
        }
    }
}
