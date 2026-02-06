// differnce in the declarations (Applied mainly in 2D-Array)
int a,b[];
int a[], b;
int [] a,b; 

// you can declare multiple arrays in a single line but you have to be careful with the syntax. The position of the square brackets determines whether the variable is an array or not.
// you can declare an array like that of C++

// you allocate a new meomry with the key word "new"

int[] month_days; // Array Declaration
month = new int[12] // Array (memory) allocation

int[] month_days = new int[12]; // Array Declaration and Memory Allocation in a single line

// dynamic value assignment
month_days[0] = 31; // Initializing the first element of the array
System.out.println("The month January has" + month[0] + " days."); // also do not forget to end your line with a semi colon(;)


// Static value assignment
int[] month_days = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
System.out.println("The month January has" + month[2] + " days.");


