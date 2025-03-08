namespace HW;

class Program
{
    public static void senrev(string s, out string sentrev)
    {
        sentrev = "";
        string kalame = "";
        int spacecount = 0 ;
        s += " ";
        for(int i=0; i<s.Length; i++)
        {          
            if(s[i] != ' ' && spacecount==0)
                kalame += s[i];
            else if( s[i] != ' ' && spacecount !=0 )
                {
                int j = i;
                kalame += s[j];
                }
            else if( s[i] == ' ')
            {
                spacecount++;
                sentrev = kalame + ' ' + sentrev;
                kalame = "";
            }              
        }
    }
    static void Main(string[] args)
    {
        string str = "My name is Mobina";
        string srev = "";
        senrev(str,out srev);
        System.Console.WriteLine(srev);
    }
}
