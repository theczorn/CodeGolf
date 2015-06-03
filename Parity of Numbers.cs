/*
SOURCE: http://golf.shinh.org/p.rb?parity+of+numbers
SYNOPSIS: Print the parity of numbers from 0-255
*/

using System;
class m{
	static void Main(){
		for(int i=0;i<256;)Console.Write((Convert.ToString(i++,2).Split('1').Length-1)%2);
	}
}