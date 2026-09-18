/*
SOURCE: http://golf.shinh.org/p.rb?99+shinichiroes+of+hamaji
SYNOPSIS: Output the text pattern below:
	"99 shinichiroes of hamaji on the wall, 99 shinichiroes of hamaji.
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
class m
{
	static void Main(){
		string f="{0:0;;99} shinichiro{1:es;;} of hamaji",g=f+" on the wall",d="";for(int i=100;i-->0;d=g+@".

")System.Console.Write(i>0?d+g+", "+f+".\n{1:Take one down and pass it around;;Go to the store and buy some more}, ":d,i,i^1);
	}
}
