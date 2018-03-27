namespace Buckaroo
{
  public class ConfiguredTransaction
  {
    internal TransactionRequest BaseTransaction { get; private set; }

    public ConfiguredTransaction(TransactionRequest transaction)
    {
      BaseTransaction = transaction;
    }

    public IdealTransaction Ideal() => new IdealTransaction(this);
    public IdealProcessingTransaction IdealProcessing() => new IdealProcessingTransaction(this);
    public PayPerEmailTransaction PayPerEmail() => new PayPerEmailTransaction(this);
    public TransferTransaction Transfer() => new TransferTransaction(this);
    public PayPalTransaction PayPal() => new PayPalTransaction(this);
    public MasterCardTransaction Mastercard() => new MasterCardTransaction(this);
    public VisaTransaction Visa() => new VisaTransaction(this);
    public MaestroTransaction Maestro() => new MaestroTransaction(this);
    public SimpleSepaDirectDebitTransaction SimpleSepaDirectDebit() => new SimpleSepaDirectDebitTransaction(this);
    public AmericanExpressTransaction AmericanExpress() => new AmericanExpressTransaction(this);
    public BancontactTransaction Bancontact() => new BancontactTransaction(this);
    public AfterPayTransaction AfterPay() => new AfterPayTransaction(this);
    public SofortTransaction Sofort() => new SofortTransaction(this);
    public VPayTransaction VPay() => new VPayTransaction(this);
    public WebshopGiftcardTransaction WebshopGiftCard() => new WebshopGiftcardTransaction(this);
    public FashionchequeTransaction Fashioncheque() => new FashionchequeTransaction(this);
    public YourGiftTransaction YourGift() => new YourGiftTransaction(this);
    public VVVTransaction VVV() => new VVVTransaction(this);
  }
}