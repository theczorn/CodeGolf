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
class m{
	static void Main(){
		string h=" of hamaji",e="es"+h,s=" shinichiro",p=99+s+e;
		for(int i=99;i-->0;)
			System.Console.Write("{0}{3}, {0}.\n{2:Take one down and pass it around;;Go to the store and buy some more}, {1}{3}.\n\n",p,p=(i<1?99:i)+s+(i==1?h:e),i," on the wall");
	}
}
