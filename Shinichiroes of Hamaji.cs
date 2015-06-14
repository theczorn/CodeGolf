/*
SOURCE: http://golf.shinh.org/p.rb?99+shinichiroes+of+hamaji
SYNOPSIS: Output the text pattern below:
"	99 shinichiroes of hamaji on the wall, 99 shinichiroes of hamaji.
	Take one down and pass it around, 98 shinichiroes of hamaji on the wall.

	98 shinichiroes of hamaji on the wall, 98 shinichiroes of hamaji.
	Take one down and pass it around, 97 shinichiroes of hamaji on the wall.
	.
	.
	.
	3 shinichiroes of hamaji on the wall, 3 shinichiroes of hamaji.
	Take one down and pass it around, 2 shinichiroes of hamaji on the wall.

	2 shinichiroes of hamaji on the wall, 2 shinichiroes of hamaji.
	Take one down and pass it around, 1 shinichiro of hamaji on the wall.

	1 shinichiro of hamaji on the wall, 1 shinichiro of hamaji.
	Go to the store and buy some more, 99 shinichiroes of hamaji on the wall."
*/
using System;
class m{
	static void Main(){
		var w=" on the wall";
		var s=" shinichiro{0} of hamaji";
		for(int n=99;n>0;Console.Write("{1:Take one down and pass it around;;Go to the store and buy some more}, {2}"+s+w+".\n\n",n==1?"":"es",n,n>0?n:99))
			Console.Write(n+s+w+", "+n--+s+".\n",n>0?"es":"");
	}
}