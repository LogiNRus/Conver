namespace PhysicValuesLib.Values;

public class Distance : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Дистанция";

    private List<string> _measureList = new List<string>()
    {
        
        "Сантиметры",
        "Метры",
        "Километры"
    };

    /// <summary>
    /// Метод возвращает конвертированное значение
    /// </summary>
    /// <returns></returns>
    public double GetConvertedValue(double value, string from, string to)
    {
        Value = value;
        From = from;
        To = to;

        ToSi();
        ToRequired();
        return Value;
    }

    /// <summary>
    /// Метод возвращает список единиц измерения
    /// </summary>
    /// <returns></returns>
    public List<string> GetMeasureList()
    {
        return _measureList;
    }

    /// <summary>
    /// Метод конвертирует в нужные единицы измерения
    /// </summary>
    public void ToRequired()
    {
        switch (To)
        {
            
            case "Сантиметры":
                break;
            case "Метры":
                Value /= 100;
                break;
            case "Километры":
                Value *= 100000;
                break;
        }
    }

    /// <summary>
    /// Метод переводит в систему СИ
    /// </summary>
    public void ToSi()
    {
        switch (From)
        {
            
            case "Сантиметры":
                break;
            case "Метры":
                Value *= 100;
                break;
            case "Киллометры":
                Value /= 100000;
                break;
        }
    }

    public string GetValueName()
    {
        return _valueName;
    }
}