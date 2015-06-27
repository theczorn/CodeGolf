/*
SOURCE: https://www.codingame.com/ide/15271291399aa565b7aaf97725be746dbb2c51f
SYNOPSIS: Given a ' ' delimited string containing the following items
	[0] = X coordinate of light source
	[1] = Y coordinate of light source
	[2] = X coordinate of Thor {ALIASED AS 'A' IN CODE}
	[3] = Y coordinate of Thor {ALIASED AS 'B' IN CODE}
	Output a series of compass (NSEW) directions stepwise to move the Thor to the light source
	using a the fewest moves possible and without moving "off grid"
	
NOTE: The size of our grid is X={0,40}; Y={0,18}.
*/
namespace System{using Linq;
class p
{static void Main(){
	var i=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
	for(int A=i[2],B=i[3];;A-=Math.Sign(A-i[0]),B-=Math.Sign(B-i[1]))
	Console.Write("{1:N;S;}{0:W;E;}\n",A-i[0],B-i[1]);
}
}}