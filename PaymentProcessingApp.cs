using System;

public class PaymentProcessingApp
{
    public static void Main(string[] args)
    {
        // Creating an instance of CreditCardProcessor
        IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
        
        // Passing the CreditCardProcessor to PaymentService for processing payment
        PaymentService paymentService = new PaymentService(creditCardProcessor);
        
        // Process payment of 100.00 using Credit Card
        paymentService.OrderPayment(100.00m);

      
        
        // Creating an instance of PayPalProcessor
        IPaymentProcessor payPalProcessor = new PayPalProcessor();
        
        // Passing the PayPalProcessor to PaymentService for processing payment
        paymentService = new PaymentService(payPalProcessor);
        
        // Process payment of 200.00 using PayPal
        paymentService.OrderPayment(200.00m);

      
        
        // Creating an instance of BankProcessor
        IPaymentProcessor bankProcessor = new BankProcessor();
        
        // Passing the BankProcessor to PaymentService for processing payment
        paymentService = new PaymentService(bankProcessor);
        
        // Process payment of 300.00 using Bank Transfer
        paymentService.OrderPayment(300.00m);
    }
}

// The interface defining the method for processing payments
public interface IPaymentProcessor
{
    void PaymentProcess(decimal amount); // Method to process the payment of a specified amount
}

// Implementation of the CreditCardProcessor that processes payments using Credit Card
public class CreditCardProcessor : IPaymentProcessor
{
    public void PaymentProcess(decimal amount)
    {
        // Logic for processing payment using a credit card
        Console.WriteLine("Amount credited in Credit Card Processor: " + amount);
    }
}

// Implementation of the PayPalProcessor that processes payments using PayPal
public class PayPalProcessor : IPaymentProcessor
{
    public void PaymentProcess(decimal amount)
    {
        // Logic for processing payment using PayPal
        Console.WriteLine("Amount credited in PayPal Processor: " + amount);
    }
}

// Implementation of the BankProcessor that processes payments using Bank Transfer
public class BankProcessor : IPaymentProcessor
{
    public void PaymentProcess(decimal amount)
    {
        // Logic for processing payment using Bank Transfer
        Console.WriteLine("Amount credited in Bank Processor: " + amount);
    }
}

// The PaymentService class that handles payment processing
public class PaymentService
{
    // Readonly field to store the injected payment processor (CreditCard, PayPal, or Bank)
    private readonly IPaymentProcessor _processor;
    
    // Constructor that takes an IPaymentProcessor and initializes the _processor field
    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }
    
    // Method to process the payment by delegating to the payment processor's PaymentProcess method
    public void OrderPayment(decimal amount)
    {
        // Delegating the payment process to the injected processor
        _processor.PaymentProcess(amount);
    }
}
