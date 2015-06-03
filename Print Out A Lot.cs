/*
SOURCE: http://golf.shinh.org/p.rb?Print+out+a+lot+_56K+BEWARE_
SYNOPSIS: Print out the space delimited #'s from 0 to 99999

FUTURE TIPS: Attempt to use Lambda Enumerable Ranges?
*/

class m{
	static void Main(){
		for(int i=0;++i<100000;)System.Console.Write(i+" ");
	}
}