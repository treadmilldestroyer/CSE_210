class Animal
{
    protected string _name;
    protected int _qrCode;


    public void SetName(string name)
    {
        _name = name;
    }
    public void SetQRCode(int qrCode)
    {
        _qrCode = qrCode;
    }
}

class Aquatic : Animal
{

}

class Desert : Animal
{

}

class Program
{
    static void Main(string[] args)
    {
        Desert lizard = new Desert();
        lizard.SetName("Desert Iguana");
        lizard.SetQRCode(1234567890);
    }
}