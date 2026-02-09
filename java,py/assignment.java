import java.util.Scanner
public class question3{
 public static void main(String []args){
	Scanner scanner = new scanner (System.in);
double oxygenTank = 500.0;
int diverCount = 0;
while(oxygenTank > 50){
System.out.Println("Enter oxygen needed for next dive: ");
double oxygenNeeded = scanner.nextDouble();
if (oxygenNeeded > OxygenTank){
System.out.Println("Insufficient oxygen for this dive!");
break;
}

else{oxygeTank -= oxygenNeeded;
diverCount += 1;
System.out.Println("Successful Dive!");
}

if (oxygenTank < 150){System.out.Println("WARNING!!!: Oxygen level at "+ oxygenTank + ". Quickly return to surface."); 
}
}

System.out.Println("Total Dives: "+ diverCount);
System.out.Println("Remaining Oxygen: " + oxyenTank);
scanner.close();

}
}


