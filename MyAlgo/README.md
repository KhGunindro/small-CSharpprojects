<h1>The Algorithm Used</h1>
<p>I made two conditions:
If the series is even then the series can be group like this: (1-2)+(3-4)+(5-6)+...+((n-1)-n)
and if it has odd number of elements it can be grouped like: (1-2)+(3-4)+(5-6)+...+((n-1)+n)+(n+1) 
by finding the sum until n+1 which is in this case until odd number + 1 and storing the last value of j in a temp variable we can add the temp to the final sum as even is negative.<br><br>
for example: let's take the limit 5
we will add it upto 5+1
1-2 + 3-4+ 5-6
store the sum
which is -3
but if you want to find it upto 5 only store the last element j which is -6 on a temp variable and add it on the sum
sum= sum+j.
<br>
voila you get the sum for odd number of elements in this series: 1-2+3-4+..((n-1))-n)</p>
<br>
<br>
~an algorithm by Gunin
