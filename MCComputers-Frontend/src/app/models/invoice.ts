export interface Invoice {
    id: number;
    CustomerID: number;
    TransactionDate: Date;
    ProductID: number;
    Discount: number;
    Quantity: number;
    TotalAmount: number;
    BalanceAmount: number;    
}