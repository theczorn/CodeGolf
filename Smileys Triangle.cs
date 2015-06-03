/*
SOURCE: http://golf.shinh.org/p.rb?Smileys+Triangle
SYNOPSIS: Output the below text sequence contained in "{}" 34 iterations deep
{
:
:-
:-)
:-)))
:-)))))
:-)))))))
:-)))))))))
:-)))))))))))
}
etc...
*/

class p{
	static void Main(){
		var y="";
		for(int i=0;i<34;i++)System.Console.WriteLine(i>2?y+="))":y+=":-)"[i]);
	}
}