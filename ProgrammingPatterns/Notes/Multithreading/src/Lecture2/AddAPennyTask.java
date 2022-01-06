package Lecture2;

/**
 * @author Anthony Nadeau
 */
public class AddAPennyTask implements Runnable {
    private Account account;
    public AddAPennyTask(Account a){account=a;}  
    
    @Override
    public void run() {
      account.deposit(1);
    }
  }
