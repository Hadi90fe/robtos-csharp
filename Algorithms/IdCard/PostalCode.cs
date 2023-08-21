using System.Text.RegularExpressions;

namespace Algorithms.IdCard;

public class PostalCode
{
    private string postalCode;
    public PostalCode(string postalCode)
    {
        this.postalCode = postalCode;
    }

    public bool IsValid(){
        Regex rx = new Regex(@"^[A-Z]\d[A-Z] \d[A-Z]\d$");
        return rx.Match(this.postalCode).Success;
    }
}