import math
print('Hey there \n')
print('An airline reported that there is 60% probability a passenger prefers hot tea before a meal' 
      ' is served during a long flights. Consider a random selection of 5 passengers ' 
      ' from a particular long flight, Accra to New York. \n ' 
      ' (a) What is the prob that at least 2 of the selected passengers prefer to take hot tea before meal? \n ' 
      ' (b) What is the prob that more than 2 of the selected passengers prefer to take hot tea before a meal?  \n' 
      )
print('\n')
print('p = 60%   =0.60' )
print ('q = 1-p')
print('q =0.40 \n')
print(' (a) \n P(x >= 2) = 1 - [p(0) + p(1)]  ' )

comb1= math.factorial(5) // (math.factorial(0) *  math.factorial(5-0))
P0=0.60**0
P00= 0.40**(5-0)
p0= comb1*P0*P00

comb2 =math.factorial(5) // (math.factorial(1) * math.factorial(5-1))
P1=0.60**1
P11=0.40**(5-1)
p1=comb2*P1*P11

print( 'P(x >= 2) = ' ,p0, '+', p1)
print('P(x >= 2) = ' +  str(1- (p0 + p1)) + '\n')


print(' (b) \n P(x > 2) =  p(3) + p(4) + p(5) ')
comb3= math.factorial(5) // (math.factorial(3) *math.factorial(5-3))
P3=0.60**3
P33=0.40**(5-3)
p3=comb3*P3*P33

comb4=math.factorial(5) //(math.factorial(4) *math.factorial(5-4))
P4=0.60**4
P44=0.40**(5-4)
p4=comb4*P4*P44

comb5=math.factorial(5) // (math.factorial(5) *math.factorial(5-5))
P5=0.60**5
P55=0.40**(5-5)
p5=comb5*P5*P55


print('P(x > 2) = ',p3,'+',p4,'+',p5)
print('P(x > 2) = ' + str(p3+p4+p5))