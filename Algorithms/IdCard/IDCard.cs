using Algorithms.IdCard;

public class IDCard
{
    private Name name;
    private PostalCode postalCode;
    private TelephonNumber telephonNumber;

    public IDCard(Name name,
                  PostalCode postalCode,
                  TelephonNumber telephonNumber)
    {

        this.name = name;
        this.postalCode = postalCode;
        this.telephonNumber = telephonNumber;
    }

    public bool IsValid()
    {
        return name.IsValid()
        && telephonNumber.IsValid()
        && postalCode.IsValid();
    }
}