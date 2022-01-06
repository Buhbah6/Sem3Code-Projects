package Q4_1;

/**
 * @author Anthony Nadeau
 */
public class Stock {
    private int stockNumber;
    private Data data;
    
    public Stock(int stockNumber, Data data) {
        this.stockNumber = stockNumber;
        this.data = data;
    }

    @Override
    public String toString() {
        return String.format("StockNumber: %d\n" + data.toString(), stockNumber);
    }

    public int getStockNumber() {
        return stockNumber;
    }

    public Data getData() {
        return data;
    }
}
