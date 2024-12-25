namespace TestProject91;

public class Tennis
{
    private readonly string _firstPlayerName;
    private readonly string _secondPlayerName;
    private int _firstPlayerScore;
    private int _secondPlayerScore;
    private Dictionary<int, string> _scoreToDisplayLookup = new()
    {
        {0, "love"},
        {1, "fifteen"},
        {2, "thirty"},
        {3, "forty"}
    };
    
    
    public Tennis(string firstPlayerName, string secondPlayerName)
    {
        _firstPlayerName = firstPlayerName;
        _secondPlayerName = secondPlayerName;
    }

    public string FirstPlayerGoal()
    {
        _firstPlayerScore++;
        return Score();
    }
    
    public string SecondPlayerGoal()
    {
        _secondPlayerScore++;
        return Score();
    }
    
    public string Score()
    {
        if (_firstPlayerScore == _secondPlayerScore)
        {
            if (_firstPlayerScore >= 3)
            {
                return "deuce";
            }
            
            return $"{_scoreToDisplayLookup[_firstPlayerScore]} all";
        }

        if (_firstPlayerScore > 3 || _secondPlayerScore > 3)
        {
            // adv
            if (Math.Abs(_firstPlayerScore - _secondPlayerScore) == 1)
            {
                var advPlayerName = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
                return $"{advPlayerName} adv";
            }
            
            // win
            if (Math.Abs(_firstPlayerScore - _secondPlayerScore) >= 2)
            {
                var winPlayerName = _firstPlayerScore > _secondPlayerScore ? _firstPlayerName : _secondPlayerName;
                return $"{winPlayerName} win";
            } 
        }

        return $"{_scoreToDisplayLookup[_firstPlayerScore]} {_scoreToDisplayLookup[_secondPlayerScore]}";
    }
}