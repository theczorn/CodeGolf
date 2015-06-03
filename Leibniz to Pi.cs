/*
SOURCE: https://www.hackerrank.com/challenges/leibniz
SYNOPSIS: Given a number of Test Cases T (T < 100) find the summation of the Leibniz formula up to N
*/

using System;
class M{
	static void Main(){
		for(int T=int.Parse(Console.ReadLine());T-->0;){
			var r=.0;
			for(int N=int.Parse(Console.ReadLine());N-->0;r+=Math.Pow(-1,N)/(2*N+1)){}
				Console.WriteLine(r);
		}
	}
}