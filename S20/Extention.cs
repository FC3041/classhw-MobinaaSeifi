public static class EXT // کلاس static کلاسیه که لازم نیست ازش object تعریف کنیم.
{
    public static string TitleCase(this string str)
    {
        if ( str == null)
            return str;
        return char.ToUpper(str[0]) + str.Substring(1);
    }

    public static int CountDigit(this string str)
    {
        if(str == null)
            return 0;
        int n = 0;
        foreach(char c in str)
        {
            if(char.IsDigit(c))
                n++;
        }
        return n;
        
    }
}