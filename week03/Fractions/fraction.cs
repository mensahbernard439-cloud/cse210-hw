public class Fraction
{
    // 3. Private attributes for top and bottom numbers
    private int _top;
    private int _bottom;

    // --- CONSTRUCTORS ---

    // 1. No-argument constructor: initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // 2. One-argument constructor: initializes top, and bottom to 1 (e.g., 5/1)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // 3. Two-argument constructor: initializes both top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // --- GETTERS AND SETTERS ---

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // --- METHODS FOR REPRESENTATIONS ---

    // Returns fraction string like "3/4"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns decimal value as a double (casts top to double to avoid integer division)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}