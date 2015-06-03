/*
SOURCE: http://golf.shinh.org/p.rb?FizzBuzz
SYNOPSIS: Print integers 1 to 100, but replace multiples of 3 with "Fizz" and multiples of 5 with "Buzz" and multiples of both with "FizzBuzz"
*/

class p{
	static void Main(){
		for(int i=0;i++<100;)System.Console.Write("{0:#}{1:;;Fizz}{2:;;Buzz}\n",i%3*i%5<1?0:i,i%3,i%5);
	}
}

//OR not as good...
//for(int i=0;i++<100;)System.Console.WriteLine(i%15>0?i%3>0?i%5>0?i+"":"Buzz":"Fizz":"FizzBuzz");

//Consider floating pt or binary loops

LEGEND:
# = iterable value
{0} = "Fizz"
{1} = "Buzz"
##{0}#{1}{0}##{0}{1}#{0}##{0}{1}
##{0}#{1}{0}##{0}{1}//EXCESSHERE