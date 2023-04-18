using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared;

public class BankAccount
{
    public string? AccountName; //intance member
    public decimal Balance; //instance member
    public static decimal InterestRate; //shared member
}