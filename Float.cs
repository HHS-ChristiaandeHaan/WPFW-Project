namespace Week1Project;
public static class Float
{
    public static string metSuffixen(this float i)
    {
        if (i < 1000){ // duizend
            //i = i/10;
            return String.Format("{0:0.0}", i);
        }
        if (i < 1000000){ // duizend
            i = i/1000;
            return String.Format("{0:0.0D}", i);
        }
        if (i < 999999999){ //milloen
            i = i/1000000;
            return String.Format("{0:0.0M}", i);
        }
        if (i < 999999999999){ //milliard
            i = i/1000000000;
            return String.Format("{0:0.0B}", i);
        }
        return i + " implementatie missing" ;
    }
}