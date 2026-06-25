namespace _3.ExtentionMethod.CustomExtentions;

public static class CustomExtention
{
    // "Kamran".HasSymbol("Kam")
    // string.HasSymbol("Kamran", "Kam")
    public static bool HasSymbol(this string str, string symbol)
    {
        return str.ToLower().Contains(symbol.ToLower());
    }

    public static int MiddleElement(this List<int> collection)
    {
        var middleIndex = (collection.Count() - 1) / 2;
        return collection[middleIndex];
    }


}
