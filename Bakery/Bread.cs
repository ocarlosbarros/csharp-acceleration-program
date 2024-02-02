class Bread
{
    public int Weight {get; set;}

    string _type = "";
    public string Type 
    {
        get{ return _type;} 
        set
        {
            if (value != "White" && value != "Wheat")
                throw new ArgumentException("Invalid bread type");

            _type = value;
        }
    }
}