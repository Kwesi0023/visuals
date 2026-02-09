public class question1 {
public static void main(String []args){

double [] prices = {15.0, 55.0, 120.0 200.0};

double totalBill = 0.0;

for(int i = 0; i<= (prices.length -1) price; i++) {
Boolean isDiscounted = false;
double currentPrice = prices[i];


if (currentPrice > 100) {
double discountPrice = 0.2 * currentPrice;
currentPrice = currentPrice - discountPrice;
isDiscounted = true;
totalBill += currentPrice;
}
else{ totalBill += currentPrice; }
}

system.Out.Println((i+1) + ". " + "$" + currentPrice);

if (isDiscounted){
System.out.Println("20% Discount Applied!");
}
System.outPrintln("Your total Bill is $"+ totalBill);
}

}

