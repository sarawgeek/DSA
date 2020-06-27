using System.Collections.Generic;

namespace GS.Util
{
    public class StackUtility
{
    #region Reverse String
    public string reverseString(string input)
    {
        Stack<char> stringToBeReversed = new Stack<char>();
        string toReturn = string.Empty;
        foreach (char item in input)
        {
            stringToBeReversed.Push(item);
        }
        for (int i = 0; i < input.Length; i++)
        {
            toReturn += stringToBeReversed.Pop();
        }
        return toReturn;
    }
    #endregion

    public bool BalancedExpression(string input)
    {
        //Stack<char> braces = new Stack<char>();
        //var regex = "^[a-zA-Z0-9 ]*$";
        //string bracesCollection = "({<[";
        //foreach (char item in input)
        //{
        //    if (bracesCollection.Contains(item))
        //    {
        //        braces.Push(item);
        //    }
        //    else if(braces.Count>0 && item == braces.Peek())
        //    {
        //        braces.Pop();
        //    }
        //    else if (!Regex.IsMatch(item.ToString(),regex))
        //    {
        //        return false;
        //    }
        //}
        //if (braces.Count == 0)
        //{
        //    return true;
        //}
        //else return false;
        return true;
    }


}
}
