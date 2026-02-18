import java.util.Scanner;

public class SavingsTracker {
    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);

        double balance = 0.0;
        double goal = 100.0;

        do {
            System.out.print("Enter amount to deposit: ");
            double deposit = reader.next.Double();
            balance += deposit;


            System.out.print("Current balance is " + balance);
        } while (balance < goal);
        System.out.println("Goal reached! Total Saved: " + balance);

        reader.close();

    }
}

// get the synthax and config everything