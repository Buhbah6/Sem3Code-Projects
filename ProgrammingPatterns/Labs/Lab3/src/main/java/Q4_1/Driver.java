package Q4_1;

import java.util.*;

/**
 * @author Anthony Nadeau
 */
public class Driver {
    
    public static void main(String[] args) {
        Map<Integer, Data> stockMap = new HashMap();
        
        Stock s1 = new Stock(1, new Data("GameStop", 100));
        Stock s2 = new Stock(3, new Data("AMC", 90));
        Stock s3 = new Stock(4, new Data("DOGE", 300000000));
        Stock s4 = new Stock(2, new Data("BTN", 1));
        
        stockMap.put(s1.getStockNumber(), s1.getData());
        stockMap.put(s2.getStockNumber(), s2.getData());
        stockMap.put(s3.getStockNumber(), s3.getData());
        stockMap.put(s4.getStockNumber(), s4.getData());
        
        System.out.println(stockMap.get(s3.getStockNumber()));
        System.out.println(stockMap);
        
    }
}
