class Display
{
    private double size;
    private int colors;

    public Display(double size, int colors)
    {
        this.size = size;
        this.colors = colors;
    }

    public double Size 
    {
        get
        {
            return size;
        }
    }
    public int Colors
    {
        get 
        {
            return colors;
        }
    }
}