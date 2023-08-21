using System.Text.RegularExpressions;

namespace Algorithms.IdCard;

public class TelephonNumber
{
    private string telephonNumber;

    public TelephonNumber(string telephonNumber)
    {
        this.telephonNumber = telephonNumber;
    }



    public bool IsValid(){
        Regex rx = new Regex(@"^(\+?1 )?\d{3} \d{3}-\d{4}$");
        return rx.Match(this.telephonNumber).Success;
    }

}