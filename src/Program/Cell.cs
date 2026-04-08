public class Cell
{
    public bool IsAlive {get; private set;}

    public Cell(bool isAlive)
    {
        IsAlive = isAlive;
    }

    public void UpdateState(bool isAlive)
    {
        IsAlive = isAlive;
    }
}