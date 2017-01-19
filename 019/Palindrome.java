import java.util.Scanner;

public class Palindrome
{
    private Scanner keyboard;

    public Palindrome()
    {
        keyboard = new Scanner(System.in);
    }

    boolean isPalindrome(String str) 
    {    
        //replace whitescpce with nothing, change all chars to lowercase
        String newS = str.replaceAll("\\s", "").trim().toLowerCase();
        int n = newS.length();
        //loop through half of the string
        for( int i = 0; i < n/2; i++ )
        {
            // if the current char does not equal the char on the other half 
            // of the string then return false
            if (newS.charAt(i) != newS.charAt(n-i-1)) 
            {
                return false;
            }
        }
        return true; 
    }
}
