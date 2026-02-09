import java.util.Scanner;
public class question5 {
public static void main(String []args){

Scanner scanner = Scanner (System.in);
int attempts = 0;
int maxAttempts 3;

do {
     attempts += 1
     System.out.Prinln("Enter the temperature: ");
     double temp = scanner.nextDouble();
     if (temp >= 20 && <=40){ 
	break;
	} else{
	System.out.Println("Invalid Temperature!");
	System.out.Println("You have " + attempts + " out of 3 used.");

	}
	

} while (attempts < maxAttempts);

if(attempts == 3){
System.out.Println("You have run out of attempts!")
}
else{System.out.Println("Success! That is a valid temperature")
}

scanner.close();



}

}
