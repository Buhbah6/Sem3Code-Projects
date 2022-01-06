package Internationalization;

import java.text.*;
import java.util.*;
import java.util.stream.Stream;

/**
 * @author Anthony  Nadeau
 */
public class DemoDFS {
    public static void main(String[] args) {
        // TODO code application logic here
        Locale[] availableLocales = Calendar.getAvailableLocales();
        System.out.println("---------All Locales");
        Stream.of(availableLocales).forEach(System.out::println);
        System.out.println("---------End  Locales");

        Locale locale1 = new Locale("en","CA");//es_NI, fo_DK, saq_KE, it_IT
        Locale locale2 = Locale.CANADA_FRENCH;//same as locale 1

//        DateFormatSymbols dfs = new
//        DateFormatSymbols(locale1);
//        String[] dayNames= dfs.getShortWeekdays();
//
//        //for(int i=0;i<7;i++)
//        //System.out.println(dayNames[i]);
//        System.out.println("---------Weekdays");
//        Stream.of(dayNames).forEach(System.out::println);
//
//        TimeZone tz = TimeZone.getDefault();
//        System.out.println("---------TimeZones\n" + tz);

//        Calendar calendar = new GregorianCalendar();
//        SimpleDateFormat sdf =  
//            new SimpleDateFormat("yyyy mm dd hh:mm.ss", locale1);
//
//        String fullDate = sdf.format(calendar.getTime());
//        System.out.println(fullDate);
//
//        DateFormat df = DateFormat.getDateTimeInstance(); //or .getInstance();
//        System.out.println(df.format(Calendar.DATE));
//        
//        NumberFormat percentFormatter =NumberFormat.getPercentInstance(locale1);
//        NumberFormat currencyForm = NumberFormat.getCurrencyInstance(locale1);
//        NumberFormat numberForm =   NumberFormat.getNumberInstance(locale1);
//        percentFormatter.setMinimumFractionDigits(2);
//        
//        double perc = 234.98;
//        double curr = 456878989.89;
//        int  num = 654728379;    
//
//        System.out.println("Percent: "+ percentFormatter.format(perc));
//        System.out.println("Curr   : "+ currencyForm.format(curr));
//        System.out.println("number :"+ numberForm.format(num));
        
        ResourceBundle res = ResourceBundle.getBundle("Internationalization/Source", locale1);
        System.out.println(res.getString("key1"));


        
    }
}
