/*
SOURCE: http://golf.shinh.org/p.rb?leap+year
SYNOPSIS: Given a list of unordered years, foreach year print if it is/is not a leap year.

SAMPLE:
	1728
	2372
	2347
	2280
	2328
to
	1728 is a leap year.
	2372 is a leap year.
	2347 is not a leap year.
	2280 is a leap year.
	2328 is a leap year.
*/

using System;
class p{
	static void Main(){
		var x="";
		while(x!=null){
			int y=int.Parse(x=Console.ReadLine());
			Console.WriteLine(y+" is"+(y%4<1&&y%100>0||y%400<1?"":" not")+" a leap year.");
		}
	}
}