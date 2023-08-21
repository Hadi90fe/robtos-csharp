namespace Algorithms;

public class IntChainLink
{
    private int value;
    private IntChainLink? lst;

    public IntChainLink(int value)
    {
        this.value = value;
        this.lst = null;
    }

    public IntChainLink(int value, IntChainLink lst)
    {
        this.value = value;
        this.lst = lst;
    }

    public int Head()
    {
        return value;
    }

    public IntChainLink Rest()
    {
        return lst!;
    }
}