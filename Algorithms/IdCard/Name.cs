namespace Algorithms.IdCard;

using System;

public class Name
{
    private string firstName;
    private string lastName;

    public Name(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    private bool constainsNumber(string word){
        string digits =  "0123456789";
        foreach (char digit in digits){
            if(word.IndexOf(digit) != -1){
                return true;
            }
        }
        return false;
    }

    public bool IsValid(){
        if(constainsNumber(this.firstName) || constainsNumber(this.lastName)){
            return false;
        }
        return this.firstName.Length > 1 && this.lastName.Length > 1;
    }

}